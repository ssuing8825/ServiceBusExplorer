#region Copyright
//=======================================================================================
// Microsoft Business Platform Division Customer Advisory Team  
//
// This sample is supplemental to the technical guidance published on the community
// blog at http://www.appfabriccat.com/. 
// 
// Author: Paolo Salvatori
//=======================================================================================
// Copyright © 2011 Microsoft Corporation. All rights reserved.
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, EITHER 
// EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES OF 
// MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE. YOU BEAR THE RISK OF USING IT.
//=======================================================================================
#endregion

#region Using Directives
using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
#endregion

// ReSharper disable CheckNamespace
namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
// ReSharper restore CheckNamespace
{
    public enum BodyType
    {
        Stream,
        String,
        Wcf
    }

    public class ServiceBusHelper
    {
        #region Private Constants
        //***************************
        // Formats
        //***************************
        private const string ExceptionFormat = "Exception: {0}";
        private const string InnerExceptionFormat = "InnerException: {0}";
        private const string StackTraceFormat = "StackTrace: {0}";

        //***************************
        // Constants
        //***************************
        private const string DefaultScheme = "sb";
        private const string MessageNumber = "MessageNumber";
        private const string StringType = "String";
        private const string DeadLetterQueue = "$DeadLetterQueue";
        private const string NullValue = "NULL";
        private const int MaxBufferSize = 262144; // 256 KB

        //***************************
        // Messages
        //***************************
        private const string ServiceBusUriArgumentCannotBeNull = "The uri argument cannot be null.";
        private const string ServiceBusNamespaceArgumentCannotBeNull = "The nameSpace argument cannot be null.";
        private const string ServiceBusIssuerNameArgumentCannotBeNull = "The issuerName argument cannot be null.";
        private const string ServiceBusIssuerSecretArgumentCannotBeNull = "The issuerSecret argument cannot be null.";
        private const string NamespaceManagerCannotBeNull = "The namespace manager argument cannot be null.";
        private const string QueueDescriptionCannotBeNull = "The queue description argument cannot be null.";
        private const string TopicDescriptionCannotBeNull = "The topic decsription argument cannot be null.";
        private const string SubscriptionDescriptionCannotBeNull = "The subscription description argument cannot be null.";
        private const string RuleDescriptionCannotBeNull = "The rule description argument cannot be null.";
        private const string RuleCannotBeNull = "The rule argument cannot be null.";
        private const string PathCannotBeNull = "The path argument cannot be null or empty.";
        private const string NameCannotBeNull = "The name argument cannot be null or empty.";
        private const string DescriptionCannotBeNull = "The description argument cannot be null.";
        private const string ServiceBusNamespaceDoesNotExist = "The serviceBusNamespace {0} does not exist in the ServiceBusNamespaces collection.";
        private const string ServiceBusIsDisconnected = "The application is now disconnected from any service bus namespace.";
        private const string ServiceBusIsConnected = "The application is now connected to the {0} service bus namespace.";
        private const string QueueCreated = "The queue {0} has been successfully created.";
        private const string QueueDeleted = "The queue {0} has been successfully deleted.";
        private const string TopicCreated = "The topic {0} has been successfully created.";
        private const string TopicDeleted = "The topic {0} has been successfully deleted.";
        private const string SubscriptionCreated = "The {0} subscription for the {1} topic has been successfully created.";
        private const string SubscriptionDeleted = "The {0} subscription for the {1} topic has been successfully deleted.";
        private const string RuleCreated = "The {0} rule for the {1} subscription has been successfully created.";
        private const string RuleDeleted = "The {0} rule for the {1} subscription has been successfully deleted.";
        private const string WarningHeader = "The following validations failed:";
        private const string WarningFormat = "\n\r - {0}";
        private const string PropertyConversionError = "{0} property conversion error: {1}";
        private const string PropertyValueCannotBeNull = "The value of the {0} property cannot be null.";
        private const string MessageSuccessfullySent = "Sender[{0}]:   Message sent. MessageId=[{1}] SessionId=[{2}] Label=[{3}] Size=[{4}]";
        private const string MessageSuccessfullyReceived = "Receiver[{0}]: Message received. MessageId=[{1}] SessionId=[{2}] Label=[{3}] Size=[{4}] DeliveryCount[{5}]";
        private const string MessagePeekedButNotConsumed = "Receiver[{0}]: Message peeked, but not consumed. MessageId=[{1}] SessionId=[{2}] Label=[{3}] Size=[{4}]";
        private const string MessageSuccessfullyReceivedNoTask = "Message {0}: MessageId=[{1}] SessionId=[{2}] Label=[{3}] Size=[{4}] DeliveryCount[{5}]";
        private const string ReceiverStatitiscsLineNoTask = "Messages {0}: Count=[{1}]";
        private const string SentMessagePropertiesHeader = "Properties:";
        private const string ReceivedMessagePropertiesHeader = "Properties:";
        private const string SentMessagePayloadHeader = "Payload:";
        private const string ReceivedMessagePayloadHeader = "Payload:";
        private const string MessageTextFormat = "{0}";
        private const string MessagePropertyFormat = " - Key=[{0}] Value=[{1}]";
        private const string MessageDeferred = " - The message was deferred.";
        private const string ReadMessageDeferred = " - Read deferred message.";
        private const string MessageMovedToDeadLetterQueue = " - The message was moved to the DeadLetter queue.";
        private const string MessageReadFromDeadLetterQueue = " - The message was read from the DeadLetter queue.";
        private const string NoMessageWasReceived = "Receiver[{0}]: no message was received";
        private const string SenderStatisticsHeader = "Sender[{0}]:";
        private const string SenderStatitiscsLine1 = " - Message Count=[{0}] Messages Sent/Sec=[{1}] Total Elapsed Time (ms)=[{2}]";
        private const string SenderStatitiscsLine2 = " - Average Send Time (ms)=[{0}] Minimum Send Time (ms)=[{1}] Maximum Send Time (ms)=[{2}] ";
        private const string ReceiverStatisticsHeader = "Receiver[{0}]:";
        private const string ReceiverStatitiscsLine1 = " - Message Count=[{0}] Messages Read/Sec=[{1}] Total Elapsed Time (ms)=[{2}]";
        private const string ReceiverStatitiscsLine2 = " - Average Receive Time (ms)=[{0}] Minimum Receive Time (ms)=[{1}] Maximum Receive Time (ms)=[{2}] ";
        private const string ExceptionOccurred = " - Exception occurred: {0}";
        private const string UnableToReadMessageBody = "Unable to read the message body.";
        private const string MessageSenderCannotBeNull = "The MessageSender parameter cannot be null.";
        private const string MessageReceiverCannotBeNull = "The MessageReceiver parameter cannot be null.";
        private const string BrokeredMessageCannotBeNull = "The BrokeredMessage parameter cannot be null.";
        private const string CancellationTokenSourceCannotBeNull = "The CancellationTokenSource parameter cannot be null.";
        private const string MessageIsNotXML = "The message is not in XML format.";
        private const string MessageFactorySuccessfullyCreated = "MessagingFactory successfully created";
        private const string Read = "read";
        private const string Peeked = "peeked";
        #endregion

        #region Private Fields
        private Type messageDeferProviderType = typeof(InMemoryMessageDeferProvider);
        private Dictionary<string, ServiceBusNamespace> serviceBusNamespaces;
        private NamespaceManager namespaceManager;
        private MessagingFactory messagingFactory;
        private bool traceEnabled = true;
        private string scheme = DefaultScheme;
        private TokenProvider tokenProvider;
        private Uri namespaceUri;
        private Uri atomFeedUri;
        private string ns;
        private string servicePath;
        private string currentIssuerName;
        private string currentIssuerSecret;
        private List<BrokeredMessage> brokeredMessageList;
        private readonly WriteToLogDelegate writeToLog;
        #endregion

        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the ServiceBusHelper class.
        /// </summary>
        /// <param name="writeToLog">WriteToLog method.</param>
        public ServiceBusHelper(WriteToLogDelegate writeToLog)
        {
            this.writeToLog = writeToLog;
            traceEnabled = true;
        }

        /// <summary>
        /// Initializes a new instance of the ServiceBusHelper class.
        /// </summary>
        /// <param name="writeToLog">WriteToLog method.</param>
        /// <param name="traceEnabled">A boolean value indicating whether tracing is enabled.</param>
        public ServiceBusHelper(WriteToLogDelegate writeToLog, bool traceEnabled)
        {
            this.writeToLog = writeToLog;
            this.traceEnabled = traceEnabled;
        }

        /// <summary>
        /// Initializes a new instance of the ServiceBusHelper class.
        /// </summary>
        /// <param name="writeToLog">WriteToLog method.</param>
        /// <param name="serviceBusHelper">Base ServiceBusHelper.</param>
        public ServiceBusHelper(WriteToLogDelegate writeToLog, ServiceBusHelper serviceBusHelper)
        {
            this.writeToLog = writeToLog;
            traceEnabled = serviceBusHelper.TraceEnabled;
            AtomFeedUri = serviceBusHelper.AtomFeedUri;
            IssuerName = serviceBusHelper.IssuerName;
            IssuerSecret = serviceBusHelper.IssuerSecret;
            MessageDeferProviderType = serviceBusHelper.MessageDeferProviderType;
            MessagingFactory = serviceBusHelper.MessagingFactory;
            Namespace = serviceBusHelper.Namespace;
            NamespaceUri = serviceBusHelper.NamespaceUri;
            IssuerSecret = serviceBusHelper.IssuerSecret;
            MessageDeferProviderType = serviceBusHelper.MessageDeferProviderType;
            MessagingFactory = serviceBusHelper.MessagingFactory;
            Namespace = serviceBusHelper.Namespace;
            Scheme = serviceBusHelper.Scheme;
            ServiceBusNamespaces = serviceBusHelper.ServiceBusNamespaces;
            ServicePath = serviceBusHelper.ServicePath;
            TokenProvider = serviceBusHelper.TokenProvider;
            TraceEnabled = serviceBusHelper.TraceEnabled;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the type of the message defer provider
        /// </summary>
        public Type MessageDeferProviderType
        {
            get
            {
                lock (this)
                {
                    return messageDeferProviderType;
                }
            }
            set
            {
                lock (this)
                {
                    if (value.GetInterfaces().Contains(typeof(IMessageDeferProvider)))
                    {
                        messageDeferProviderType = value;
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets a boolean value indicating whether tracing is enabled.
        /// </summary>
        public bool TraceEnabled
        {
            get
            {
                lock (this)
                {
                    return traceEnabled;
                }
            }
            set
            {
                lock (this)
                {
                    traceEnabled = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the scheme of the URI.
        /// </summary>
        public string Scheme
        {
            get
            {
                lock (this)
                {
                    return scheme;
                }
            }
            set
            {
                lock (this)
                {
                    scheme = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the current namespace.
        /// </summary>
        public string Namespace
        {
            get
            {
                lock (this)
                {
                    return ns;
                }
            }
            set
            {
                lock (this)
                {
                    ns = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the current service path.
        /// </summary>
        public string ServicePath
        {
            get
            {
                lock (this)
                {
                    return servicePath;
                }
            }
            set
            {
                lock (this)
                {
                    servicePath = value;
                    if (!string.IsNullOrEmpty(servicePath) &&
                        servicePath[servicePath.Length - 1] != '/')
                    {
                        servicePath = servicePath + '/';
                    }
                }
            }
        }

        /// <summary>
        /// Gets or sets the issuer name.
        /// </summary>
        public string IssuerName
        {
            get
            {
                lock (this)
                {
                    return currentIssuerName;
                }
            }
            set
            {
                lock (this)
                {
                    currentIssuerName = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the issuer secret.
        /// </summary>
        public string IssuerSecret
        {
            get
            {
                lock (this)
                {
                    return currentIssuerSecret;
                }
            }
            set
            {
                lock (this)
                {
                    currentIssuerSecret = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the URI of the current service bus namespace.
        /// </summary>
        public Uri NamespaceUri
        {
            get
            {
                lock (this)
                {
                    return namespaceUri;
                }
            }
            set
            {
                lock (this)
                {
                    namespaceUri = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the URI of the atom feed for the current namespace.
        /// </summary>
        public Uri AtomFeedUri
        {
            get
            {
                lock (this)
                {
                    return atomFeedUri;
                }
            }
            set
            {
                lock (this)
                {
                    atomFeedUri = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the credentials of the current service bus account.
        /// </summary>
        public TokenProvider TokenProvider
        {
            get
            {
                lock (this)
                {
                    return tokenProvider;
                }
            }
            set
            {
                lock (this)
                {
                    tokenProvider = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the MessagingFactory
        /// </summary>
        public MessagingFactory MessagingFactory
        {
            get
            {
                lock (this)
                {
                    if (messagingFactory == null ||
                        messagingFactory.IsClosed)
                    {
                        messagingFactory = GetMessagingFactory();
                    }
                    return messagingFactory;
                }
            }
            set
            {
                lock (this)
                {
                    messagingFactory = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the dictionary containing serviceBus accounts.
        /// </summary>
        public Dictionary<string, ServiceBusNamespace> ServiceBusNamespaces
        {
            get
            {
                return serviceBusNamespaces;
            }
            set
            {
                serviceBusNamespaces = value;
            }
        }
        #endregion

        #region Public Events
        public delegate void EventHandler(ServiceBusHelperEventArgs args);
        public event EventHandler OnDelete;
        public event EventHandler OnCreate;
        #endregion

        #region Public Methods
        /// <summary>
        /// Connects the ServiceBusHelper object to service bus namespace contained in the ServiceBusNamespaces dictionary.
        /// </summary>
        /// <param name="serviceBusNamespace">The key of the service bus namespace in the ServiceBusNamespaces dictionary.</param>
        /// <returns>True if the operation succeeds, false otherwise.</returns>
        public bool Connect(string serviceBusNamespace)
        {
            Func<bool> func = (() =>
            {
                if (string.IsNullOrEmpty(serviceBusNamespace))
                {
                    throw new ArgumentException(ServiceBusNamespaceArgumentCannotBeNull);
                }
                if (serviceBusNamespaces.ContainsKey(serviceBusNamespace))
                {
                    // Create the service URI using the scheme, namespace and service path (optional)
                    namespaceUri = ServiceBusEnvironment.CreateServiceUri(scheme,
                                                                        serviceBusNamespaces[
                                                                            serviceBusNamespace
                                                                            ].Namespace,
                                                                        serviceBusNamespaces[
                                                                            serviceBusNamespace
                                                                            ].ServicePath);
                    // Create the atom feed URI using the scheme, namespace and service path (optional)
                    atomFeedUri = ServiceBusEnvironment.CreateServiceUri("http",
                                                                        serviceBusNamespaces[
                                                                            serviceBusNamespace
                                                                            ].Namespace,
                                                                        serviceBusNamespaces[
                                                                            serviceBusNamespace
                                                                            ].ServicePath);

                    Namespace = serviceBusNamespaces[serviceBusNamespace].Namespace;
                    ServicePath = serviceBusNamespaces[serviceBusNamespace].ServicePath;

                    // Create shared secret credentials to to authenticate with the Access Control service, 
                    // and acquire an access token that proves to the Service Bus insfrastructure that the 
                    // the Service Bus Explorer is authorized to access the entities in the specified namespace.
                    tokenProvider =
                        TokenProvider.CreateSharedSecretTokenProvider(
                            serviceBusNamespaces[serviceBusNamespace].IssuerName,
                            serviceBusNamespaces[serviceBusNamespace].IssuerSecret);

                    currentIssuerName = serviceBusNamespaces[serviceBusNamespace].IssuerName;
                    currentIssuerSecret = serviceBusNamespaces[serviceBusNamespace].IssuerSecret;

                    // Create and instance of the NamespaceManagerSettings which 
                    // specifies service namespace client settings and metadata.
                    var namespaceManagerSettings = new NamespaceManagerSettings
                                                    {
                                                        TokenProvider = tokenProvider,
                                                        OperationTimeout =
                                                            TimeSpan.FromMinutes(5)
                                                    };

                    // The NamespaceManager class can be used for managing entities, 
                    // such as queues, topics, subscriptions, and rules, in your service namespace. 
                    // You must provide service namespace address and access credentials in order 
                    // to manage your service namespace.
                    namespaceManager = new NamespaceManager(namespaceUri,
                                                            namespaceManagerSettings);
                    WriteToLogIf(traceEnabled,
                                    string.Format(CultureInfo.CurrentCulture,
                                                    ServiceBusIsConnected,
                                                    namespaceUri.AbsoluteUri));

                    // The MessagingFactorySettings specifies the service bus messaging factory settings.
                    var messagingFactorySettings = new MessagingFactorySettings
                                                    {
                                                        TokenProvider = tokenProvider,
                                                        OperationTimeout =
                                                            TimeSpan.FromMinutes(5)
                                                    };
                    // In the first release of the service bus, the only available transport protocol is sb 
                    if (scheme == DefaultScheme)
                    {
                        messagingFactorySettings.NetMessagingTransportSettings =
                            new NetMessagingTransportSettings();
                    }

                    // As the name suggests, the MessagingFactory class is a Factory class that allows to create
                    // instances of the QueueClient, TopicClient and SubscriptionClient classes.
                    MessagingFactory = MessagingFactory.Create(namespaceUri,
                                                            messagingFactorySettings);
                    WriteToLogIf(traceEnabled, MessageFactorySuccessfullyCreated);
                    return true;
                }
                throw new ApplicationException(string.Format(CultureInfo.CurrentCulture,
                                                            ServiceBusNamespaceDoesNotExist,
                                                            serviceBusNamespace));
            });
            return RetryHelper.RetryFunc(func, writeToLog);
        }

        /// <summary>
        /// Connects the ServiceBusHelper object to service bus namespace contained in the ServiceBusNamespaces dictionary.
        /// </summary>
        /// <param name="nameSpace">The namespace of the Service Bus.</param>
        /// <param name="path">The service path that follows the host name section of the URI.</param>
        /// <param name="issuerName">The issuer name of the shared secret credentials.</param>
        /// <param name="issuerSecret">The issuer secret of the shared secret credentials.</param>
        /// <returns>True if the operation succeeds, false otherwise.</returns>
        public bool Connect(string nameSpace, string path, string issuerName, string issuerSecret)
        {
            Func<bool> func = (() =>
            {
                if (string.IsNullOrEmpty(nameSpace))
                {
                    throw new ArgumentException(ServiceBusNamespaceArgumentCannotBeNull);
                }
                if (string.IsNullOrEmpty(issuerName))
                {
                    throw new ArgumentException(ServiceBusIssuerNameArgumentCannotBeNull);
                }
                if (string.IsNullOrEmpty(issuerSecret))
                {
                    throw new ArgumentException(ServiceBusIssuerSecretArgumentCannotBeNull);
                }

                // Create the service URI using the scheme, namespace and service path (optional)
                namespaceUri = ServiceBusEnvironment.CreateServiceUri(scheme,
                                                                    nameSpace,
                                                                    path);
                // Create the atom feed URI using the scheme, namespace and service path (optional)
                atomFeedUri = ServiceBusEnvironment.CreateServiceUri("http",
                                                                    nameSpace,
                                                                    path);
                Namespace = nameSpace;
                ServicePath = path;

                // Create shared secret credentials to to authenticate with the Access Control service, 
                // and acquire an access token that proves to the Service Bus insfrastructure that the 
                // the Service Bus Explorer is authorized to access the entities in the specified namespace.
                //tokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName,
                //                                                              issuerSecret);

                currentIssuerName = issuerName;
                currentIssuerSecret = issuerSecret;

                // Create and instance of the NamespaceManagerSettings which 
                // specifies service namespace client settings and metadata.
                var namespaceManagerSettings = new NamespaceManagerSettings
                {
                    TokenProvider = tokenProvider,
                    OperationTimeout = TimeSpan.FromMinutes(5)
                };

                // The NamespaceManager class can be used for managing entities, 
                // such as queues, topics, subscriptions, and rules, in your service namespace. 
                // You must provide service namespace address and access credentials in order 
                // to manage your service namespace.
                ////////////// namespaceManager = new NamespaceManager(namespaceUri, namespaceManagerSettings);
                namespaceManager = NamespaceManager.Create();

                //////////////WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, ServiceBusIsConnected, namespaceUri.AbsoluteUri));

                //////////////// The MessagingFactorySettings specifies the service bus messaging factory settings.
                //////////////var messagingFactorySettings = new MessagingFactorySettings
                //////////////{
                //////////////    TokenProvider = tokenProvider,
                //////////////    OperationTimeout = TimeSpan.FromMinutes(5)
                //////////////};
                //////////////// In the first release of the service bus, the only available transport protocol is sb 
                //////////////if (scheme == DefaultScheme)
                //////////////{
                //////////////    messagingFactorySettings.NetMessagingTransportSettings = new NetMessagingTransportSettings();
                //////////////}

                // As the name suggests, the MessagingFactory class is a Factory class that allows to create
                // instances of the QueueClient, TopicClient and SubscriptionClient classes.
             //   MessagingFactory = MessagingFactory.Create(namespaceUri, messagingFactorySettings);

                MessagingFactory = MessagingFactory.Create();

                WriteToLogIf(traceEnabled, MessageFactorySuccessfullyCreated);
                return true;
            });
            return RetryHelper.RetryFunc(func, writeToLog);
        }

        /// <summary>
        /// Connects the ServiceBusHelper object to service bus namespace contained in the ServiceBusNamespaces dictionary.
        /// </summary>
        /// <param name="uri">The full uri of the service namespace.</param>
        /// <param name="issuerName">The issuer name of the shared secret credentials.</param>
        /// <param name="issuerSecret">The issuer secret of the shared secret credentials.</param>
        /// <returns>True if the operation succeeds, false otherwise.</returns>
        public bool Connect(string uri, string issuerName, string issuerSecret)
        {
            Func<bool> func = (() =>
            {
                if (string.IsNullOrEmpty(uri))
                {
                    throw new ArgumentException(ServiceBusUriArgumentCannotBeNull);
                }
                if (string.IsNullOrEmpty(issuerName))
                {
                    throw new ArgumentException(ServiceBusIssuerNameArgumentCannotBeNull);
                }
                if (string.IsNullOrEmpty(issuerSecret))
                {
                    throw new ArgumentException(ServiceBusIssuerSecretArgumentCannotBeNull);
                }

                // Create the service URI using the uri specified in the Connect form
                namespaceUri = new Uri(uri);
                if (!string.IsNullOrEmpty(namespaceUri.Host) &&
                    namespaceUri.Host.Contains('.'))
                {
                    Namespace = namespaceUri.Host.Substring(0, namespaceUri.Host.IndexOf('.'));
                }

                // Create the atom feed URI using the scheme, namespace and service path (optional)
                if (uri.Substring(0, 4) != "http")
                {
                    var index = uri.IndexOf("://", StringComparison.Ordinal);
                    if (index > 0)
                    {
                        uri = "http" + uri.Substring(index);
                    }
                }
                atomFeedUri = new Uri(uri);
                
                ServicePath = string.Empty;

                // Create shared secret credentials to to authenticate with the Access Control service, 
                // and acquire an access token that proves to the Service Bus insfrastructure that the 
                // the Service Bus Explorer is authorized to access the entities in the specified namespace.
                tokenProvider = TokenProvider.CreateSharedSecretTokenProvider(issuerName,
                                                                              issuerSecret);

                currentIssuerName = issuerName;
                currentIssuerSecret = issuerSecret;

                // Create and instance of the NamespaceManagerSettings which 
                // specifies service namespace client settings and metadata.
                var namespaceManagerSettings = new NamespaceManagerSettings
                {
                    TokenProvider = tokenProvider,
                    OperationTimeout = TimeSpan.FromMinutes(5)
                };

                // The NamespaceManager class can be used for managing entities, 
                // such as queues, topics, subscriptions, and rules, in your service namespace. 
                // You must provide service namespace address and access credentials in order 
                // to manage your service namespace.
                namespaceManager = new NamespaceManager(namespaceUri, namespaceManagerSettings);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, ServiceBusIsConnected, namespaceUri.AbsoluteUri));

                // The MessagingFactorySettings specifies the service bus messaging factory settings.
                var messagingFactorySettings = new MessagingFactorySettings
                {
                    TokenProvider = tokenProvider,
                    OperationTimeout = TimeSpan.FromMinutes(5)
                };
                // In the first release of the service bus, the only available transport protocol is sb 
                if (scheme == DefaultScheme)
                {
                    messagingFactorySettings.NetMessagingTransportSettings = new NetMessagingTransportSettings();
                }

                // As the name suggests, the MessagingFactory class is a Factory class that allows to create
                // instances of the QueueClient, TopicClient and SubscriptionClient classes.
                MessagingFactory = MessagingFactory.Create(namespaceUri, messagingFactorySettings);
                WriteToLogIf(traceEnabled, MessageFactorySuccessfullyCreated);
                return true;
            });
            return RetryHelper.RetryFunc(func, writeToLog);
        }

        /// <summary>
        /// Retrieves an enumerable collection of all queues in the service bus namespace.
        /// </summary>
        /// <returns>Returns an IEnumerable<QueueDescription/> collection of all queues in the service namespace. 
        ///          Returns an empty collection if no queue exists in this service namespace.</returns>
        public IEnumerable<QueueDescription> GetQueues()
        {
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetQueues(), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Retrieves the queue from the service namespace.
        /// </summary>
        /// <param name="path">Path of the queue relative to the service namespace base address.</param>
        /// <returns>A QueueDescription handle to the queue, or null if the queue does not exist in the service namespace. </returns>
        public QueueDescription GetQueue(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetQueue(path), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Retrieves the topic from the service namespace.
        /// </summary>
        /// <param name="path">Path of the topic relative to the service namespace base address.</param>
        /// <returns>A TopicDescription handle to the topic, or null if the topic does not exist in the service namespace. </returns>
        public TopicDescription GetTopic(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetTopic(path), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Retrieves an enumerable collection of all topics in the service bus namespace.
        /// </summary>
        /// <returns>Returns an IEnumerable<TopicDescription/> collection of all topics in the service namespace. 
        ///          Returns an empty collection if no topic exists in this service namespace.</returns>
        public IEnumerable<TopicDescription> GetTopics()
        {
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetTopics(), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Gets a subscription attached to the topic passed a parameter.
        /// </summary>
        /// <param name="topicPath">The name of a topic belonging to the current service namespace base.</param>
        /// <param name="name">The name of the subscription to get.</param>
        /// <returns>Returns the subscription with the specified name.</returns>
        public SubscriptionDescription GetSubscription(string topicPath, string name)
        {
            if (namespaceManager == null)
            {
                throw new ArgumentException(NamespaceManagerCannotBeNull);
            }
            if (string.IsNullOrEmpty(topicPath))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(NameCannotBeNull);
            }
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetSubscription(topicPath, name), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Retrieves an enumerated collection of subscriptions attached to the topic passed as a parameter.
        /// </summary>
        /// <param name="topic">A topic belonging to the current service namespace base.</param>
        /// <returns>Returns an IEnumerable<SubscriptionDescription/> collection of subscriptions attached to the topic passed as a parameter.</returns>
        public IEnumerable<SubscriptionDescription> GetSubscriptions(TopicDescription topic)
        {
            if (topic == null)
            {
                throw new ArgumentException(TopicDescriptionCannotBeNull);
            }
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetSubscriptions(topic.Path), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Retrieves an enumerated collection of subscriptions attached to the topic whose name is passed as a parameter.
        /// </summary>
        /// <param name="topicPath">The name of a topic belonging to the current service namespace base.</param>
        /// <returns>Returns an IEnumerable<SubscriptionDescription/> collection of subscriptions attached to the topic passed as a parameter.</returns>
        public IEnumerable<SubscriptionDescription> GetSubscriptions(string topicPath)
        {
            if (string.IsNullOrEmpty(topicPath))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetSubscriptions(topicPath), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Retrieves an enumerated collection of rules attached to the subscription passed as a parameter.
        /// </summary>
        /// <param name="subscription">A subscription belonging to the current service namespace base.</param>
        /// <returns>Returns an IEnumerable<SubscriptionDescription/> collection of rules attached to the subscription passed as a parameter.</returns>
        public IEnumerable<RuleDescription> GetRules(SubscriptionDescription subscription)
        {
            if (subscription == null)
            {
                throw new ArgumentException(SubscriptionDescriptionCannotBeNull);
            }
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetRules(subscription.TopicPath, subscription.Name), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Retrieves an enumerated collection of rules attached to the subscription passed as a parameter.
        /// </summary>
        /// <param name="topicPath">The name of a topic belonging to the current service namespace base.</param>
        /// <param name="name">The name of a subscription belonging to the topic passed as a parameter.</param>
        /// <returns>Returns an IEnumerable<SubscriptionDescription/> collection of rules attached to the subscription passed as a parameter.</returns>
        public IEnumerable<RuleDescription> GetRules(string topicPath, string name)
        {
            if (string.IsNullOrEmpty(topicPath))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(NameCannotBeNull);
            }
            if (namespaceManager != null)
            {
                return RetryHelper.RetryFunc(() => namespaceManager.GetRules(topicPath, name), writeToLog);
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Gets the uri of a queue.
        /// </summary>
        /// <param name="queuePath">The path of a queue.</param>
        /// <returns>The absolute uri of the queue.</returns>
        public Uri GetQueueUri(string queuePath)
        {
            return ServiceBusEnvironment.CreateServiceUri(scheme, Namespace, string.Concat(ServicePath, queuePath));
        }

        /// <summary>
        /// Gets the uri of the deadletter queue for a given queue.
        /// </summary>
        /// <param name="queuePath">The path of a queue.</param>
        /// <returns>he absolute uri of the deadletter queue.</returns>
        public Uri GetQueueDeadLetterQueueUri(string queuePath)
        {
            return ServiceBusEnvironment.CreateServiceUri(scheme, Namespace, string.Concat(ServicePath, QueueClient.FormatDeadLetterPath(queuePath)));
        }

        /// <summary>
        /// Gets the uri of a topic.
        /// </summary>
        /// <param name="topicPath">The path of a topic.</param>
        /// <returns>The absolute uri of the topic.</returns>
        public Uri GetTopicUri(string topicPath)
        {
            return ServiceBusEnvironment.CreateServiceUri(scheme, Namespace, string.Concat(ServicePath, topicPath));
        }

        /// <summary>
        /// Gets the uri of a subscription.
        /// </summary>
        /// <param name="topicPath">The path of the topic.</param>
        /// <param name="name">The name of a subscription.</param>
        /// <returns>The absolute uri of the subscription.</returns>
        public Uri GetSubscriptionUri(string topicPath, string name)
        {
            return ServiceBusEnvironment.CreateServiceUri(scheme, Namespace, string.Concat(ServicePath, SubscriptionClient.FormatSubscriptionPath(topicPath, name)));
        }

        /// <summary>
        /// Gets the uri of the deadletter queue for a given subscription.
        /// </summary>
        /// <param name="topicPath">The path of a topic.</param>
        /// <param name="name">The name of a subscription.</param>
        /// <returns>The absolute uri of the deadletter queue.</returns>
        public Uri GetSubscriptionDeadLetterQueueUri(string topicPath, string name)
        {
            return ServiceBusEnvironment.CreateServiceUri(scheme, Namespace, SubscriptionClient.FormatDeadLetterPath(topicPath, name));
        }

        /// <summary>.
        /// Creates a new queue in the service namespace with the given path.
        /// </summary>
        /// <param name="path">Path of the queue relative to the service namespace base address.</param>
        /// <returns>Returns a newly-created QueueDescription object.</returns>
        public QueueDescription CreateQueue(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (namespaceManager != null)
            {
                var queue = RetryHelper.RetryFunc(() => namespaceManager.CreateQueue(path), writeToLog);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, QueueCreated, path));
                OnCreate(new ServiceBusHelperEventArgs(queue, EntityType.Queue));
                return queue;
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Creates a new queue in the service namespace with the given path.
        /// </summary>
        /// <param name="description">A QueueDescription object describing the attributes with which the new queue will be created.</param>
        /// <returns>Returns a newly-created QueueDescription object.</returns>
        public QueueDescription CreateQueue(QueueDescription description)
        {
            if (description == null)
            {
                throw new ArgumentException(DescriptionCannotBeNull);
            }
            if (namespaceManager != null)
            {
                var queue = RetryHelper.RetryFunc(() => namespaceManager.CreateQueue(description), writeToLog);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, QueueCreated, description.Path));
                OnCreate(new ServiceBusHelperEventArgs(queue, EntityType.Queue));
                return queue;
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Deletes all the queues in the list.
        /// <param name="queues">A list of queues to delete.</param>
        /// </summary>
        public void DeleteQueues(IEnumerable<string> queues)
        {
            if (queues == null)
            {
                return;
            }
            foreach (var queue in queues)
            {
                DeleteQueue(queue);
            }
        }

        /// <summary>
        /// Deletes the queue described by the relative path of the service namespace base address.
        /// </summary>
        /// <param name="path">Path of the queue relative to the service namespace base address.</param>
        public void DeleteQueue(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (namespaceManager != null)
            {
                RetryHelper.RetryAction(() => namespaceManager.DeleteQueue(path), writeToLog);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, QueueDeleted, path));
                OnDelete(new ServiceBusHelperEventArgs(path, EntityType.Queue));
            }
            else
            {
                throw new ApplicationException(ServiceBusIsDisconnected);
            }
        }

        /// <summary>
        /// Deletes the queue passed as a argument.
        /// </summary>
        /// <param name="queueDescription">The queue to delete.</param>
        public void DeleteQueue(QueueDescription queueDescription)
        {
            if (queueDescription == null)
            {
                throw new ArgumentException(QueueDescriptionCannotBeNull);
            }
            if (namespaceManager != null)
            {
                RetryHelper.RetryAction(() => namespaceManager.DeleteQueue(queueDescription.Path), writeToLog);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, QueueDeleted, queueDescription.Path));
                OnDelete(new ServiceBusHelperEventArgs(queueDescription, EntityType.Queue));
            }
            else
            {
                throw new ApplicationException(ServiceBusIsDisconnected);
            }
        }

        /// <summary>
        /// Creates a new topic in the service namespace with the given path.
        /// </summary>
        /// <param name="path">Path of the topic relative to the service namespace base address.</param>
        /// <returns>Returns a newly-created TopicDescription object.</returns>
        public TopicDescription CreateTopic(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (namespaceManager != null)
            {
                var topic = RetryHelper.RetryFunc(() => namespaceManager.CreateTopic(path), writeToLog);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, TopicCreated, path));
                OnCreate(new ServiceBusHelperEventArgs(topic, EntityType.Topic));
                return topic;
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Creates a new topic in the service namespace with the given path.
        /// </summary>
        /// <param name="topicDescription">A TopicDescription object describing the attributes with which the new topic will be created.</param>
        /// <returns>Returns a newly-created TopicDescription object.</returns>
        public TopicDescription CreateTopic(TopicDescription topicDescription)
        {
            if (topicDescription == null)
            {
                throw new ArgumentException(TopicDescriptionCannotBeNull);
            }
            if (namespaceManager != null)
            {
                var topic = RetryHelper.RetryFunc(() => namespaceManager.CreateTopic(topicDescription), writeToLog);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, TopicCreated, topicDescription.Path));
                OnCreate(new ServiceBusHelperEventArgs(topic, EntityType.Topic));
                return topic;
            }
            throw new ApplicationException(ServiceBusIsDisconnected);
        }

        /// <summary>
        /// Deletes all the topics in the list.
        /// <param name="topics">A list of topics to delete.</param>
        /// </summary>
        public void DeleteTopics(IEnumerable<string> topics)
        {
            if (topics == null)
            {
                return;
            }
            foreach (var topic in topics)
            {
                DeleteTopic(topic);
            }
        }

        /// <summary>
        /// Deletes the topic described by the relative path of the service namespace base address.
        /// </summary>
        /// <param name="path">Path of the topic relative to the service namespace base address.</param>
        public void DeleteTopic(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (namespaceManager != null)
            {
                RetryHelper.RetryAction(() => namespaceManager.DeleteTopic(path), writeToLog);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, TopicDeleted, path));
                OnDelete(new ServiceBusHelperEventArgs(path, EntityType.Topic));
            }
            else
            {
                throw new ApplicationException(ServiceBusIsDisconnected);
            }
        }

        /// <summary>
        /// Deletes the topic passed as a argument.
        /// </summary>
        /// <param name="topic">The topic to delete.</param>
        public void DeleteTopic(TopicDescription topic)
        {
            if (topic == null)
            {
                throw new ArgumentException(TopicDescriptionCannotBeNull);
            }
            if (namespaceManager != null)
            {
                RetryHelper.RetryAction(() => namespaceManager.DeleteTopic(topic.Path), writeToLog);
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, TopicDeleted, topic.Path));
                OnDelete(new ServiceBusHelperEventArgs(topic, EntityType.Topic));
            }
            else
            {
                throw new ApplicationException(ServiceBusIsDisconnected);
            }
        }

        /// <summary>
        /// Adds a subscription to this topic, with a default pass-through filter added.
        /// </summary>
        /// <param name="topicDescription">A topic belonging to the current service namespace base.</param>
        /// <param name="subscriptionDescription">Metadata of the subscription to be created.</param>
        /// <returns>Returns a newly-created SubscriptionDescription object.</returns>
        public SubscriptionDescription CreateSubscription(TopicDescription topicDescription, SubscriptionDescription subscriptionDescription)
        {
            if (topicDescription == null)
            {
                throw new ArgumentException(TopicDescriptionCannotBeNull);
            }
            if (subscriptionDescription == null)
            {
                throw new ArgumentException(DescriptionCannotBeNull);
            }
            var subscription = RetryHelper.RetryFunc(() => namespaceManager.CreateSubscription(subscriptionDescription), writeToLog);
            WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, SubscriptionCreated, subscription.Name, topicDescription.Path));
            OnCreate(new ServiceBusHelperEventArgs(new SubscriptionWrapper(subscription, topicDescription), EntityType.Subscription));
            return subscription;
        }

        /// <summary>
        /// Adds a subscription to this topic, with a default pass-through filter added.
        /// </summary>
        /// <param name="topicDescription">A topic belonging to the current service namespace base.</param>
        /// <param name="subscriptionDescription">Metadata of the subscription to be created.</param>
        /// <param name="ruleDescription">The metadata describing the properties of the rule to be associated with the subscription.</param>
        /// <returns>Returns a newly-created SubscriptionDescription object.</returns>
        public SubscriptionDescription CreateSubscription(TopicDescription topicDescription,
                                                          SubscriptionDescription subscriptionDescription,
                                                          RuleDescription ruleDescription)
        {
            if (topicDescription == null)
            {
                throw new ArgumentException(TopicDescriptionCannotBeNull);
            }
            if (subscriptionDescription == null)
            {
                throw new ArgumentException(DescriptionCannotBeNull);
            }
            if (ruleDescription == null)
            {
                throw new ArgumentException(RuleDescriptionCannotBeNull);
            }
            var subscription = RetryHelper.RetryFunc(() => namespaceManager.CreateSubscription(subscriptionDescription, ruleDescription), writeToLog);
            WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, SubscriptionCreated, subscription.Name, topicDescription.Path));
            OnCreate(new ServiceBusHelperEventArgs(new SubscriptionWrapper(subscription, topicDescription), EntityType.Subscription));
            return subscription;
        }

        /// <summary>
        /// Removes the subscriptions contained in the list passed as a argument.
        /// </summary>
        /// <param name="subscriptionDescriptions">The list containing subscriptions to remove.</param>
        public void DeleteSubscriptions(IEnumerable<SubscriptionDescription> subscriptionDescriptions)
        {
            if (subscriptionDescriptions == null)
            {
                throw new ArgumentException(SubscriptionDescriptionCannotBeNull);
            }
            foreach (var subscriptionDescription in subscriptionDescriptions)
            {
                DeleteSubscription(subscriptionDescription);
            }
        }

        /// <summary>
        /// Removes the subscription described by name.
        /// </summary>
        /// <param name="topicPath">The name of a topic belonging to the current service namespace base.</param>
        /// <param name="name">Name of the subscription.</param>
        public void DeleteSubscription(string topicPath, string name)
        {
            if (string.IsNullOrEmpty(topicPath))
            {
                throw new ArgumentException(PathCannotBeNull);
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(NameCannotBeNull);
            }
            RetryHelper.RetryAction(() => namespaceManager.DeleteSubscription(topicPath, name), writeToLog);
            WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, SubscriptionDeleted, name, topicPath));
            OnDelete(new ServiceBusHelperEventArgs(name, EntityType.Subscription));
        }

        /// <summary>
        /// Removes the subscription passed as a argument.
        /// </summary>
        /// <param name="subscriptionDescription">The subscription to remove.</param>
        public void DeleteSubscription(SubscriptionDescription subscriptionDescription)
        {
            if (subscriptionDescription == null)
            {
                throw new ArgumentException(SubscriptionDescriptionCannotBeNull);
            }
            RetryHelper.RetryAction(() => namespaceManager.DeleteSubscription(subscriptionDescription.TopicPath, subscriptionDescription.Name), writeToLog);
            WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, SubscriptionDeleted, subscriptionDescription.Name, subscriptionDescription.TopicPath));
            OnDelete(new ServiceBusHelperEventArgs(subscriptionDescription, EntityType.Subscription));
        }

        /// <summary>
        /// Adds a rule to this subscription, with a default pass-through filter added.
        /// </summary>
        /// <param name="subscriptionDescription">The subscription to add the rule to.</param>
        /// <param name="ruleDescription">Metadata of the rule to be created.</param>
        /// <returns>Returns a newly-created RuleDescription object.</returns>
        public RuleDescription AddRule(SubscriptionDescription subscriptionDescription, RuleDescription ruleDescription)
        {
            if (subscriptionDescription == null)
            {
                throw new ArgumentException(SubscriptionDescriptionCannotBeNull);
            }
            if (ruleDescription == null)
            {
                throw new ArgumentException(RuleDescriptionCannotBeNull);
            }
            var subscriptionClient = RetryHelper.RetryFunc(() => MessagingFactory.CreateSubscriptionClient(subscriptionDescription.TopicPath,
                                                                                                           subscriptionDescription.Name), 
                                                                                                           writeToLog);
            RetryHelper.RetryAction(() => subscriptionClient.AddRule(ruleDescription), writeToLog);
            WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, RuleCreated, ruleDescription.Name, subscriptionDescription.Name));
            OnCreate(new ServiceBusHelperEventArgs(new RuleWrapper(ruleDescription, subscriptionDescription), EntityType.Rule));
            return ruleDescription;
        }

        /// <summary>
        /// Removes the rules contained in the list passed as a argument.
        /// </summary>
        /// <param name="wrappers">The list containing the ruleWrappers of the rules to remove.</param>
        public void RemoveRules(IEnumerable<RuleWrapper> wrappers)
        {
            if (wrappers == null)
            {
                throw new ArgumentException(RuleDescriptionCannotBeNull);
            }
            foreach (var wrapper in wrappers)
            {
                RemoveRule(wrapper.SubscriptionDescription, wrapper.RuleDescription);
            }
        }

        /// <summary>
        /// Removes the rule described by name.
        /// </summary>
        /// <param name="subscriptionDescription">The subscription to add the rule to.</param>
        /// <param name="name">Name of the rule.</param>
        public void RemoveRule(SubscriptionDescription subscriptionDescription, string name)
        {
            if (subscriptionDescription == null)
            {
                throw new ArgumentException(SubscriptionDescriptionCannotBeNull);
            }
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException(NameCannotBeNull);
            }
            var subscriptionClient = MessagingFactory.CreateSubscriptionClient(subscriptionDescription.TopicPath,
                                                                               subscriptionDescription.Name);
            RetryHelper.RetryAction(() => subscriptionClient.RemoveRule(name), writeToLog);
            WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, RuleDeleted, name, subscriptionClient.Name));
            OnDelete(new ServiceBusHelperEventArgs(name, EntityType.Rule));
        }

        /// <summary>
        /// Removes the rule passed as a argument.
        /// </summary>
        /// <param name="subscriptionDescription">A subscription belonging to the current service namespace base.</param>
        /// <param name="rule">The rule to remove.</param>
        public void RemoveRule(SubscriptionDescription subscriptionDescription, RuleDescription rule)
        {
            if (subscriptionDescription == null)
            {
                throw new ArgumentException(SubscriptionDescriptionCannotBeNull);
            }
            if (rule == null)
            {
                throw new ArgumentException(RuleCannotBeNull);
            }
            var subscriptionClient = MessagingFactory.CreateSubscriptionClient(subscriptionDescription.TopicPath,
                                                                               subscriptionDescription.Name);
            RetryHelper.RetryAction(() => subscriptionClient.RemoveRule(rule.Name), writeToLog);
            WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, RuleDeleted, rule.Name, subscriptionClient.Name));
            OnDelete(new ServiceBusHelperEventArgs(new RuleWrapper(rule, subscriptionDescription), EntityType.Rule));
        }

        /// <summary>
        /// Create a BrokeredMessage object
        /// </summary>
        /// <param name="text">The message text.</param>
        /// <param name="label">The value of the LabelId property of the message.</param>
        /// <param name="contentType">The type of the content.</param>
        /// <param name="messageId">The value of the MessageId property of the message.</param>
        /// <param name="sessionId">The value of the SessionId property of the message.</param>
        /// <param name="correlationId">The value of the CorrelationId property of the message.</param>
        /// <param name="to">The send to address.</param>
        /// <param name="replyTo">The value of the ReplyTo property of the message.</param>
        /// <param name="replyToSessionId">The value of the ReplyToSessionId property of the message.</param>
        /// <param name="timeToLive">The value of the TimeToLive property of the message.</param>
        /// <param name="scheduledEnqueueTimeUtc">The receiveTimeout in seconds after which the message will be enqueued.</param>
        /// <param name="properties">The user-defined properties of the message.</param>
        /// <returns>The newly created BrokeredMessage object.</returns>
        public BrokeredMessage CreateMessage(string text,
                                             string label,
                                             string contentType,
                                             string messageId,
                                             string sessionId,
                                             string correlationId,
                                             string to,
                                             string replyTo,
                                             string replyToSessionId,
                                             string timeToLive,
                                             string scheduledEnqueueTimeUtc,
                                             IEnumerable<MessagePropertyInfo> properties)
        {
            var warningCollection = new ConcurrentBag<string>();
            var outboundMessage = new BrokeredMessage(text.ToMemoryStream(Encoding.ASCII), true);
            if (!string.IsNullOrEmpty(label))
            {
                outboundMessage.Label = label;
            }
            if (!string.IsNullOrEmpty(contentType))
            {
                outboundMessage.ContentType = contentType;
            }
            if (!string.IsNullOrEmpty(to))
            {
                outboundMessage.To = to;
            }
            outboundMessage.MessageId = !string.IsNullOrEmpty(messageId) ? messageId : Guid.NewGuid().ToString();
            if (!string.IsNullOrEmpty(sessionId))
            {
                outboundMessage.SessionId = sessionId;
            }
            if (!string.IsNullOrEmpty(correlationId))
            {
                outboundMessage.CorrelationId = correlationId;
            }
            if (!string.IsNullOrEmpty(replyTo))
            {
                outboundMessage.ReplyTo = replyTo;
            }
            if (!string.IsNullOrEmpty(replyToSessionId))
            {
                outboundMessage.ReplyToSessionId = replyToSessionId;
            }
            int ttl;
            if (!string.IsNullOrEmpty(timeToLive) && int.TryParse(timeToLive, out ttl))
            {
                outboundMessage.TimeToLive = TimeSpan.FromSeconds(ttl);
            }
            int ss;
            if (!string.IsNullOrEmpty(scheduledEnqueueTimeUtc) && int.TryParse(scheduledEnqueueTimeUtc, out ss))
            {
                outboundMessage.ScheduledEnqueueTimeUtc = DateTime.UtcNow.AddSeconds(ss);
            }
            foreach (var e in properties)
            {
                try
                {
                    e.Key = e.Key.Trim();
                    if (e.Type != StringType && e.Value == null)
                    {
                        warningCollection.Add(string.Format(CultureInfo.CurrentUICulture, PropertyValueCannotBeNull, e.Key));
                    }
                    else
                    {
                        if (outboundMessage.Properties.ContainsKey(e.Key))
                        {
                            outboundMessage.Properties[e.Key] = ConversionHelper.MapStringTypeToCLRType(e.Type, e.Value);
                        }
                        else
                        {
                            outboundMessage.Properties.Add(e.Key, ConversionHelper.MapStringTypeToCLRType(e.Type, e.Value));
                        }
                    }
                }
                catch (Exception ex)
                {
                    warningCollection.Add(string.Format(CultureInfo.CurrentUICulture, PropertyConversionError, e.Key, ex.Message));
                }
            }
            if (warningCollection.Count > 0)
            {
                var builder = new StringBuilder(WarningHeader);
                string[] warnings = warningCollection.ToArray<string>();
                for (int i = 0; i < warningCollection.Count; i++)
                {
                    builder.AppendFormat(WarningFormat, warnings[i]);
                }
                WriteToLogIf(traceEnabled, builder.ToString());
                return null;
            }
            return outboundMessage;
        }

        /// <summary>
        /// Create a BrokeredMessage object
        /// </summary>
        /// <param name="messageTemplate">The message template.</param>
        /// <param name="taskId">The task Id.</param>
        /// <param name="updateMessageId">Indicates whether to use a unique id for each message.</param>
        /// <param name="oneSessionPerTask">Indicates whether to use a different session for each sender task.</param>
        /// <param name="messageText">The message text.</param>
        /// <param name="bodyType">Contains the body type.</param>
        /// <returns>The cloned BrokeredMessage object.</returns>
        public BrokeredMessage CreateMessageForApiReceiver(BrokeredMessage messageTemplate,
                                                           int taskId,
                                                           bool updateMessageId,
                                                           bool oneSessionPerTask,
                                                           string messageText,
                                                           BodyType bodyType)
        {
            if (messageTemplate == null)
            {
                throw new ArgumentNullException(BrokeredMessageCannotBeNull);
            }
            var outboundMessage = bodyType == BodyType.Stream
                                      ? new BrokeredMessage(messageText.ToMemoryStream(Encoding.ASCII), true)
                                      : new BrokeredMessage(messageText);
            if (!string.IsNullOrEmpty(messageTemplate.Label))
            {
                outboundMessage.Label = messageTemplate.Label;
            }
            if (!string.IsNullOrEmpty(messageTemplate.ContentType))
            {
                outboundMessage.ContentType = messageTemplate.ContentType;
            }
            outboundMessage.MessageId = updateMessageId ? Guid.NewGuid().ToString() : messageTemplate.MessageId;
            outboundMessage.SessionId = oneSessionPerTask ? taskId.ToString(CultureInfo.InvariantCulture) : messageTemplate.SessionId;
            if (!string.IsNullOrEmpty(messageTemplate.CorrelationId))
            {
                outboundMessage.CorrelationId = messageTemplate.CorrelationId;
            }
            if (!string.IsNullOrEmpty(messageTemplate.To))
            {
                outboundMessage.To = messageTemplate.To;
            }
            if (!string.IsNullOrEmpty(messageTemplate.ReplyTo))
            {
                outboundMessage.ReplyTo = messageTemplate.ReplyTo;
            }
            if (!string.IsNullOrEmpty(messageTemplate.ReplyToSessionId))
            {
                outboundMessage.ReplyToSessionId = messageTemplate.ReplyToSessionId;
            }
            outboundMessage.TimeToLive = messageTemplate.TimeToLive;
            outboundMessage.ScheduledEnqueueTimeUtc = messageTemplate.ScheduledEnqueueTimeUtc;
            foreach (var property in messageTemplate.Properties)
            {
                outboundMessage.Properties.Add(property.Key, property.Value);
            }
            return outboundMessage;
        }

        /// <summary>
        /// Create a BrokeredMessage for a WCF receiver.
        /// </summary>
        /// <param name="messageTemplate">The message template.</param>
        /// <param name="taskId">The task Id.</param>
        /// <param name="updateMessageId">Indicates whether to use a unique id for each message.</param>
        /// <param name="oneSessionPerTask">Indicates whether to use a different session for each sender task.</param>
        /// <param name="messageText">The message text.</param>
        /// <param name="to">The name of the target topic or queue.</param>
        /// <returns>The cloned BrokeredMessage object.</returns>
        public BrokeredMessage CreateMessageForWcfReceiver(BrokeredMessage messageTemplate,
                                                           int taskId,
                                                           bool updateMessageId,
                                                           bool oneSessionPerTask,
                                                           string messageText,
                                                           string to)
        {

            if (!IsXml(messageText))
            {
                throw new ApplicationException(MessageIsNotXML);
            }

            MessageEncodingBindingElement element;
            if (scheme == DefaultScheme)
            {
                element = new BinaryMessageEncodingBindingElement();
            }
            else
            {
                element = new TextMessageEncodingBindingElement();
            }
            using (var stringReader = new StringReader(messageText))
            {
                using (var xmlReader = XmlReader.Create(stringReader))
                {
                    using (var dictionaryReader = XmlDictionaryReader.CreateDictionaryReader(xmlReader))
                    {
                        var message = Message.CreateMessage(MessageVersion.Default, "*", dictionaryReader);
                        message.Headers.To = new Uri(namespaceUri, to);
                        var encoderFactory = element.CreateMessageEncoderFactory();
                        var encoder = encoderFactory.Encoder;
                        var outputStream = new MemoryStream();
                        encoder.WriteMessage(message, outputStream);
                        outputStream.Seek(0, SeekOrigin.Begin);
                        var outboundMessage = new BrokeredMessage(outputStream, true)
                        {
                            ContentType = encoder.ContentType
                        };
                        if (!string.IsNullOrEmpty(messageTemplate.Label))
                        {
                            outboundMessage.Label = messageTemplate.Label;
                        }
                        if (!string.IsNullOrEmpty(messageTemplate.ContentType))
                        {
                            outboundMessage.ContentType = messageTemplate.ContentType;
                        }
                        outboundMessage.MessageId = updateMessageId ? Guid.NewGuid().ToString() : messageTemplate.MessageId;
                        outboundMessage.SessionId = oneSessionPerTask ? taskId.ToString(CultureInfo.InvariantCulture) : messageTemplate.SessionId;
                        if (!string.IsNullOrEmpty(messageTemplate.CorrelationId))
                        {
                            outboundMessage.CorrelationId = messageTemplate.CorrelationId;
                        }
                        if (!string.IsNullOrEmpty(messageTemplate.To))
                        {
                            outboundMessage.To = messageTemplate.To;
                        }
                        if (!string.IsNullOrEmpty(messageTemplate.ReplyTo))
                        {
                            outboundMessage.ReplyTo = messageTemplate.ReplyTo;
                        }
                        if (!string.IsNullOrEmpty(messageTemplate.ReplyToSessionId))
                        {
                            outboundMessage.ReplyToSessionId = messageTemplate.ReplyToSessionId;
                        }
                        outboundMessage.TimeToLive = messageTemplate.TimeToLive;
                        outboundMessage.ScheduledEnqueueTimeUtc = messageTemplate.ScheduledEnqueueTimeUtc;
                        foreach (var property in messageTemplate.Properties)
                        {
                            outboundMessage.Properties.Add(property.Key, property.Value);
                        }
                        return outboundMessage;
                    }
                }
            }
        }

        /// <summary>
        /// This method can be used to send multiple messages to a queue or a topic.
        /// </summary>
        /// <param name="messageSender">A MessageSender object used to send messages.</param>
        /// <param name="messageTemplate">The message template to use to clone messages from.</param>
        /// <param name="getMessageNumber">This function returns the message number.</param>
        /// <param name="messageCount">The total number of messages to send.</param>
        /// <param name="messageText">The message text.</param>
        /// <param name="taskId">The sender task id.</param>
        /// <param name="updateMessageId">Indicates whether to use a unique id for each message.</param>
        /// <param name="addMessageNumber">Indicates whether to add a message number property.</param>
        /// <param name="oneSessionPerTask">Indicates whether to use a different session for each sender task.</param>
        /// <param name="logging">Indicates whether to enable logging of message content and properties.</param>
        /// <param name="verbose">Indicates whether to enable verbose logging.</param>
        /// <param name="statistics">Indicates whether to enable sender statistics.</param>
        /// <param name="updateStatistics">When statistics = true, this delegate is invoked to update statistics.</param>
        /// <param name="bodyType">Contains the body type.</param>
        /// <param name="cancellationTokenSource">The cancellation token.</param>
        /// <param name="traceMessage">A trace message.</param>
        /// <returns>True if the method completed without exceptions, false otherwise.</returns>
        public bool SendMessages(MessageSender messageSender,
                                 BrokeredMessage messageTemplate,
                                 Func<long> getMessageNumber,
                                 long messageCount,
                                 string messageText,
                                 int taskId,
                                 bool updateMessageId,
                                 bool addMessageNumber,
                                 bool oneSessionPerTask,
                                 bool logging,
                                 bool verbose,
                                 bool statistics,
                                 BodyType bodyType,
                                 UpdateStatisticsDelegate updateStatistics,
                                 CancellationTokenSource cancellationTokenSource,
                                 out string traceMessage)
        {
            if (messageSender == null)
            {
                throw new ArgumentNullException(MessageSenderCannotBeNull);
            }

            if (messageTemplate == null)
            {
                throw new ArgumentNullException(BrokeredMessageCannotBeNull);
            }

            if (cancellationTokenSource == null)
            {
                throw new ArgumentNullException(CancellationTokenSourceCannotBeNull);
            }

            long messagesSent = 0;
            long totalElapsedTime = 0;
            long minimumSendTime = long.MaxValue;
            long maximumSendTime = 0;
            bool ok = true;
            string exceptionMessage = null;

            try
            {
                long messageNumber;
                while ((messageNumber = getMessageNumber()) < messageCount &&
                       !cancellationTokenSource.Token.IsCancellationRequested)
                {
                    long elapsedMilliseconds = 0;
                    RetryHelper.RetryAction(() =>
                                                {
                                                    var useWcf = bodyType == BodyType.Wcf;
                                                    var outboundMessage = useWcf
                                                                              ? CreateMessageForWcfReceiver(
                                                                                  messageTemplate,
                                                                                  taskId,
                                                                                  updateMessageId,
                                                                                  oneSessionPerTask,
                                                                                  messageText,
                                                                                  messageSender.Path)
                                                                              : CreateMessageForApiReceiver(
                                                                                  messageTemplate,
                                                                                  taskId,
                                                                                  updateMessageId,
                                                                                  oneSessionPerTask,
                                                                                  messageText,
                                                                                  bodyType);
                                                    if (addMessageNumber)
                                                    {
                                                        outboundMessage.Properties[MessageNumber] = messageNumber;
                                                    }

                                                    
                                                    SendMessage(messageSender,
                                                                outboundMessage,
                                                                messageText,
                                                                taskId,
                                                                useWcf,
                                                                logging,
                                                                verbose,
                                                                out elapsedMilliseconds);
                                                }, 
                                                writeToLog);
                    messagesSent++;
                    if (elapsedMilliseconds > maximumSendTime)
                    {
                        maximumSendTime = elapsedMilliseconds;
                    }
                    if (elapsedMilliseconds < minimumSendTime)
                    {
                        minimumSendTime = elapsedMilliseconds;
                    }
                    totalElapsedTime += elapsedMilliseconds;
                    if (statistics)
                    {
                        updateStatistics(elapsedMilliseconds, DirectionType.Send);
                    }
                }
            }
            catch (ServerBusyException ex)
            {
                messageSender.Abort();
                exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                ok = false;
            }
            catch (MessageLockLostException ex)
            {
                messageSender.Abort();
                exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                ok = false;
            }
            catch (CommunicationObjectAbortedException ex)
            {
                messageSender.Abort();
                exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                ok = false;
            }
            catch (CommunicationObjectFaultedException ex)
            {
                messageSender.Abort();
                exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                ok = false;
            }
            catch (CommunicationException ex)
            {
                messageSender.Abort();
                exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                ok = false;
            }
            catch (TimeoutException ex)
            {
                messageSender.Abort();
                exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                ok = false;
            }
            catch (Exception ex)
            {
                messageSender.Abort();
                exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                ok = false;
            }
            var averageSendTime = messagesSent > 0 ? totalElapsedTime / messagesSent : maximumSendTime;
            var messagesPerSecond = totalElapsedTime > 0 ? (double)(messagesSent * 1000) / (double)totalElapsedTime : 0;
            var builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture,
                                             SenderStatisticsHeader,
                                             taskId));
            if (!string.IsNullOrEmpty(exceptionMessage))
            {
                builder.AppendLine(exceptionMessage);
            }
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture,
                                             SenderStatitiscsLine1,
                                             messagesSent,
                                             messagesPerSecond,
                                             totalElapsedTime));
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture,
                                             SenderStatitiscsLine2,
                                             averageSendTime,
                                             minimumSendTime == long.MaxValue ? 0 : minimumSendTime,
                                             maximumSendTime));
            traceMessage = builder.ToString();
            return ok;
        }

        /// <summary>
        /// This method can be used to send a message to a queue or a topic.
        /// </summary>
        /// <param name="messageSender">A MessageSender object used to send messages.</param>
        /// <param name="outboundMessage">The message to send.</param>
        /// <param name="messageText">The message text.</param>
        /// <param name="taskId">The sender task id.</param>
        /// <param name="useWcf">Indicates whether to send messages to a WCF receiver.</param>
        /// <param name="logging">Indicates whether logging of message content and properties is enabled.</param>
        /// <param name="verbose">Indicates whether verbose logging is enabled.</param>
        /// <param name="elapsedMilliseconds">The time spent to send the message.</param>
        public void SendMessage(MessageSender messageSender,
                                BrokeredMessage outboundMessage,
                                string messageText,
                                int taskId,
                                bool useWcf,
                                bool logging,
                                bool verbose,
                                out long elapsedMilliseconds)
        {
            if (messageSender == null)
            {
                throw new ArgumentNullException(MessageSenderCannotBeNull);
            }

            if (outboundMessage == null)
            {
                throw new ArgumentNullException(BrokeredMessageCannotBeNull);
            }

            var stopwatch = new Stopwatch();

            try
            {
                var builder = new StringBuilder();
                try
                {
                    stopwatch.Start();
                    messageSender.Send(outboundMessage);
                }
                finally
                {
                    stopwatch.Stop();
                }
                elapsedMilliseconds = stopwatch.ElapsedMilliseconds;
                if (logging)
                {
                    builder.AppendLine(string.Format(CultureInfo.CurrentCulture, MessageSuccessfullySent,
                                                     taskId,
                                                     string.IsNullOrEmpty(outboundMessage.MessageId) ? NullValue : outboundMessage.MessageId,
                                                     string.IsNullOrEmpty(outboundMessage.SessionId) ? NullValue : outboundMessage.SessionId,
                                                     string.IsNullOrEmpty(outboundMessage.Label) ? NullValue : outboundMessage.Label,
                                                     outboundMessage.Size));
                    if (verbose)
                    {
                        builder.AppendLine(SentMessagePayloadHeader);
                        if (useWcf)
                        {
                            var stringBuilder = new StringBuilder();
                            using (var reader = XmlReader.Create(new StringReader(messageText)))
                            {
                                // The XmlWriter is used just to indent the XML message
                                var settings = new XmlWriterSettings { Indent = true };
                                using (var writer = XmlWriter.Create(stringBuilder, settings))
                                {
                                    writer.WriteNode(reader, true);
                                }
                            }
                            messageText = stringBuilder.ToString();
                        }
                        builder.AppendLine(string.Format(MessageTextFormat, messageText));
                        builder.AppendLine(SentMessagePropertiesHeader);
                        foreach (var p in outboundMessage.Properties)
                        {
                            builder.AppendLine(string.Format(MessagePropertyFormat,
                                                                p.Key,
                                                                p.Value));
                        }
                    }
                    var traceMessage = builder.ToString();
                    WriteToLog(traceMessage.Substring(0, traceMessage.Length - 1));
                }
            }
            finally
            {
                outboundMessage.Dispose();
            }
        }

        /// <summary>
        /// This method is used to receive message from a queue or a subscription.
        /// </summary>
        /// <param name="messageReceiver">The message receiver used to receive messages.</param>
        /// <param name="taskId">The receiver task id.</param>
        /// <param name="timeout">The receive receiveTimeout.</param>
        /// <param name="filter">The filter expression is used to determine messages to move the dead-letter queue or to defer.</param>
        /// <param name="moveToDeadLetterQueue">Indicates whether to move messages to the dead-letter queue.</param>
        /// <param name="completeReceive">Indicates whether to complete a receive operation when ReceiveMode is equal to PeekLock.</param>
        /// <param name="defer">Indicates whether to defer messages.</param>
        /// <param name="logging">Indicates whether logging of message content and properties is enabled.</param>
        /// <param name="verbose">Indicates whether verbose logging is enabled.</param>
        /// <param name="statistics">Indicates whether to enable receiver statistics.</param>
        /// <param name="updateStatistics">When statistics = true, this delegate is invoked to update statistics.</param>
        /// <param name="cancellationTokenSource">The cancellation token.</param>
        /// <param name="traceMessage">A trace message.</param>
        /// <returns>True if the method completed without exceptions, false otherwise.</returns>
        public bool ReceiveMessages(MessageReceiver messageReceiver,
                                    int taskId,
                                    int timeout,
                                    Filter filter,
                                    bool moveToDeadLetterQueue,
                                    bool completeReceive,
                                    bool defer,
                                    bool logging,
                                    bool verbose,
                                    bool statistics,
                                    UpdateStatisticsDelegate updateStatistics,
                                    CancellationTokenSource cancellationTokenSource,
                                    out string traceMessage)
        {
            if (messageReceiver == null)
            {
                throw new ArgumentNullException(MessageReceiverCannotBeNull);
            }

            if (cancellationTokenSource == null)
            {
                throw new ArgumentNullException(CancellationTokenSourceCannotBeNull);
            }

            BrokeredMessage inboundMessage = null;
            StringBuilder builder;
            var isCompleted = false;
            var ok = true;
            var receivedFromDeadLetterQueue = messageReceiver.Path.EndsWith(DeadLetterQueue);
            var readingDeferredMessages = false;
            long messagesReceived = 0;
            long totalElapsedTime = 0;
            long minimumReceiveTime = long.MaxValue;
            long maximumReceiveTime = 0;
            string exceptionMessage = null;
            MessageEncoder encoder = null;
            var messageDeferProvider = Activator.CreateInstance(messageDeferProviderType) as IMessageDeferProvider;

            try
            {
                MessageEncodingBindingElement element;
                if (scheme == DefaultScheme)
                {
                    element = new BinaryMessageEncodingBindingElement();
                }
                else
                {
                    element = new TextMessageEncodingBindingElement();
                }
                var encoderFactory = element.CreateMessageEncoderFactory();
                encoder = encoderFactory.Encoder;

                while (!isCompleted &&
                       !cancellationTokenSource.Token.IsCancellationRequested)
                {
                    try
                    {
                        var stopwatch = new Stopwatch();
                        var movedToDeadLetterQueue = false;
                        var deferredMessage = false;
                        var readDeferredMessage = false;

                        if (!readingDeferredMessages)
                        {
                            stopwatch.Start();
                            inboundMessage = messageReceiver.Receive(TimeSpan.FromSeconds(timeout));
                            stopwatch.Stop();
                            isCompleted = inboundMessage == null &&
                                          messageDeferProvider.Count == 0;
                        }
                        else
                        {
                            isCompleted = messageDeferProvider.Count == 0;
                            if (!isCompleted)
                            {
                                long sequenceNumber;
                                if (messageDeferProvider.Dequeue(out sequenceNumber))
                                {
                                    stopwatch.Start();
                                    inboundMessage = messageReceiver.Receive(sequenceNumber);
                                    stopwatch.Stop();
                                    readDeferredMessage = true;
                                }
                            }
                        }
                        if (!readingDeferredMessages)
                        {
                            readingDeferredMessages = inboundMessage == null && messageDeferProvider.Count > 0;
                        }

                        if (isCompleted ||
                            inboundMessage == null)
                        {
                            continue;
                        }
                        if (stopwatch.ElapsedMilliseconds > maximumReceiveTime)
                        {
                            maximumReceiveTime = stopwatch.ElapsedMilliseconds;
                        }
                        if (stopwatch.ElapsedMilliseconds < minimumReceiveTime)
                        {
                            minimumReceiveTime = stopwatch.ElapsedMilliseconds;
                        }
                        totalElapsedTime += stopwatch.ElapsedMilliseconds;
                        if (statistics)
                        {
                            updateStatistics(stopwatch.ElapsedMilliseconds, DirectionType.Receive);
                        }
                        builder = new StringBuilder();



                        if (defer &&
                            !readingDeferredMessages &&
                            filter != null &&
                            filter.Match(inboundMessage))
                        {
                            inboundMessage.Defer();
                            messageDeferProvider.Enqueue(inboundMessage.SequenceNumber);
                            deferredMessage = true;
                        }

                        if (!deferredMessage &&
                            moveToDeadLetterQueue &&
                            filter != null &&
                            filter.Match(inboundMessage))
                        {
                            inboundMessage.DeadLetter();
                            movedToDeadLetterQueue = true;
                            messagesReceived++;
                        }


                        if (!deferredMessage &&
                            !movedToDeadLetterQueue)
                        {
                            if (messageReceiver.Mode == ReceiveMode.PeekLock)
                            {
                                if (completeReceive)
                                {
                                    inboundMessage.Complete();
                                    messagesReceived++;
                                }
                                else
                                {
                                    inboundMessage.Abandon();
                                }
                            }
                            else
                            {
                                messagesReceived++;
                            }
                        }

                        if (logging)
                        {
                            if (messageReceiver.Mode == ReceiveMode.PeekLock &&
                                !completeReceive &&
                                !deferredMessage &&
                                !movedToDeadLetterQueue)
                            {
                                builder.AppendLine(string.Format(MessagePeekedButNotConsumed,
                                                                 taskId,
                                                                 string.IsNullOrEmpty(inboundMessage.MessageId)
                                                                     ? NullValue
                                                                     : inboundMessage.MessageId,
                                                                 string.IsNullOrEmpty(inboundMessage.SessionId)
                                                                     ? NullValue
                                                                     : inboundMessage.SessionId,
                                                                 string.IsNullOrEmpty(inboundMessage.Label)
                                                                     ? NullValue
                                                                     : inboundMessage.Label,
                                                                 inboundMessage.Size));
                            }
                            else
                            {
                                builder.AppendLine(string.Format(MessageSuccessfullyReceived,
                                                                 taskId,
                                                                 string.IsNullOrEmpty(inboundMessage.MessageId)
                                                                     ? NullValue
                                                                     : inboundMessage.MessageId,
                                                                 string.IsNullOrEmpty(inboundMessage.SessionId)
                                                                     ? NullValue
                                                                     : inboundMessage.SessionId,
                                                                 string.IsNullOrEmpty(inboundMessage.Label)
                                                                     ? NullValue
                                                                     : inboundMessage.Label,
                                                                 inboundMessage.Size,
                                                                 inboundMessage.DeliveryCount));
                            }
                            if (deferredMessage)
                            {
                                builder.AppendLine(MessageDeferred);
                            }
                            if (readDeferredMessage)
                            {
                                builder.AppendLine(ReadMessageDeferred);
                            }
                            if (movedToDeadLetterQueue)
                            {
                                builder.AppendLine(MessageMovedToDeadLetterQueue);
                            }
                            if (receivedFromDeadLetterQueue)
                            {
                                builder.AppendLine(MessageReadFromDeadLetterQueue);
                            }
                            if (verbose)
                            {
                                GetMessageAndProperties(builder, inboundMessage, encoder);
                            }
                        }

                        if (logging)
                        {
                            traceMessage = builder.ToString();
                            WriteToLog(traceMessage.Substring(0, traceMessage.Length - 1));
                        }
                    }
                    catch (Exception ex)
                    {
                        if (inboundMessage != null &&
                            messageReceiver.Mode == ReceiveMode.PeekLock)
                        {
                            try
                            {
                                inboundMessage.Abandon();
                            }
                            catch (Exception)
                            {
                            }
                        }
                        exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                        isCompleted = true;
                        ok = false;
                    }
                    finally
                    {
                        if (inboundMessage != null)
                        {
                            inboundMessage.Dispose();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                exceptionMessage = string.Format(ExceptionOccurred, ex.Message);
                ok = false;
            }
            if (messagesReceived == 0)
            {
                WriteToLog(string.Format(NoMessageWasReceived, taskId));
            }
            var averageReceiveTime = messagesReceived > 0 ? totalElapsedTime / messagesReceived : maximumReceiveTime;
            var messagesPerSecond = totalElapsedTime > 0 ? (double)(messagesReceived * 1000) / (double)totalElapsedTime : 0;
            builder = new StringBuilder();
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture,
                                             ReceiverStatisticsHeader,
                                             taskId));
            if (!string.IsNullOrEmpty(exceptionMessage))
            {
                builder.AppendLine(exceptionMessage);
            }
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture,
                                             ReceiverStatitiscsLine1,
                                             messagesReceived,
                                             messagesPerSecond,
                                             totalElapsedTime));
            builder.AppendLine(string.Format(CultureInfo.CurrentCulture,
                                             ReceiverStatitiscsLine2,
                                             averageReceiveTime,
                                             minimumReceiveTime == long.MaxValue ? 0 : minimumReceiveTime,
                                             maximumReceiveTime));
            traceMessage = builder.ToString();
            return ok;
        }

        /// <summary>
        /// Exports the entities contained in the list passed a parameter.
        /// </summary>
        /// <param name="entityDescriptionList">The list of the entities to export.</param>
        /// <returns>The xml string representing the entity list.</returns>
        public string ExportEntities(List<EntityDescription> entityDescriptionList)
        {
            return ImportExportHelper.ReadAndSerialize(this, entityDescriptionList);
        }

        /// <summary>
        /// Imports entities from a xml string.
        /// </summary>
        /// <param name="xml">The xml containing entities.</param>
        /// <returns>The description of the newly created queue.</returns>
        public void ImportEntities(string xml)
        {
            ImportExportHelper.DeserializeAndCreate(this, xml);
        }

        /// <summary>
        /// This method is used to receive message from a queue or a subscription.
        /// </summary>
        /// <param name="entityDescription">The description of the entity from which to read messages.</param>
        /// <param name="messageCount">The number of messages to read.</param>
        /// <param name="complete">This parameter indicates whether to complete the receive operation.</param>
        /// <param name="deadletterQueue">This parameter indicates whether to read messages from the deadletter queue.</param>
        /// <param name="receiveTimeout">Receive receiveTimeout.</param>
        /// <param name="cancellationTokenSource">Cancellation token source.</param>
        public void ReceiveMessages(EntityDescription entityDescription, int? messageCount, bool complete, bool deadletterQueue, TimeSpan receiveTimeout, TimeSpan sessionTimeout, CancellationTokenSource cancellationTokenSource)
        {
            var receiverList = new List<MessageReceiver>();
            if (brokeredMessageList != null &&
                brokeredMessageList.Count > 0)
            {
                brokeredMessageList.ForEach(b => b.Dispose());
            }
            brokeredMessageList = new List<BrokeredMessage>();
            MessageEncodingBindingElement element;
            if (scheme == DefaultScheme)
            {
                element = new BinaryMessageEncodingBindingElement();
            }
            else
            {
                element = new TextMessageEncodingBindingElement();
            }
            var encoderFactory = element.CreateMessageEncoderFactory();
            var encoder = encoderFactory.Encoder;

            MessageReceiver messageReceiver = null;
            if (entityDescription is QueueDescription)
            {
                var queueDescription = entityDescription as QueueDescription;
                if (deadletterQueue)
                {
                    messageReceiver = messagingFactory.CreateMessageReceiver(QueueClient.FormatDeadLetterPath(queueDescription.Path),
                                                                                ReceiveMode.PeekLock);
                }
                else
                {
                    if (queueDescription.RequiresSession)
                    {
                        var queueClient = messagingFactory.CreateQueueClient(queueDescription.Path,
                                                                                ReceiveMode.PeekLock);
                        messageReceiver = queueClient.AcceptMessageSession(sessionTimeout);
                    }
                    else
                    {
                        messageReceiver = messagingFactory.CreateMessageReceiver(queueDescription.Path,
                                                                                    ReceiveMode.PeekLock);
                    }
                }
            }
            else
            {
                if (entityDescription is SubscriptionDescription)
                {
                    var subscriptionDescription = entityDescription as SubscriptionDescription;
                    if (deadletterQueue)
                    {
                        messageReceiver = messagingFactory.CreateMessageReceiver(SubscriptionClient.FormatDeadLetterPath(subscriptionDescription.TopicPath,
                                                                                                                            subscriptionDescription.Name),
                                                                                    ReceiveMode.PeekLock);
                    }
                    else
                    {
                        if (subscriptionDescription.RequiresSession)
                        {
                            var subscriptionClient = messagingFactory.CreateSubscriptionClient(subscriptionDescription.TopicPath,
                                                                                                subscriptionDescription.Name,
                                                                                                ReceiveMode.PeekLock);
                            messageReceiver = subscriptionClient.AcceptMessageSession(sessionTimeout);
                        }
                        else
                        {
                            messageReceiver = messagingFactory.CreateMessageReceiver(SubscriptionClient.FormatSubscriptionPath(subscriptionDescription.TopicPath,
                                                                                                                                subscriptionDescription.Name),
                                                                                        ReceiveMode.PeekLock);
                        }
                    }
                }
            }
            if (messageReceiver != null)
            {
                messageReceiver.PrefetchCount = 0;
                receiverList.Add(messageReceiver);
                ReceiveNextMessage(messageCount, 0, messageReceiver, ReceiveCallback, encoder, complete, receiveTimeout, cancellationTokenSource.Token);
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Writes the specified message to the trace listener.
        /// </summary>
        /// <param name="ex">The exception to log.</param>
        private void HandleException(Exception ex)
        {
            if (ex != null && !string.IsNullOrEmpty(ex.Message))
            {
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, ExceptionFormat, ex.Message));
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, InnerExceptionFormat, ex.InnerException.Message));
                }
                WriteToLogIf(traceEnabled, string.Format(CultureInfo.CurrentCulture, StackTraceFormat, ex.StackTrace));
            }
        }

        /// <summary>
        /// Checks whether the input text is a valid xml string.
        /// </summary>
        /// <param name="text">The text to check.</param>
        /// <returns>Yes if the text is a valid xml string, false otherwise.</returns>
        private bool IsXml(string text)
        {
            try
            {
                if (string.IsNullOrEmpty(text))
                {
                    return false;
                }
                using (var stringReader = new StringReader(text))
                {
                    using (var xmlReader = XmlReader.Create(stringReader))
                    {
                        while (xmlReader.Read())
                        {
                        }
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Gets a new messaging factory object.
        /// </summary>
        /// <returns>A messaging factory object.</returns>
        private MessagingFactory GetMessagingFactory()
        {
            // The MessagingFactorySettings specifies the service bus messaging factory settings.
            var messagingFactorySettings = new MessagingFactorySettings
            {
                TokenProvider = tokenProvider,
                OperationTimeout = TimeSpan.FromMinutes(5)
            };
            // In the first release of the service bus, the only available transport protocol is sb 
            if (scheme == DefaultScheme)
            {
                messagingFactorySettings.NetMessagingTransportSettings = new NetMessagingTransportSettings();
            }

            // As the name suggests, the MessagingFactory class is a Factory class that allows to create
            // instances of the QueueClient, TopicClient and SubscriptionClient classes.
            var factory = MessagingFactory.Create(namespaceUri, messagingFactorySettings);
            WriteToLogIf(traceEnabled, MessageFactorySuccessfullyCreated);
            return factory;
        }

        /// <summary>
        /// Receives a message from a queue or a subscription.
        /// </summary>
        /// <param name="messageCount">The message count.</param>
        /// <param name="messageTotal">The total number of messages read.</param>
        /// <param name="messageReceiver">The message receiver used to receive messages.</param>
        /// <param name="complete">Call Complete method to delete the message.</param>
        /// <param name="callback">The callback function invoked when a message is received.</param>
        /// <param name="encoder">MessageEncoder used to decode a WCF message.</param>
        /// <param name="timeout">The receive receiveTimeout.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        private void ReceiveNextMessage(int? messageCount, int messageTotal, MessageReceiver messageReceiver, Func<IAsyncResult, BrokeredMessage> callback, MessageEncoder encoder, bool complete, TimeSpan timeout, CancellationToken cancellationToken)
        {
            Task.Factory.FromAsync(messageReceiver.BeginReceive,
                                   callback,
                                   timeout,
                                   messageReceiver,
                                   TaskCreationOptions.None).
                                   ContinueWith(taskResult =>
                                   {
                                       // Start receiving the next message as soon as we 
                                       // received the previous one. 
                                       // This will not cause a stack overflow because the 
                                       // call will be made from a new Task. 
                                       if (taskResult.Exception != null)
                                       {
                                           Console.WriteLine(taskResult.Exception.ToString());
                                       }
                                       var inboundMessage = taskResult.Result;
                                       if (inboundMessage == null ||
                                           messageCount.HasValue && messageCount == 0)
                                       {
                                           if (brokeredMessageList != null &&
                                               brokeredMessageList.Count > 0)
                                           {
                                               brokeredMessageList.ForEach(b =>
                                                                               {
                                                                                   try
                                                                                   {
                                                                                       if (complete)
                                                                                       {
                                                                                           b.Complete();
                                                                                       }
                                                                                       else
                                                                                       {
                                                                                           b.Abandon();
                                                                                       }
                                                                                   }
                                                                                   catch (MessageLockLostException)
                                                                                   {
                                                                                   }
                                                                                   catch (Exception)
                                                                                   {
                                                                                   }
                                                                                   
                                                                               });
                                               brokeredMessageList = null;
                                           }
                                           var builder = new StringBuilder();
                                           builder.AppendLine(string.Format(ReceiverStatitiscsLineNoTask,
                                                                            complete ? Read : Peeked,
                                                                            messageTotal));
                                           var traceMessage = builder.ToString();
                                           WriteToLog(traceMessage.Substring(0, traceMessage.Length - 1));
                                       }
                                       else
                                       {
                                           messageCount--;
                                           messageTotal++;
                                           var builder = new StringBuilder();
                                           builder.AppendLine(string.Format(MessageSuccessfullyReceivedNoTask,
                                                                            complete ? Read :Peeked,
                                                                            string.IsNullOrEmpty(
                                                                                inboundMessage.MessageId)
                                                                                ? NullValue
                                                                                : inboundMessage.MessageId,
                                                                            string.IsNullOrEmpty(
                                                                                inboundMessage.SessionId)
                                                                                ? NullValue
                                                                                : inboundMessage.SessionId,
                                                                            string.IsNullOrEmpty(inboundMessage.Label)
                                                                                ? NullValue
                                                                                : inboundMessage.Label,
                                                                            inboundMessage.Size,
                                                                            inboundMessage.DeliveryCount));

                                           GetMessageAndProperties(builder, inboundMessage, encoder);
                                           var traceMessage = builder.ToString();
                                           WriteToLog(traceMessage.Substring(0, traceMessage.Length - 1));
                                           brokeredMessageList.Add(inboundMessage);
                                           ReceiveNextMessage(messageCount, messageTotal, messageReceiver, callback, encoder, complete, timeout, cancellationToken);
                                       }
                                   }, cancellationToken);
        }

        /// <summary>
        /// Receive callback
        /// </summary>
        /// <param name="asyncResult">AsyncResult object used to complete the asynchronous call.</param>
        /// <returns></returns>
        private BrokeredMessage ReceiveCallback(IAsyncResult asyncResult)
        {
            try
            {
                var messageReceiver = asyncResult.AsyncState as MessageReceiver;
                if (messageReceiver != null)
                {
                    var bm = messageReceiver.EndReceive(asyncResult);
                    return bm;
                }
                return null;
            }
            catch (TimeoutException)
            {
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            return null;
        }

        /// <summary>
        /// Gets the message body and properties.
        /// </summary>
        /// <param name="builder">The string builder object used to accumulate the trace message.</param>
        /// <param name="inboundMessage">The inbound message.</param>
        /// <param name="encoder">The message encoder used to decode a WCF message.</param>
        private void GetMessageAndProperties(StringBuilder builder, BrokeredMessage inboundMessage, MessageEncoder encoder)
        {
            string messageText = null;
            Stream stream = null;
            try
            {
                stream = inboundMessage.GetBody<Stream>();
                if (stream != null)
                {
                    var stringBuilder = new StringBuilder();
                    var message = encoder.ReadMessage(stream, MaxBufferSize);
                    using (var reader = message.GetReaderAtBodyContents())
                    {
                        // The XmlWriter is used just to indent the XML message
                        var settings = new XmlWriterSettings { Indent = true };
                        using (var writer = XmlWriter.Create(stringBuilder, settings))
                        {
                            writer.WriteNode(reader, true);
                        }
                    }
                    messageText = stringBuilder.ToString();
                }
            }
            catch (Exception)
            {
                try
                {
                    if (stream != null)
                    {
                        try
                        {
                            stream.Seek(0, SeekOrigin.Begin);
                            var serializer = new MyDataContractBinarySerializer(typeof(string));
                            messageText = serializer.ReadObject(stream) as string;
                        }
                        catch (Exception)
                        {
                            try
                            {
                                stream.Seek(0, SeekOrigin.Begin);
                                using (var reader = new StreamReader(stream))
                                {
                                    messageText = reader.ReadToEnd();
                                }
                            }
                            catch (Exception)
                            {
                                messageText = UnableToReadMessageBody;
                            }
                        }
                    }
                    else
                    {
                        messageText = UnableToReadMessageBody;
                    }
                }
                catch (Exception)
                {
                    messageText = UnableToReadMessageBody;
                }
            }
            builder.AppendLine(ReceivedMessagePayloadHeader);
            builder.AppendLine(string.Format(MessageTextFormat, messageText));
            builder.AppendLine(ReceivedMessagePropertiesHeader);
            foreach (var p in inboundMessage.Properties)
            {
                builder.AppendLine(string.Format(MessagePropertyFormat,
                                                 p.Key,
                                                 p.Value));
            }
        }

        private void WriteToLog(string message)
        {
            if (writeToLog != null &&
                !string.IsNullOrEmpty(message))
            {
                writeToLog(message);
            }
        }

        private void WriteToLogIf(bool condition, string message)
        {
            if (condition &&
                writeToLog != null &&
                !string.IsNullOrEmpty(message))
            {
                writeToLog(message);
            }
        }
        #endregion
    }

    public class MyDataContractBinarySerializer : XmlObjectSerializer
    {
        // Fields
        private readonly DataContractSerializer dataContractSerializer;

        // Methods
        public MyDataContractBinarySerializer(Type type)
        {
            dataContractSerializer = new DataContractSerializer(type);
        }

        public override bool IsStartObject(XmlDictionaryReader reader)
        {
            return dataContractSerializer.IsStartObject(reader);
        }

        public override object ReadObject(Stream stream)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            return ReadObject(XmlDictionaryReader.CreateBinaryReader(stream, XmlDictionaryReaderQuotas.Max));
        }

        public override object ReadObject(XmlDictionaryReader reader, bool verifyObjectName)
        {
            return dataContractSerializer.ReadObject(reader, verifyObjectName);
        }

        public override void WriteEndObject(XmlDictionaryWriter writer)
        {
            dataContractSerializer.WriteEndObject(writer);
        }

        public override void WriteObject(Stream stream, object graph)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            var writer = XmlDictionaryWriter.CreateBinaryWriter(stream, null, null, false);
            WriteObject(writer, graph);
            writer.Flush();
        }

        public override void WriteObject(XmlDictionaryWriter writer, object graph)
        {
            if (writer == null)
            {
                throw new ArgumentNullException("writer");
            }
            dataContractSerializer.WriteObject(writer, graph);
        }

        public override void WriteObjectContent(XmlDictionaryWriter writer, object graph)
        {
            dataContractSerializer.WriteObjectContent(writer, graph);
        }

        public override void WriteStartObject(XmlDictionaryWriter writer, object graph)
        {
            dataContractSerializer.WriteStartObject(writer, graph);
        }
    }
}