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
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Configuration;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceModel.Syndication;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using Microsoft.ServiceBus.Messaging;
#endregion

namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    public partial class MainForm : Form
    {
        #region Private Constants
        //***************************
        // Formats
        //***************************
        private const string DateFormat = "<{0,2:00}:{1,2:00}:{2,2:00}> {3}";
        private const string ExceptionFormat = "Exception: {0}";
        private const string InnerExceptionFormat = "InnerException: {0}";
        private const string LogFileNameFormat = "ServiceBusExplorer {0}.txt";
        private const string EntityFileNameFormat = "{0} {1} {2}.xml";
        private const string EntitiesFileNameFormat = "{0} {1}.xml";
        private const string UrlSegmentFormat = "{0}/{1}";
        private const string FaultNode = "Fault";

        //***************************
        // Messages
        //***************************
        private const string ServiceBusNamespacesNotConfigured = "Service bus accounts have not been properly configured in the configuration file.";
        private const string ServiceBusNamespaceIsNullOrEmpty = "The connection string for service bus entry {0} is null or empty.";
        private const string ServiceBusNamespaceIsWrong = "The connection string for service bus namespace {0} is in the wrong format.";
        private const string ServiceBusNamespaceNamespaceAndUriAreNullOrEmpty = "Both the uri and namespace for the service bus entry {0} is null or empty.";
        private const string ServiceBusNamespaceIssuerNameIsNullOrEmpty = "The issuer name for the service bus entry {0} is null or empty.";
        private const string ServiceBusNamespaceIssuerSecretIsNullOrEmpty = "The issuer secret for the service bus entry {0} is null or empty.";
        private const string ServiceBusNamespaceEndpointIsNullOrEmpty = "The endpoint for the service bus entry {0} is null or empty.";
        private const string ServiceBusNamespaceEndpointUriIsInvalid = "The endpoint uri for the service bus entry {0} is invalid.";
        private const string QueueRetrievedFormat = "The queue {0} has been succesfully retrieved.";
        private const string TopicRetrievedFormat = "The topic {0} has been succesfully retrieved.";
        private const string SubscriptionRetrievedFormat = "The subscription {0} for the {1} topic has been succesfully retrieved.";
        private const string RuleRetrievedFormat = "The rule {0} for the {1} subscription of the {2} topic has been succesfully retrieved.";
        private const string SyndicateItemFormat = "The atom feed item {0} has been successfully retrieved.";
        private const string LinkUriFormat = "The link uri {0} has been successfully retrieved.";
        private const string TestQueueFormat = "Test Queue: {0}";
        private const string TestTopicFormat = "Test Topic: {0}";
        private const string TestSubscriptionFormat = "Test Subscription: {0}";
        private const string CreateQueue = "Create Queue";
        private const string CreateTopic = "Create Topic";
        private const string CreateSubscription = "Create Subscription";
        private const string AddRule = "Add Rule";
        private const string ViewQueueFormat = "View Queue: {0}";
        private const string ViewTopicFormat = "View Topic: {0}";
        private const string ViewSubscriptionFormat = "View Subscription: {0}";
        private const string ViewRuleFormat = "View Rule: {0}";
        private const string TestRelayServiceFormat = "Test Relay Service: {0}";
        private const string DeleteAllEntities = "All the entities will be permanently deleted.";
        private const string DeleteAllQueues = "All the queues will be permanently deleted.";
        private const string DeleteAllQueuesInPath = "All the queues in [{0}] will be permanently deleted.";
        private const string DeleteAllTopics = "All the topics will be permanently deleted.";
        private const string DeleteAllTopicsInPath = "All the topics in [{0}] will be permanently deleted.";
        private const string DeleteAllSubscriptions = "All the subscriptions will be permanently deleted.";
        private const string DeleteAllRules = "All the rules will be permanently deleted.";
        private const string EntitiesExported = "Selected entities have been exported to {0}.";
        private const string EntitiesImported = "Entities have been imported from {0}.";

        //***************************
        // Constants
        //***************************
        private const string ServiceBusNamespaces = "serviceBusNamespaces";
        private const string UrlEntity = "Url";
        private const string AllEntities = "Entities";
        private const string QueueEntities = "Queues";
        private const string TopicEntities = "Topics";
        private const string SubscriptionEntities = "Subscriptions";
        private const string RuleEntities = "Rules";
        private const string RelayServiceEntities = "Relay Services";
        private const string QueueEntity = "Queue";
        private const string TopicEntity = "Topic";
        private const string SubscriptionEntity = "Subscription";
        private const string RuleEntity = "Rule";
        //private const string RelayServiceEntity = "Relay Service";
        private const string Entity = "Entity";
        private const string SaveAsTitle = "Save Log As";
        private const string SaveEntityAsTitle = "Save File As";
        private const string OpenEntityAsTitle = "Open File";
        private const string SaveAsExtension = "txt";
        private const string XmlExtension = "xml";
        private const string SaveAsFilter = "Text Documents|*.txt";
        private const string XmlFilter = "XML Files|*.xml";
        private const string DefaultMessageText = "Hi mate, how are you?";
        private const string DefaultLabel = "Service Bus Explorer";
        private const string ImportToolStripMenuItemName = "importEntityMenuItem2";
        private const string ImportToolStripMenuItemText = "Import Entities";
        private const string ImportToolStripMenuItemToolTipText = "Import entity definition from file.";
        private const string EventClick = "EventClick";
        private const string EventsProperty = "Events";

        //***************************
        // Parameters
        //***************************
        private const string ConnectionStringUri = "uri";
        private const string ConnectionStringNameSpace = "namespace";
        private const string ConnectionStringServicePath = "servicepath";
        private const string ConnectionStringIssuerName = "issuername";
        private const string ConnectionStringIssuerSecret = "issuersecret";
        private const string ConnectionStringTransportType = "transporttype";
        private const string ConnectionStringOwner = "owner";
        private const string ConnectionStringEndpoint = "endpoint";
        private const string ConnectionStringSharedSecretIssuer = "sharedsecretissuer";
        private const string ConnectionStringSharedSecretValue = "sharedsecretvalue";
        private const string DebugFlagParameter = "debug";
        private const string SaveMessageToFileParameter = "saveMessageToFile";
        private const string SavePropertiesToFileParameter = "savePropertiesToFile";
        private const string SchemeParameter = "scheme";
        private const string MessageParameter = "message";
        private const string FileParameter = "file";
        private const string LabelParameter = "label";
        private const string RetryCountParameter = "retryCount";
        private const string RetryTimeoutParameter = "retryTimeout";
        private const string TopParameter = "topCount";
        private const string ReceiveTimeoutParameter = "receiveTimeout";
        private const string SessionTimeoutParameter = "sessionTimeout";
        private const string PrefetchCountParameter = "prefetchCount";
        private const string MessageDeferProviderParameter = "messageDeferProvider";

        //***************************
        // Icons
        //***************************
        private const int QueueListIconIndex = 0;
        private const int TopicListIconIndex = 1;
        private const int QueueIconIndex = 2;
        private const int TopicIconIndex = 3;
        private const int SubscriptionListIconIndex = 4;
        private const int SubscriptionIconIndex = 5;
        private const int RuleListIconIndex = 4;
        private const int RuleIconIndex = 6;
        private const int AzureIconIndex = 7;
        private const int RelayServiceListIconIndex = 8;
        private const int RelayServiceNonLeafIconIndex = 10;
        private const int RelayServiceLeafIconIndex = 9;
        private const int RelayServiceUriIconIndex = 11;
        internal const int UrlSegmentIconIndex = 10;

        //***************************
        // Labels
        //***************************
        private const string ReceiveTopMessagesMenuItem = "Receive Top {0} Messages";
        private const string PeekTopMessagesMenuItem = "Peek Top {0} Messages";

        //***************************
        // Sizes
        //***************************
        private const int ControlMinWidth = 816;
        private const int ControlMinHeight = 345;
        #endregion

        #region Private Instance Fields
        private CancellationTokenSource cancellationTokenSource;
        private readonly ServiceBusHelper serviceBusHelper;
        private TreeNode rootNode;
        private TreeNode currentNode;
        private readonly FieldInfo eventClickFieldInfo;
        private readonly PropertyInfo eventsPropertyInfo;
        private string messageText;
        private string file;
        private string label;
        private bool importing;
        private readonly int mainSplitterDistance;
        private readonly int splitterContainerDistance;
        private readonly float treeViewFontSize;
        private readonly float logFontSize;
        private int topCount = 10;
        private int receiveTimeout = 1;
        private int sessionTimeout = 5;
        private int prefetchCount;
        public bool saveMessageToFile = true;
        public bool savePropertiesToFile = true;
        #endregion

        #region Private Static Fields
        private static MainForm mainForm;
        #endregion

        #region Public Constructor
        /// <summary>
        /// Initializes a new instance of the MainForm class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            mainSplitterDistance = mainSplitContainer.SplitterDistance;
            splitterContainerDistance = splitContainer.SplitterDistance;
            treeViewFontSize = serviceBusTreeView.Font.Size;
            logFontSize = lstLog.Font.Size;
            Trace.Listeners.Add(new LogTraceListener());
            mainForm = this;
            serviceBusHelper = new ServiceBusHelper(WriteToLog);
            serviceBusHelper.OnCreate += serviceBusHelper_OnCreate;
            serviceBusHelper.OnDelete += serviceBusHelper_OnDelete;
            serviceBusTreeView.TreeViewNodeSorter = new TreeViewHelper();
            eventClickFieldInfo = typeof(ToolStripItem).GetField(EventClick, BindingFlags.NonPublic | BindingFlags.Static);
            eventsPropertyInfo = typeof(Component).GetProperty(EventsProperty, BindingFlags.NonPublic | BindingFlags.Instance);
            GetServiceBusNamespacesFromConfiguration();
            GetServiceBusNamespaceSettingsFromConfiguration();
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Opens the options dialog.
        /// </summary>
        /// <param name="sender">MainForm object</param>
        /// <param name="e">System.EventArgs parameter</param>
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var optionForm = new OptionForm((decimal)lstLog.Font.Size, 
                                            (decimal)serviceBusTreeView.Font.Size,
                                            RetryHelper.RetryCount,
                                            RetryHelper.RetryTimeout,
                                            receiveTimeout, 
                                            sessionTimeout,
                                            prefetchCount,
                                            topCount,
                                            saveMessageToFile,
                                            savePropertiesToFile);
            if (optionForm.ShowDialog() == DialogResult.OK)
            {
                lstLog.Font = new Font(lstLog.Font.FontFamily, (float)optionForm.LogFontSize);
                serviceBusTreeView.Font = new Font(serviceBusTreeView.Font.FontFamily, (float)optionForm.TreeViewFontSize);
                RetryHelper.RetryCount = optionForm.RetryCount;
                RetryHelper.RetryTimeout = optionForm.RetryTimeout;
                receiveTimeout = optionForm.ReceiveTimeout;
                sessionTimeout = optionForm.SessionTimeout;
                prefetchCount = optionForm.PrefetchCount;
                topCount = optionForm.TopCount;
                SetTopMenuItemLabel();
            }
        }

        /// <summary>
        /// Saves the log to a text file
        /// </summary>
        /// <param name="sender">MainForm object</param>
        /// <param name="e">System.EventArgs parameter</param>
        private void saveLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstLog.Items.Count > 0)
                {
                    saveFileDialog.Title = SaveAsTitle;
                    saveFileDialog.DefaultExt = SaveAsExtension;
                    saveFileDialog.Filter = SaveAsFilter;
                    saveFileDialog.FileName = string.Format(LogFileNameFormat, DateTime.Now.ToString(CultureInfo.InvariantCulture).Replace('/', '-').Replace(':', '-'));
                    if (saveFileDialog.ShowDialog() == DialogResult.OK &&
                        !string.IsNullOrEmpty(saveFileDialog.FileName))
                    {
                        using (var writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            foreach (var t in lstLog.Items)
                            {
                                writer.WriteLine(t as string);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        /// <summary>
        /// Handles cancel events raised by user defined controls.
        /// </summary>
        void MainForm_OnCancel()
        {
            panelMain.Controls.Clear();
            panelMain.BackColor = SystemColors.Window;
            panelMain.HeaderText = Entity;
            if (currentNode != null)
            {
                serviceBusTreeView.SelectedNode = currentNode;
                HandleNodeMouseClick(currentNode);
            }
            else
            {
                serviceBusTreeView.SelectedNode = rootNode;
                HandleNodeMouseClick(rootNode);
            }
        }

        /// <summary>
        /// Individuates and remove the node corresponding to the deleted entity.
        /// </summary>
        /// <param name="args">The ServiceBusHelperEventArgs object containing the reference to the deleted entity.</param>
        void serviceBusHelper_OnDelete(ServiceBusHelperEventArgs args)
        {
            try
            {
                serviceBusTreeView.SuspendDrawing();
                serviceBusTreeView.SuspendLayout();
                panelMain.Controls.Clear();
                panelMain.BackColor = SystemColors.Window;
                panelMain.HeaderText = Entity;
                serviceBusTreeView.SelectedNode = rootNode;
                // QueueDescription Entity
                if (args.EntityType == EntityType.Queue)
                {
                    string queueName = null;
                    if (args.EntityInstance is string)
                    {
                        queueName = args.EntityInstance as string;
                    }
                    else
                    {
                        if (args.EntityInstance is QueueDescription)
                        {
                            queueName = ((QueueDescription) args.EntityInstance).Path;
                        }
                    }
                    var queueListNode = FindNode(QueueEntities, rootNode);
                    if (!string.IsNullOrEmpty(queueName))
                    {
                        DeleteNode(queueName, queueListNode);
                    }
                    else
                    {
                        GetEntities(EntityType.Queue);
                    }
                    serviceBusTreeView.SelectedNode = queueListNode;
                    HandleNodeMouseClick(queueListNode);
                    return;

                }
                // TopicDescription Entity
                if (args.EntityType == EntityType.Topic)
                {
                    string topicName = null;
                    if (args.EntityInstance is string)
                    {
                        topicName = args.EntityInstance as string;
                    }
                    else
                    {
                        if (args.EntityInstance is TopicDescription)
                        {
                            topicName = ((TopicDescription)args.EntityInstance).Path;
                        }
                    }
                    var topicListNode = FindNode(TopicEntities, rootNode);
                    if (!string.IsNullOrEmpty(topicName))
                    {
                        DeleteNode(topicName, topicListNode);
                    }
                    else
                    {
                        GetEntities(EntityType.Topic);
                    }
                    serviceBusTreeView.SelectedNode = topicListNode;
                    HandleNodeMouseClick(topicListNode);
                    return;
                }
                // SubscriptionDescription Entity
                if (args.EntityType == EntityType.Subscription)
                {
                    var topicListNode = FindNode(TopicEntities, rootNode);
                    var subscription = args.EntityInstance as SubscriptionDescription;
                    if (subscription != null &&
                        !string.IsNullOrEmpty(subscription.TopicPath))
                    {
                        var topicNode = FindNode(subscription.TopicPath, topicListNode);
                        if (topicNode == null)
                        {
                            GetEntities(EntityType.Topic);
                            return;
                        }
                        if (topicNode.Nodes.ContainsKey(SubscriptionEntities))
                        {
                            var subscriptionsNode = topicNode.Nodes[SubscriptionEntities];
                            if (subscriptionsNode.Nodes.ContainsKey(subscription.Name))
                            {
                                subscriptionsNode.Nodes.RemoveByKey(subscription.Name);
                                if (subscriptionsNode.Nodes.Count == 0)
                                {
                                    topicNode.Nodes.Clear();
                                    serviceBusTreeView.SelectedNode = topicNode;
                                    HandleNodeMouseClick(topicNode);
                                }
                                else
                                {
                                    subscriptionsNode.Expand();
                                    serviceBusTreeView.SelectedNode = subscriptionsNode;
                                    HandleNodeMouseClick(subscriptionsNode);
                                }
                            }
                            else
                            {
                                GetEntities(EntityType.Topic);
                                return;
                            }
                        }
                        else
                        {
                            GetEntities(EntityType.Topic);
                            return;
                        }
                    }
                    else
                    {
                        GetEntities(EntityType.Topic);
                        return;
                    }
                    serviceBusTreeView.SelectedNode = null;
                    return;
                }
                // RuleDescription Entity
                if (args.EntityType == EntityType.Rule)
                {
                    var topicListNode = FindNode(TopicEntities, rootNode);
                    var wrapper = args.EntityInstance as RuleWrapper;
                    if (wrapper != null &&
                        wrapper.RuleDescription != null &&
                        wrapper.SubscriptionDescription != null &&
                        !string.IsNullOrEmpty(wrapper.RuleDescription.Name) &&
                        !string.IsNullOrEmpty(wrapper.SubscriptionDescription.TopicPath))
                    {
                        var topicNode = FindNode(wrapper.SubscriptionDescription.TopicPath, topicListNode);
                        if (topicNode == null)
                        {
                            GetEntities(EntityType.Topic);
                            return;
                        }
                        if (topicNode.Nodes.ContainsKey(SubscriptionEntities))
                        {
                            var subscriptionsNode = topicNode.Nodes[SubscriptionEntities];
                            if (subscriptionsNode.Nodes.ContainsKey(wrapper.SubscriptionDescription.Name))
                            {
                                var subscriptionNode = subscriptionsNode.Nodes[wrapper.SubscriptionDescription.Name];
                                if (subscriptionNode.Nodes.ContainsKey(RuleEntities))
                                {
                                    var rulesNode = subscriptionNode.Nodes[RuleEntities];
                                    if (rulesNode.Nodes.ContainsKey(wrapper.RuleDescription.Name))
                                    {
                                        rulesNode.Nodes.RemoveByKey(wrapper.RuleDescription.Name);
                                        if (rulesNode.Nodes.Count == 0)
                                        {
                                            subscriptionNode.Nodes.Clear();
                                            serviceBusTreeView.SelectedNode = subscriptionNode;
                                            HandleNodeMouseClick(subscriptionsNode);
                                        }
                                        else
                                        {
                                            rulesNode.Expand();
                                            serviceBusTreeView.SelectedNode = rulesNode;
                                            HandleNodeMouseClick(rulesNode);
                                        }
                                    }
                                }
                                else
                                {
                                    GetEntities(EntityType.Topic);
                                    return;
                                }
                            }
                            else
                            {
                                GetEntities(EntityType.Topic);
                                return;
                            }
                        }
                        else
                        {
                            GetEntities(EntityType.Topic);
                            return;
                        }
                    }
                    else
                    {
                        GetEntities(EntityType.Topic);
                        return;
                    }
                    serviceBusTreeView.SelectedNode = null;
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                serviceBusTreeView.ResumeDrawing();
                serviceBusTreeView.ResumeLayout();
            }
        }

        /// <summary>
        /// Adds a node to the treeview for the newly created entity.
        /// </summary>
        /// <param name="args">The ServiceBusHelperEventArgs object containing the reference to the newly created entity.</param>
        void serviceBusHelper_OnCreate(ServiceBusHelperEventArgs args)
        {
            try
            {
                serviceBusTreeView.SuspendDrawing();
                serviceBusTreeView.SuspendLayout();
                // QueueDescription Entity
                if (args.EntityType == EntityType.Queue)
                {
                    var queue = args.EntityInstance as QueueDescription;
                    if (queue != null)
                    {
                        var queueListNode = FindNode(QueueEntities, rootNode);
                        var node = CreateNode(queue.Path, queue, queueListNode, false);
                        serviceBusTreeView.Sort();
                        panelMain.HeaderText = string.Format(ViewQueueFormat, queue.Path);
                        if (!importing)
                        {
                            serviceBusTreeView.SelectedNode = node;
                            HandleNodeMouseClick(serviceBusTreeView.SelectedNode);
                        }
                        else
                        {
                            queueListNode.Expand();
                        }
                    }
                    return;
                }
                // TopicDescription Entity
                if (args.EntityType == EntityType.Topic)
                {
                    var topic = args.EntityInstance as TopicDescription;
                    if (topic != null)
                    {
                        var topicListNode = FindNode(TopicEntities, rootNode);
                        var node = CreateNode(topic.Path, topic, topicListNode, false);
                        serviceBusTreeView.Sort();
                        panelMain.HeaderText = string.Format(ViewTopicFormat, topic.Path);
                        if (!importing)
                        {
                            serviceBusTreeView.SelectedNode = node;
                            HandleNodeMouseClick(serviceBusTreeView.SelectedNode);
                        }
                        else
                        {
                            topicListNode.Expand();
                        }
                    }
                    return;
                }
                // SubscriptionDescription Entity
                if (args.EntityType == EntityType.Subscription)
                {
                    var wrapper = args.EntityInstance as SubscriptionWrapper;
                    if (wrapper == null ||
                        wrapper.TopicDescription == null ||
                        wrapper.SubscriptionDescription == null)
                    {
                        return;
                    }
                    var topicListNode = FindNode(TopicEntities, rootNode);
                    var topicNode = FindNode(wrapper.TopicDescription.Path, topicListNode);
                    if (topicNode != null)
                    {
                        TreeNode subscriptionsNode;

                        if (topicNode.Nodes.ContainsKey(SubscriptionEntities))
                        {
                            subscriptionsNode = topicNode.Nodes[SubscriptionEntities];
                        }
                        else
                        {
                            subscriptionsNode = topicNode.Nodes.Add(SubscriptionEntities, SubscriptionEntities, SubscriptionListIconIndex, SubscriptionListIconIndex);
                            subscriptionsNode.ContextMenuStrip = subscriptionsContextMenuStrip;
                            subscriptionsNode.Tag = new SubscriptionWrapper(null, wrapper.TopicDescription);
                        }
                        var subscriptionNode = subscriptionsNode.Nodes.Add(wrapper.SubscriptionDescription.Name, wrapper.SubscriptionDescription.Name, SubscriptionIconIndex, SubscriptionIconIndex);
                        subscriptionNode.ContextMenuStrip = subscriptionContextMenuStrip;
                        subscriptionNode.Tag = new SubscriptionWrapper(wrapper.SubscriptionDescription, wrapper.TopicDescription);
                        subscriptionsNode.Expand();
                        panelMain.HeaderText = string.Format(ViewSubscriptionFormat, wrapper.SubscriptionDescription.Name);
                        if (!importing)
                        {
                            serviceBusTreeView.SelectedNode = subscriptionsNode.Nodes[wrapper.SubscriptionDescription.Name];
                            HandleNodeMouseClick(serviceBusTreeView.SelectedNode);
                        }
                        var rules = serviceBusHelper.GetRules(wrapper.SubscriptionDescription);
                        if (rules != null &&
                            rules.Count() > 0)
                        {
                            subscriptionNode.Nodes.Clear();
                            var rulesNode = subscriptionNode.Nodes.Add(RuleEntities, RuleEntities, RuleListIconIndex, RuleListIconIndex);
                            rulesNode.ContextMenuStrip = rulesContextMenuStrip;
                            rulesNode.Tag = new RuleWrapper(null, wrapper.SubscriptionDescription);
                            foreach (var rule in rules)
                            {
                                var ruleNode = rulesNode.Nodes.Add(rule.Name, rule.Name, RuleIconIndex, RuleIconIndex);
                                ruleNode.ContextMenuStrip = ruleContextMenuStrip;
                                ruleNode.Tag = new RuleWrapper(rule, wrapper.SubscriptionDescription);
                            }
                        }
                    }
                    return;
                }
                // RuleDescription Entity
                if (args.EntityType == EntityType.Rule)
                {
                    var wrapper = args.EntityInstance as RuleWrapper;
                    if (wrapper == null ||
                        wrapper.SubscriptionDescription == null ||
                        wrapper.RuleDescription == null)
                    {
                        return;
                    }
                    var topicListNode = FindNode(TopicEntities, rootNode);
                    var topicNode = FindNode(wrapper.SubscriptionDescription.TopicPath, topicListNode);
                    if (topicNode != null)
                    {
                        if (topicNode.Nodes.ContainsKey(SubscriptionEntities))
                        {
                            var subscriptionsNode = topicNode.Nodes[SubscriptionEntities];
                            if (subscriptionsNode.Nodes.ContainsKey(wrapper.SubscriptionDescription.Name))
                            {
                                var subscriptionNode = subscriptionsNode.Nodes[wrapper.SubscriptionDescription.Name];
                                TreeNode rulesNode;
                                if (subscriptionNode.Nodes.ContainsKey(RuleEntities))
                                {
                                    rulesNode = subscriptionNode.Nodes[RuleEntities];
                                }
                                else
                                {
                                    rulesNode = subscriptionNode.Nodes.Add(RuleEntities, RuleEntities, RuleListIconIndex, RuleListIconIndex);
                                    rulesNode.ContextMenuStrip = rulesContextMenuStrip;
                                    rulesNode.Tag = new RuleWrapper(null, wrapper.SubscriptionDescription);
                                }
                                TreeNode ruleNode = rulesNode.Nodes.Add(wrapper.RuleDescription.Name, wrapper.RuleDescription.Name, RuleIconIndex, RuleIconIndex);
                                ruleNode.ContextMenuStrip = ruleContextMenuStrip;
                                ruleNode.Tag = wrapper;
                                rulesNode.Expand();
                                panelMain.HeaderText = string.Format(ViewRuleFormat, wrapper.RuleDescription.Name);
                                if (!importing)
                                {
                                    serviceBusTreeView.SelectedNode = rulesNode.Nodes[wrapper.RuleDescription.Name];
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                serviceBusTreeView.ResumeDrawing();
                serviceBusTreeView.ResumeLayout();
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            var borderRectangle = new Rectangle(Width - 146, 4, 114, 28);
            ControlPaint.DrawBorder3D(e.Graphics, borderRectangle, Border3DStyle.Etched);
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            this.SuspendDrawing();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            this.ResumeDrawing();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            var changingUI = false;
            try
            {
                changingUI = true;
                panelMain.SuspendLayout();
                panelMain.SuspendDrawing();
                SetControlSize(null);
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                if (changingUI)
                {
                    panelMain.ResumeDrawing();
                    panelMain.ResumeLayout();
                }
            }
        }

        private void mainSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            var changingUI = false;
            try
            {
                changingUI = true;
                panelMain.SuspendLayout();
                panelMain.SuspendDrawing();
                SetControlSize(null);
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                if (changingUI)
                {
                    panelMain.ResumeDrawing();
                    panelMain.ResumeLayout();
                }
            }
        }

        private void logWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                mainSplitContainer.Panel2Collapsed = !((ToolStripMenuItem)sender).Checked;
                mainSplitContainer_SplitterMoved(this, null);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AboutForm();
            form.ShowDialog();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var connectForm = new ConnectForm(serviceBusHelper);
                if (connectForm.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    if (!string.IsNullOrEmpty(connectForm.Uri))
                    {
                        serviceBusHelper.Connect(connectForm.Uri,
                                                 connectForm.IssuerName,
                                                 connectForm.IssuerSecret);
                    }
                    else
                    {
                        serviceBusHelper.Connect(connectForm.Namespace,
                                                 connectForm.ServicePath,
                                                 connectForm.IssuerName,
                                                 connectForm.IssuerSecret);
                    }
                    GetEntities(EntityType.All);
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearLog_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }

        private void lstLog_Leave(object sender, EventArgs e)
        {
            lstLog.SelectedIndex = -1;
        }

        private void serviceBusTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (serviceBusTreeView.SelectedNode != e.Node)
            {
                serviceBusTreeView.SelectedNode = e.Node;
                HandleNodeMouseClick(e.Node);
            }
        }

        private void refreshEntityMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            GetEntities(EntityType.All);
            Cursor.Current = Cursors.Default;
        }

        private void expandEntity_Click(object sender, EventArgs e)
        {
            if (serviceBusTreeView.SelectedNode != null)
            {
                serviceBusTreeView.SelectedNode.ExpandAll();
            }
        }

        private void collapseEntity_Click(object sender, EventArgs e)
        {
            if (serviceBusTreeView.SelectedNode != null)
            {
                serviceBusTreeView.SelectedNode.Collapse(false);
            }
        }

        private void exportEntity_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceBusHelper == null)
                {
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                var queueListNode = FindNode(QueueEntities, rootNode);
                var topicListNode = FindNode(TopicEntities, rootNode);
                // Root
                if (serviceBusTreeView.SelectedNode == rootNode)
                {
                    var queueList = new List<EntityDescription>();
                    var topicList = new List<EntityDescription>();
                    GetQueueList(queueList, queueListNode);
                    GetTopicList(topicList, topicListNode);
                    queueList.AddRange(topicList);
                    ExportEntities(queueList, AllEntities, null);
                    return;
                }
                // Queues
                if (serviceBusTreeView.SelectedNode == queueListNode)
                {
                    var queueList = new List<EntityDescription>();
                    GetQueueList(queueList, queueListNode);
                    ExportEntities(queueList, QueueEntities, null);
                    return;
                }
                // Topics
                if (serviceBusTreeView.SelectedNode == topicListNode)
                {
                    var topicList = new List<EntityDescription>();
                    GetTopicList(topicList, topicListNode);
                    ExportEntities(topicList, TopicEntities, null);
                    return;
                }
                // Check that serviceBusTreeView.SelectedNode.Tag is not null
                if (serviceBusTreeView.SelectedNode.Tag == null)
                {
                    return;
                }
                // Url Segment Node
                if (serviceBusTreeView.SelectedNode.Tag is UrlSegmentWrapper)
                {
                    var urlSegmentWrapper = serviceBusTreeView.SelectedNode.Tag as UrlSegmentWrapper;
                    if (urlSegmentWrapper.EntityType == EntityType.Queue)
                    {
                        var queueList = new List<EntityDescription>();
                        GetQueueList(queueList, serviceBusTreeView.SelectedNode);
                        ExportEntities(queueList,
                                       FormatAbsolutePathForExport(urlSegmentWrapper.Uri), 
                                       QueueEntities);
                    }
                    else
                    {
                        var topicList = new List<EntityDescription>();
                        GetTopicList(topicList, serviceBusTreeView.SelectedNode);
                        ExportEntities(topicList, 
                                       FormatAbsolutePathForExport(urlSegmentWrapper.Uri), 
                                       TopicEntities);
                    }
                    return;
                }
                // Queue Node
                if (serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                {
                    var queueDescription = serviceBusTreeView.SelectedNode.Tag as QueueDescription;
                    ExportEntities(new List<EntityDescription> { queueDescription },
                                   queueDescription.Path,
                                   QueueEntity);
                    return;
                }
                // Topic Node
                if (serviceBusTreeView.SelectedNode.Tag is TopicDescription)
                {
                    var topicDescription = serviceBusTreeView.SelectedNode.Tag as TopicDescription;
                    ExportEntities(new List<EntityDescription> { topicDescription },
                                   topicDescription.Path,
                                   TopicEntity);
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void importEntity_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceBusHelper == null)
                {
                    return;
                }
                Cursor.Current = Cursors.WaitCursor;
                string fileName;
                var xml = LoadEntityFromFile(out fileName);
                if (xml != null)
                {
                    importing = true;
                    serviceBusHelper.ImportEntities(xml);
                    WriteToLog(string.Format(EntitiesImported, fileName));
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                importing = false;
                Cursor.Current = Cursors.Default;
            }
        }

        private void refreshEntity_Click(object sender, EventArgs e)
        {
            try
            {
                serviceBusTreeView.SuspendDrawing();
                serviceBusTreeView.SuspendLayout();
                serviceBusTreeView.BeginUpdate();
                var queueListNode = FindNode(QueueEntities, rootNode);
                var topicListNode = FindNode(TopicEntities, rootNode);
                var relayServiceListNode = FindNode(RelayServiceEntities, rootNode);
                if (serviceBusTreeView.SelectedNode != null)
                {
                    // Queues
                    if (serviceBusTreeView.SelectedNode == queueListNode)
                    {
                        GetEntities(EntityType.Queue);
                        return;
                    }
                    // Topics
                    if (serviceBusTreeView.SelectedNode == topicListNode)
                    {
                        GetEntities(EntityType.Topic);
                        return;
                    }
                    // Relay Services
                    if (serviceBusTreeView.SelectedNode == relayServiceListNode)
                    {
                        GetEntities(EntityType.RelayService);
                        return;
                    }
                    // Queue Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                    {
                        var queue = serviceBusHelper.GetQueue(((QueueDescription)serviceBusTreeView.SelectedNode.Tag).Path);
                        serviceBusTreeView.SelectedNode.Tag = queue;
                        ShowQueue(queue, null);
                        return;
                    }
                    // Topic Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is TopicDescription)
                    {
                        var topic = serviceBusHelper.GetTopic(((TopicDescription)serviceBusTreeView.SelectedNode.Tag).Path);
                        serviceBusTreeView.SelectedNode.Tag = topic;
                        ShowTopic(topic, null);
                        return;
                    }
                    // Subscription Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is SubscriptionWrapper)
                    {
                        var wrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                        var subscriptionDescription = serviceBusHelper.GetSubscription(wrapper.SubscriptionDescription.TopicPath,
                                                                                   wrapper.SubscriptionDescription.Name);
                        wrapper = new SubscriptionWrapper(subscriptionDescription, wrapper.TopicDescription);
                        serviceBusTreeView.SelectedNode.Tag = wrapper;
                        ShowSubscription(wrapper);
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                serviceBusTreeView.ResumeDrawing();
                serviceBusTreeView.ResumeLayout();
                serviceBusTreeView.EndUpdate();
            }
        }

        private void createEntity_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceBusTreeView.SelectedNode != null)
                {
                    // Queues Node (Create New QueueDescription)
                    if (serviceBusTreeView.SelectedNode.Text == QueueEntities)
                    {
                        panelMain.HeaderText = CreateQueue;
                        ShowQueue(null, null);
                        return;
                    }
                    // Topics Node (Create New TopicDescription)
                    if (serviceBusTreeView.SelectedNode.Text == TopicEntities)
                    {
                        panelMain.HeaderText = CreateTopic;
                        ShowTopic(null, null);
                        return;
                    }
                    if (serviceBusTreeView.SelectedNode.Tag != null)
                    {
                        // UrlSegment Node
                        if (serviceBusTreeView.SelectedNode.Tag is UrlSegmentWrapper)
                        {
                            var urlSegmentWrapper = serviceBusTreeView.SelectedNode.Tag as UrlSegmentWrapper; 
                            if (urlSegmentWrapper.EntityType == EntityType.Queue)
                            {
                                panelMain.HeaderText = CreateQueue;
                                ShowQueue(null, FormatAbsolutePathForEdit(urlSegmentWrapper.Uri));
                            }
                            else
                            {
                                panelMain.HeaderText = CreateTopic;
                                ShowTopic(null, FormatAbsolutePathForEdit(urlSegmentWrapper.Uri));
                            }
                            return;
                        }

                        // TopicDescription Node (Create New SubscriptionDescription)
                        if (serviceBusTreeView.SelectedNode.Tag is TopicDescription)
                        {
                            panelMain.HeaderText = CreateSubscription;
                            ShowSubscription(new SubscriptionWrapper(null, serviceBusTreeView.SelectedNode.Tag as TopicDescription));
                            return;
                        }
                        // Subscriptions Node (Create New SubscriptionDescription)
                        if (serviceBusTreeView.SelectedNode.Text == SubscriptionEntities)
                        {
                            panelMain.HeaderText = CreateSubscription;
                            var subscriptionWrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                            if (subscriptionWrapper != null)
                            {
                                ShowSubscription(new SubscriptionWrapper(null, subscriptionWrapper.TopicDescription));
                            }
                            return;
                        }
                        // SubscriptionDescription Node (Create New RuleDescription)
                        if (serviceBusTreeView.SelectedNode.Tag is SubscriptionWrapper)
                        {
                            var wrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                            panelMain.HeaderText = AddRule;
                            ShowRule(new RuleWrapper(null, wrapper.SubscriptionDescription), !serviceBusTreeView.SelectedNode.Nodes.ContainsKey(RuleEntities));
                            return;
                        }
                        // Rules Node (Create New RuleDescription)
                        if (serviceBusTreeView.SelectedNode.Text == RuleEntities)
                        {
                            panelMain.HeaderText = AddRule;
                            var ruleWrapper = serviceBusTreeView.SelectedNode.Tag as RuleWrapper;
                            if (ruleWrapper != null)
                            {
                                ShowRule(new RuleWrapper(null, ruleWrapper.SubscriptionDescription), false);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void deleteEntity_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (serviceBusTreeView.SelectedNode != null)
                {
                    var queueListNode = FindNode(QueueEntities, rootNode);
                    var topicListNode = FindNode(TopicEntities, rootNode);
                    // Root Node
                    if (serviceBusTreeView.SelectedNode == rootNode)
                    {
                        var deleteForm = new DeleteForm(DeleteAllEntities);
                        if (deleteForm.ShowDialog() == DialogResult.OK)
                        {
                            var queueList = new List<string>();
                            var topicList = new List<string>();
                            GetQueueList(queueList, queueListNode);
                            GetTopicList(topicList, topicListNode);
                            serviceBusHelper.DeleteQueues(queueList);
                            serviceBusHelper.DeleteTopics(topicList);
                            GetEntities(EntityType.All);
                        }
                        return;
                    }
                    // Queues Node
                    if (serviceBusTreeView.SelectedNode == queueListNode)
                    {
                        var deleteForm = new DeleteForm(DeleteAllQueues);
                        if (deleteForm.ShowDialog() == DialogResult.OK)
                        {
                            var queueList = new List<string>();
                            GetQueueList(queueList, queueListNode);
                            serviceBusHelper.DeleteQueues(queueList);
                            GetEntities(EntityType.Queue);
                        }
                        return;
                    }
                    // Topics Node
                    if (serviceBusTreeView.SelectedNode == topicListNode)
                    {
                        var deleteForm = new DeleteForm(DeleteAllTopics);
                        if (deleteForm.ShowDialog() == DialogResult.OK)
                        {
                            var topicList = new List<string>();
                            GetTopicList(topicList, topicListNode);
                            serviceBusHelper.DeleteTopics(topicList);
                            GetEntities(EntityType.Topic);
                        }
                        return;
                    }
                    // Check that serviceBusTreeView.SelectedNode.Tag is not null
                    if (serviceBusTreeView.SelectedNode.Tag == null)
                    {
                        return;
                    }
                    // Url Segment Node
                    if (serviceBusTreeView.SelectedNode.Tag is UrlSegmentWrapper)
                    {
                        var urlSegmentWrapper = serviceBusTreeView.SelectedNode.Tag as UrlSegmentWrapper;
                        if (urlSegmentWrapper.EntityType == EntityType.Queue)
                        {
                            var deleteForm = new DeleteForm(string.Format(DeleteAllQueuesInPath, FormatAbsolutePathForEdit(urlSegmentWrapper.Uri)));
                            if (deleteForm.ShowDialog() == DialogResult.OK)
                            {
                                var queueList = new List<string>();
                                GetQueueList(queueList, serviceBusTreeView.SelectedNode);
                                serviceBusHelper.DeleteQueues(queueList);
                            }
                        }
                        else
                        {
                            var deleteForm = new DeleteForm(string.Format(DeleteAllTopicsInPath, FormatAbsolutePathForEdit(urlSegmentWrapper.Uri)));
                            if (deleteForm.ShowDialog() == DialogResult.OK)
                            {
                                var topicList = new List<string>();
                                GetTopicList(topicList, serviceBusTreeView.SelectedNode);
                                serviceBusHelper.DeleteTopics(topicList);
                            }
                        }
                        return;
                    }
                    // Queue Node
                    if (serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                    {
                        var queue = serviceBusTreeView.SelectedNode.Tag as QueueDescription;
                        var deleteForm = new DeleteForm(queue.Path, QueueEntity.ToLower());
                        if (deleteForm.ShowDialog() == DialogResult.OK)
                        {
                            serviceBusHelper.DeleteQueue(queue);
                        }
                        return;
                    }
                    // Subscriptions Node
                    if (sender == deleteTopicSubscriptionsMenuItem)
                    {
                        if (serviceBusTreeView.SelectedNode.Nodes.Count == 0)
                        {
                            return;
                        }
                        var subscriptionsNode = serviceBusTreeView.SelectedNode.Nodes[0];
                        var subscriptionDescriptions = subscriptionsNode.
                                                            Nodes.
                                                            Cast<TreeNode>().
                                                            Select(n => ((SubscriptionWrapper)n.Tag).SubscriptionDescription).
                                                            ToList();
                        if (subscriptionDescriptions.Count > 0)
                        {
                            var deleteForm = new DeleteForm(DeleteAllSubscriptions);
                            if (deleteForm.ShowDialog() == DialogResult.OK)
                            {
                                serviceBusHelper.DeleteSubscriptions(subscriptionDescriptions);
                            }
                        }
                        return;
                    }
                    // Topic Node
                    if (serviceBusTreeView.SelectedNode.Tag is TopicDescription)
                    {
                        var topic = serviceBusTreeView.SelectedNode.Tag as TopicDescription;
                        var deleteForm = new DeleteForm(topic.Path, TopicEntity.ToLower());
                        if (deleteForm.ShowDialog() == DialogResult.OK)
                        {
                            serviceBusHelper.DeleteTopic(topic);
                        }
                        return;
                    }
                    // Subscriptions Node
                    if (serviceBusTreeView.SelectedNode.Text == SubscriptionEntities)
                    {
                        var subscriptionDescriptions = serviceBusTreeView.SelectedNode.
                                                            Nodes.
                                                            Cast<TreeNode>().
                                                            Select(n => ((SubscriptionWrapper)n.Tag).SubscriptionDescription).
                                                            ToList();
                        if (subscriptionDescriptions.Count > 0)
                        {
                            var deleteForm = new DeleteForm(DeleteAllSubscriptions);
                            if (deleteForm.ShowDialog() == DialogResult.OK)
                            {
                                serviceBusHelper.DeleteSubscriptions(subscriptionDescriptions);
                            }
                        }
                        return;
                    }
                    // Subscription Node
                    if (serviceBusTreeView.SelectedNode.Tag is SubscriptionWrapper)
                    {
                        var wrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                        if (wrapper.TopicDescription != null &&
                            wrapper.SubscriptionDescription != null)
                        {
                            var deleteForm = new DeleteForm(wrapper.SubscriptionDescription.Name, SubscriptionEntity.ToLower());
                            if (deleteForm.ShowDialog() == DialogResult.OK)
                            {
                                serviceBusHelper.DeleteSubscription(wrapper.SubscriptionDescription);
                            }
                        }
                        return;
                    }
                    // Rules Node
                    if (serviceBusTreeView.SelectedNode.Text == RuleEntities)
                    {
                        var ruleWrappers = serviceBusTreeView.SelectedNode.
                                                            Nodes.
                                                            Cast<TreeNode>().
                                                            Select(n => (RuleWrapper)n.Tag).
                                                            ToList();
                        if (ruleWrappers.Count > 0)
                        {
                            var deleteForm = new DeleteForm(DeleteAllRules);
                            if (deleteForm.ShowDialog() == DialogResult.OK)
                            {
                                serviceBusHelper.RemoveRules(ruleWrappers);
                            }
                        }
                        return;
                    }
                    // Rule Node
                    if (serviceBusTreeView.SelectedNode.Tag is RuleWrapper)
                    {
                        var wrapper = serviceBusTreeView.SelectedNode.Tag as RuleWrapper;
                        if (wrapper.SubscriptionDescription != null &&
                            wrapper.RuleDescription != null)
                        {
                            var deleteForm = new DeleteForm(wrapper.RuleDescription.Name, RuleEntity.ToLower());
                            if (deleteForm.ShowDialog() == DialogResult.OK)
                            {
                                serviceBusHelper.RemoveRule(wrapper.SubscriptionDescription, wrapper.RuleDescription);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void testEntityInSDIMode_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceBusTreeView.SelectedNode != null)
                {
                    // QueueDescription Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                    {
                        var queue = serviceBusTreeView.SelectedNode.Tag as QueueDescription;
                        panelMain.HeaderText = string.Format(TestQueueFormat, queue.Path);
                        TestQueue(queue, true);
                        return;
                    }
                    // TopicDescription Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is TopicDescription)
                    {
                        var topic = serviceBusTreeView.SelectedNode.Tag as TopicDescription;
                        var subscriptionList = new List<SubscriptionDescription>();
                        if (serviceBusTreeView.SelectedNode.Nodes.ContainsKey(SubscriptionEntities))
                        {
                            var subscriptionsNode = serviceBusTreeView.SelectedNode.Nodes[SubscriptionEntities];
                            if (subscriptionsNode != null &&
                                subscriptionsNode.Nodes.Count > 0)
                            {
                                for (var i = 0; i < subscriptionsNode.Nodes.Count; i++)
                                {
                                    var wrapper = subscriptionsNode.Nodes[i].Tag as SubscriptionWrapper;
                                    if (wrapper != null &&
                                        wrapper.SubscriptionDescription != null)
                                    {
                                        subscriptionList.Add(wrapper.SubscriptionDescription);
                                    }
                                }
                            }
                        }

                        panelMain.HeaderText = string.Format(TestTopicFormat, topic.Path);
                        TestTopic(topic, subscriptionList, true);
                        return;
                    }

                    // SubscriptionDescription Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is SubscriptionWrapper)
                    {
                        var subscriptionWrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                        panelMain.HeaderText = string.Format(TestSubscriptionFormat, subscriptionWrapper.SubscriptionDescription.Name);
                        TestSubscription(subscriptionWrapper, true);
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void testEntityInMDIMode_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceBusTreeView.SelectedNode != null)
                {
                    // QueueDescription Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                    {
                        var queue = serviceBusTreeView.SelectedNode.Tag as QueueDescription;
                        panelMain.HeaderText = string.Format(TestQueueFormat, queue.Path);
                        TestQueue(queue, false);
                        return;
                    }
                    // TopicDescription Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is TopicDescription)
                    {
                        var topic = serviceBusTreeView.SelectedNode.Tag as TopicDescription;
                        var subscriptionList = new List<SubscriptionDescription>();
                        if (serviceBusTreeView.SelectedNode.Nodes.ContainsKey(SubscriptionEntities))
                        {
                            var subscriptionsNode = serviceBusTreeView.SelectedNode.Nodes[SubscriptionEntities];
                            if (subscriptionsNode != null &&
                                subscriptionsNode.Nodes.Count > 0)
                            {
                                for (var i = 0; i < subscriptionsNode.Nodes.Count; i++)
                                {
                                    var wrapper = subscriptionsNode.Nodes[i].Tag as SubscriptionWrapper;
                                    if (wrapper != null &&
                                        wrapper.SubscriptionDescription != null)
                                    {
                                        subscriptionList.Add(wrapper.SubscriptionDescription);
                                    }
                                }
                            }
                        }

                        panelMain.HeaderText = string.Format(TestTopicFormat, topic.Path);
                        TestTopic(topic, subscriptionList, false);
                        return;
                    }

                    // SubscriptionDescription Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is SubscriptionWrapper)
                    {
                        var subscriptionWrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                        panelMain.HeaderText = string.Format(TestSubscriptionFormat, subscriptionWrapper.SubscriptionDescription.Name);
                        TestSubscription(subscriptionWrapper, false);
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        #endregion

        #region Public Methods
        public void WriteToLog(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(InternalWriteToLog), new object[] { message });
            }
            else
            {
                InternalWriteToLog(message);
            }
        }

        public void HandleException(Exception ex)
        {
            if (ex != null && !string.IsNullOrEmpty(ex.Message))
            {
                WriteToLog(string.Format(CultureInfo.CurrentCulture, ExceptionFormat, ex.Message));
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    WriteToLog(string.Format(CultureInfo.CurrentCulture, InnerExceptionFormat, ex.InnerException.Message));
                }
            }
        }
        #endregion

        #region Private Methods
        private void HandleNodeMouseClick(TreeNode node)
        {
            try
            {
                if (node == null)
                {
                    return;
                }
                currentNode = node;
                serviceBusTreeView.SuspendDrawing();
                serviceBusTreeView.SuspendLayout();
                serviceBusTreeView.BeginUpdate();
                var queueListNode = FindNode(QueueEntities, rootNode);
                var topicListNode = FindNode(TopicEntities, rootNode);
                var relayServiceListNode = FindNode(RelayServiceEntities, rootNode);
                actionsToolStripMenuItem.DropDownItems.Clear();
                // Root Node
                if (node == rootNode)
                {
                    var list = CloneItems(rootContextMenuStrip.Items);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    return;
                }
                // Queues Node
                if (node == queueListNode)
                {
                    var list = CloneItems(queuesContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    return;
                }
                // Topics Node
                if (node == topicListNode)
                {
                    var list = CloneItems(topicsContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    return;
                }
                // Url Segment Node
                if (node.Tag != null &&
                    node.Tag is UrlSegmentWrapper)
                {
                    var urlSegmentWrapper = node.Tag as UrlSegmentWrapper;
                    if (urlSegmentWrapper.EntityType == EntityType.Queue)
                    {
                        var list = CloneItems(queueFolderContextMenuStrip.Items);
                        AddImportAndSeparatorMenuItems(list);
                        actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    }
                    else
                    {
                        var list = CloneItems(topicFolderContextMenuStrip.Items);
                        AddImportAndSeparatorMenuItems(list);
                        actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    }
                    return;
                }
                // Queue Node
                if (node.Tag != null &&
                    node.Tag is QueueDescription)
                {
                    var queue = node.Tag as QueueDescription;
                    var list = CloneItems(queueContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    panelMain.HeaderText = string.Format(ViewQueueFormat, queue.Path);
                    ShowQueue(queue, null);
                    return;
                }
                // Topic Node
                if (node.Tag != null &&
                    node.Tag is TopicDescription)
                {
                    var topic = node.Tag as TopicDescription;
                    var list = CloneItems(topicContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    panelMain.HeaderText = string.Format(ViewTopicFormat, topic.Path);
                    ShowTopic(topic, null);
                    return;
                }
                // Subscriptions Node
                if (node.Text == SubscriptionEntities)
                {
                    var list = CloneItems(subscriptionsContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    return;
                }
                // Subscription Node
                if (node.Tag != null &&
                    node.Tag is SubscriptionWrapper)
                {
                    var wrapper = node.Tag as SubscriptionWrapper;
                    var list = CloneItems(subscriptionContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    panelMain.HeaderText = string.Format(ViewSubscriptionFormat, wrapper.SubscriptionDescription.Name);
                    ShowSubscription(wrapper);
                    return;
                }
                // Rules Node
                if (node.Text == RuleEntities)
                {
                    var list = CloneItems(rulesContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    return;
                }
                // RuleDescription Node
                if (node.Tag != null &&
                    node.Tag is RuleWrapper)
                {
                    var wrapper = node.Tag as RuleWrapper;
                    var list = CloneItems(ruleContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    panelMain.HeaderText = string.Format(ViewRuleFormat, wrapper.RuleDescription.Name);
                    ShowRule(wrapper, null);
                    return;
                }
                // Relay Services Node
                if (node == relayServiceListNode)
                {
                    var list = CloneItems(relayServicesContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    return;
                }
                // Relay Service Node
                if (node.Tag is RelayServiceWrapper)
                {
                    var wrapper = node.Tag as RelayServiceWrapper;
                    var list = CloneItems(relayServiceContextMenuStrip.Items);
                    AddImportAndSeparatorMenuItems(list);
                    actionsToolStripMenuItem.DropDownItems.AddRange(list.ToArray());
                    panelMain.HeaderText = string.Format(TestRelayServiceFormat, wrapper.Name);
                    TestRelayService(wrapper, true);
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                serviceBusTreeView.ResumeDrawing();
                serviceBusTreeView.ResumeLayout();
                serviceBusTreeView.EndUpdate();
            }
        }

        private void InternalWriteToLog(string message)
        {
            lock (this)
            {
                if (!string.IsNullOrEmpty(message))
                {
                    var lines = message.Split('\n');
                    var objNow = DateTime.Now;
                    var space = new string(' ', 11);

                    for (var i = 0; i < lines.Length; i++)
                    {
                        if (i == 0)
                        {
                            string line = string.Format(DateFormat,
                                                        objNow.Hour,
                                                        objNow.Minute,
                                                        objNow.Second,
                                                        lines[i]);
                            lstLog.Items.Add(line);
                        }
                        else
                        {
                            lstLog.Items.Add(space + lines[i]);
                        }
                    }
                    lstLog.SelectedIndex = lstLog.Items.Count - 1;
                    lstLog.SelectedIndex = -1;
                }
            }
        }

        private void GetServiceBusNamespacesFromConfiguration()
        {
            try
            {
                if (serviceBusHelper == null)
                {
                    return;
                }
                var hashtable = ConfigurationManager.GetSection(ServiceBusNamespaces) as Hashtable;
                if (hashtable == null || hashtable.Count == 0)
                {
                    WriteToLog(ServiceBusNamespacesNotConfigured);
                }
                serviceBusHelper.ServiceBusNamespaces = new Dictionary<string, ServiceBusNamespace>();
                if (hashtable != null)
                {
                    var e = hashtable.GetEnumerator();

                    while (e.MoveNext())
                    {
                        if (e.Key is string && e.Value is string)
                        {
                            var connectionString = e.Value as string;
                            if (string.IsNullOrEmpty(connectionString))
                            {
                                WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceIsNullOrEmpty, e.Key));
                                continue;
                            }

                            var toLower = connectionString.ToLower();
                            var parameters = connectionString.Split(';').ToDictionary(s => s.Substring(0, s.IndexOf('=')).ToLower(), s => s.Substring(s.IndexOf('=') + 1));

                            if (toLower.Contains(ConnectionStringEndpoint) &&
                                toLower.Contains(ConnectionStringSharedSecretIssuer) &&
                                toLower.Contains(ConnectionStringSharedSecretValue))
                            {
                                if (parameters.Count < 3)
                                {
                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceIsWrong, e.Key));
                                    continue;
                                }
                                var endpoint = parameters.ContainsKey(ConnectionStringEndpoint) ?
                                               parameters[ConnectionStringEndpoint] :
                                               null;

                                if (string.IsNullOrEmpty(endpoint))
                                {
                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceEndpointIsNullOrEmpty, e.Key));
                                    continue;
                                }

                                Uri uri = null;
                                try
                                {
                                    uri = new Uri(endpoint);
                                }
                                catch (Exception)
                                {
                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceEndpointUriIsInvalid, e.Key));
                                    continue;
                                }
                                var ns = uri.Host.Split('.')[0];
                                var issuerName = parameters.ContainsKey(ConnectionStringSharedSecretIssuer) ?
                                                 parameters[ConnectionStringSharedSecretIssuer] :
                                                 ConnectionStringOwner;

                                if (!parameters.ContainsKey(ConnectionStringSharedSecretValue) ||
                                    string.IsNullOrEmpty(parameters[ConnectionStringSharedSecretValue]))
                                {
                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceIssuerSecretIsNullOrEmpty, e.Key));
                                    continue;

                                }
                                var issuerSecret = parameters[ConnectionStringSharedSecretValue];
                                serviceBusHelper.ServiceBusNamespaces.Add(e.Key as string, new ServiceBusNamespace(endpoint, ns, null, issuerName, issuerSecret, uri.Scheme));
                            }
                            else
                            {
                                if (parameters.Count < 4)
                                {
                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceIsWrong, e.Key));
                                    continue;
                                }

                                var uriString = parameters.ContainsKey(ConnectionStringUri) ?
                                          parameters[ConnectionStringUri] :
                                          null;

                                if (string.IsNullOrEmpty(uriString) && !parameters.ContainsKey(ConnectionStringNameSpace))
                                {
                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceNamespaceAndUriAreNullOrEmpty, e.Key));
                                    continue;
                                }
                                
                                var ns = parameters[ConnectionStringNameSpace];

                                var servicePath = parameters.ContainsKey(ConnectionStringServicePath) ?
                                                  parameters[ConnectionStringServicePath] :
                                                  null;

                                if (!parameters.ContainsKey(ConnectionStringIssuerName))
                                {
                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceIssuerNameIsNullOrEmpty, e.Key));
                                    continue;
                                }
                                var issuerName = parameters.ContainsKey(ConnectionStringIssuerName) ?
                                                 parameters[ConnectionStringIssuerName] :
                                                 ConnectionStringOwner;

                                if (!parameters.ContainsKey(ConnectionStringIssuerSecret) || 
                                    string.IsNullOrEmpty(parameters[ConnectionStringIssuerSecret]))
                                {
                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceIssuerSecretIsNullOrEmpty, e.Key));
                                    continue;

                                }
                                var issuerSecret = parameters[ConnectionStringIssuerSecret];

                                string transportType = null;
                                if (!string.IsNullOrEmpty(uriString))
                                {
                                    try
                                    {
                                        var uri = new Uri(uriString);
                                        transportType = uri.Scheme;
                                    }
                                    catch (Exception)
                                    {
                                        WriteToLog(string.Format(CultureInfo.CurrentCulture, ServiceBusNamespaceEndpointUriIsInvalid, e.Key));
                                        continue;
                                    }
                                }
                                if (string.IsNullOrEmpty(transportType))
                                {
                                    transportType = parameters.ContainsKey(ConnectionStringTransportType) &&
                                                    !string.IsNullOrEmpty(parameters[ConnectionStringTransportType])
                                                        ? parameters[ConnectionStringTransportType]
                                                        : "sb";
                                }

                                serviceBusHelper.ServiceBusNamespaces.Add(e.Key as string, new ServiceBusNamespace(uriString, ns, servicePath, issuerName, issuerSecret, transportType));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void GetServiceBusNamespaceSettingsFromConfiguration()
        {
            if (serviceBusHelper == null)
            {
                return;
            }
            var parameter = ConfigurationManager.AppSettings[DebugFlagParameter];
            if (!string.IsNullOrEmpty(parameter))
            {
                bool debug;
                if (bool.TryParse(parameter, out debug))
                {
                    serviceBusHelper.TraceEnabled = debug;
                    RetryHelper.TraceEnabled = debug;
                }
            }
            parameter = ConfigurationManager.AppSettings[SaveMessageToFileParameter];
            if (!string.IsNullOrEmpty(parameter))
            {
                bool.TryParse(parameter, out saveMessageToFile);
            }
            parameter = ConfigurationManager.AppSettings[SavePropertiesToFileParameter];
            if (!string.IsNullOrEmpty(parameter))
            {
                bool.TryParse(parameter, out savePropertiesToFile);
            }
            var scheme = ConfigurationManager.AppSettings[SchemeParameter];
            if (!string.IsNullOrEmpty(scheme))
            {
                serviceBusHelper.Scheme = scheme;
            }
            messageText = MessageAndPropertiesHelper.ReadMessage();
            if (string.IsNullOrEmpty(messageText))
            {
                messageText = ConfigurationManager.AppSettings[MessageParameter];
                if (string.IsNullOrEmpty(messageText))
                {
                    messageText = DefaultMessageText;
                }
            }
            file = ConfigurationManager.AppSettings[FileParameter];
            if (!string.IsNullOrEmpty(file) &&
                File.Exists(file))
            {
                using (var streamReader = new StreamReader(file))
                {
                    var text = streamReader.ReadToEnd();
                    if (!string.IsNullOrEmpty(text))
                    {
                        messageText = text;
                    }
                }
            }
            label = ConfigurationManager.AppSettings[LabelParameter];
            if (string.IsNullOrEmpty(label))
            {
                label = DefaultLabel;
            }
            var retryCountValue = ConfigurationManager.AppSettings[RetryCountParameter];
            int retryCount;
            if (int.TryParse(retryCountValue, out  retryCount))
            {
                RetryHelper.RetryCount = retryCount;
            }
            var retryTimeoutValue = ConfigurationManager.AppSettings[RetryTimeoutParameter];
            int retryTimeout;
            if (int.TryParse(retryTimeoutValue, out  retryTimeout))
            {
                RetryHelper.RetryTimeout = retryTimeout;
            }
            var receiveTimeoutValue = ConfigurationManager.AppSettings[ReceiveTimeoutParameter];
            int receiveTimeoutTemp;
            if (int.TryParse(receiveTimeoutValue, out  receiveTimeoutTemp) && receiveTimeoutTemp >= 0)
            {
                receiveTimeout = receiveTimeoutTemp;
            }
            var sessionTimeoutValue = ConfigurationManager.AppSettings[SessionTimeoutParameter];
            int sessionTimeoutTemp;
            if (int.TryParse(sessionTimeoutValue, out  sessionTimeoutTemp) && sessionTimeoutTemp >= 0)
            {
                sessionTimeout = sessionTimeoutTemp;
            }
            var prefetchCountValue = ConfigurationManager.AppSettings[PrefetchCountParameter];
            int prefetchCountTemp;
            if (int.TryParse(prefetchCountValue, out  prefetchCountTemp) && prefetchCountTemp >= 0)
            {
                prefetchCount = prefetchCountTemp;
            }
            var topValue = ConfigurationManager.AppSettings[TopParameter];
            int topTemp;
            if (int.TryParse(topValue, out  topTemp) && topTemp > 0)
            {
                topCount = topTemp;
                SetTopMenuItemLabel();
            }
            var messageDeferProvider = ConfigurationManager.AppSettings[MessageDeferProviderParameter];
            if (!string.IsNullOrEmpty(messageDeferProvider))
            {
                try
                {
                    var type = Type.GetType(messageDeferProvider);
                    if (type != null &&
                        type.GetInterfaces().Contains(typeof(IMessageDeferProvider)))
                    {
                        serviceBusHelper.MessageDeferProviderType = type;
                    }
                }
                catch (Exception)
                {
                }
            }
        }

        private void SetControlSize(Control control)
        {
            var ok = false;
            if (panelMain.Controls.Count > 0)
            {
                try
                {
                    if (control == null)
                    {
                        control = panelMain.Controls[0];
                        control.SuspendDrawing();
                        ok = true;
                    }
                    var width = panelMain.Width - 4;
                    var height = panelMain.Height - 26;
                    control.Width = width < ControlMinWidth ? ControlMinWidth : width;
                    control.Height = height < ControlMinHeight ? ControlMinHeight : height;
                }
                finally
                {
                    if (ok)
                    {
                        control.ResumeDrawing();
                    }
                }
            }
        }
        #endregion

        #region Public Static Methods
        public static void StaticWriteToLog(string message)
        {
            mainForm.WriteToLog(message);
        }
        #endregion

        #region Public Properties
        public string MessageText
        {
            get
            {
                return messageText;
            }
            set
            {
                messageText = value;
            }
        }

        public string Label
        {
            get
            {
                return label;
            }
            set
            {
                label = value;
            }
        }

        public int ReceiveTimeout
        {
            get
            {
                return receiveTimeout;
            }
            set
            {
                receiveTimeout = value;
            }
        }

        public int SessionTimeout
        {
            get
            {
                return sessionTimeout;
            }
            set
            {
                sessionTimeout = value;
            }
        }

        public int PrefetchCount
        {
            get
            {
                return prefetchCount;
            }
            set
            {
                prefetchCount = value;
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Saves an entity to a file.
        /// </summary>
        /// <param name="text">The text to save.</param>
        /// <param name="fileName">The file name.</param>
        /// <returns>The file path.</returns>
        private string SaveEntityToFile(string text, string fileName)
        {
            if (string.IsNullOrEmpty(text) ||
                string.IsNullOrEmpty(fileName))
            {
                return null;
            }
            saveFileDialog.Title = SaveEntityAsTitle;
            saveFileDialog.DefaultExt = XmlExtension;
            saveFileDialog.Filter = XmlFilter;
            saveFileDialog.FileName = fileName;
            if (saveFileDialog.ShowDialog() != DialogResult.OK ||
                string.IsNullOrEmpty(saveFileDialog.FileName))
            {
                return null;
            }
            if (File.Exists(saveFileDialog.FileName))
            {
                File.Delete(saveFileDialog.FileName);
            }
            using (var writer = new StreamWriter(saveFileDialog.FileName))
            {
                writer.Write(text);
            }
            return saveFileDialog.FileName;
        }

        /// <summary>
        /// Loads an entity from a file.
        /// </summary>
        /// <param name="fileName">The input file containing entities.</param>
        /// <returns>The entity xml.</returns>
        private string LoadEntityFromFile(out string fileName)
        {
            fileName = null;
            openFileDialog.Title = OpenEntityAsTitle;
            openFileDialog.DefaultExt = XmlExtension;
            openFileDialog.Filter = XmlFilter;
            if (openFileDialog.ShowDialog() != DialogResult.OK ||
                string.IsNullOrEmpty(openFileDialog.FileName))
            {
                return null;
            }
            if (File.Exists(openFileDialog.FileName))
            {
                fileName = openFileDialog.FileName;
                using (var reader = new StreamReader(openFileDialog.FileName))
                {
                    return reader.ReadToEnd();
                }
            }
            return null;
        }

        private void DeleteVoidRelayServiceSubTree(TreeNode node)
        {
            var list = new List<TreeNode>();
            InternalDeleteVoidRelayServiceSubTree(node, list);
            foreach(var item in list)
            {
                if (item != node)
                {
                    serviceBusTreeView.Nodes.Remove(item);
                }
            }
        }

        private bool InternalDeleteVoidRelayServiceSubTree(TreeNode node, List<TreeNode> list)
        {
            if (node == null ||
                node.Tag is RelayServiceWrapper)
            {
                return false;
            }
            if (node.Nodes.Count == 0)
            {
                list.Add(node);
                return true;
            }
            var ok = node.Nodes.Cast<TreeNode>().Aggregate(true, (current, child) => InternalDeleteVoidRelayServiceSubTree(child, list) && current);
            if (ok)
            {
                list.Add(node);
                return true;
            }
            return false;
        }

        private void CreateLeafNode(Uri uri, TreeNode parentNode, string parentTitle)
        {
            var newNode = parentNode.Nodes.Add(uri.AbsoluteUri, uri.AbsoluteUri);
            WriteToLog(string.Format(LinkUriFormat, uri.AbsoluteUri));
            newNode.ImageIndex = RelayServiceUriIconIndex;
            newNode.SelectedImageIndex = RelayServiceUriIconIndex;
            newNode.Tag = new RelayServiceWrapper(parentTitle, uri);
            newNode.ContextMenuStrip = relayServiceContextMenuStrip;
        }

        private bool BuildRelayServiceSubTree(Uri uri, TreeNode parentNode, string parentTitle)
        {
            XmlReader reader = null;
            try
            {
                if (string.Compare(uri.Scheme, "http", StringComparison.OrdinalIgnoreCase) != 0 &&
                    string.Compare(uri.Scheme, "https", StringComparison.OrdinalIgnoreCase) != 0)
                {
                    CreateLeafNode(uri, parentNode, parentTitle);
                    return true;
                }
                try
                {
                    reader = XmlReader.Create(uri.AbsoluteUri);
                }
                catch (WebException)
                {
                    CreateLeafNode(uri, parentNode, parentTitle);
                    return true;
                }
                SyndicationFeed feed;
                try
                {
                    feed = SyndicationFeed.Load(reader);
                }
                catch (Exception)
                {
                    if (reader.LocalName == FaultNode)
                    {
                        CreateLeafNode(uri, parentNode, parentTitle);
                    }
                    return true;
                }

                if (feed == null ||
                    feed.Items.Count() == 0)
                {
                    return false;
                }

                var ok = true;
                foreach (var item in feed.Items)
                {
                    if (item.Title == null ||
                        string.IsNullOrEmpty(item.Title.Text))
                    {
                        continue;
                    }
                    var newNode = parentNode.Nodes.ContainsKey(item.Title.Text) ?
                                  parentNode.Nodes[item.Title.Text] :
                                  parentNode.Nodes.Add(item.Title.Text, item.Title.Text);
                    WriteToLog(string.Format(SyndicateItemFormat, item.Title.Text));
                    ok = item.Links.Aggregate(ok, (current, link) => BuildRelayServiceSubTree(link.Uri, newNode, item.Title.Text) && current);
                    newNode.ImageIndex = ok ? RelayServiceLeafIconIndex : RelayServiceNonLeafIconIndex;
                    newNode.SelectedImageIndex = newNode.ImageIndex;
                    newNode.Tag = UrlEntity;
                    newNode.ContextMenuStrip = relayFolderContextMenuStrip;
                }
                return false;
            }
            catch (WebException)
            {
            }
            catch (NotSupportedException)
            {
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return true;
        }

        private void GetEntities(EntityType entityType)
        {
            var updating = false;

            try
            {
                if (serviceBusHelper != null)
                {
                    serviceBusTreeView.SuspendDrawing();
                    serviceBusTreeView.SuspendLayout();
                    serviceBusTreeView.BeginUpdate();
                    var queueListNode = FindNode(QueueEntities, rootNode);
                    var topicListNode = FindNode(TopicEntities, rootNode);
                    var relayServiceListNode = FindNode(RelayServiceEntities, rootNode);
                    if (entityType == EntityType.All)
                    {
                        serviceBusTreeView.Nodes.Clear();
                        rootNode = serviceBusTreeView.Nodes.Add(serviceBusHelper.NamespaceUri.AbsoluteUri, serviceBusHelper.NamespaceUri.AbsoluteUri, AzureIconIndex, AzureIconIndex);
                        queueListNode = rootNode.Nodes.Add(QueueEntities, QueueEntities, QueueListIconIndex, QueueListIconIndex);
                        topicListNode = rootNode.Nodes.Add(TopicEntities, TopicEntities, TopicListIconIndex, TopicListIconIndex);
                        relayServiceListNode = rootNode.Nodes.Add(RelayServiceEntities, RelayServiceEntities, RelayServiceListIconIndex, RelayServiceListIconIndex);
                        rootNode.ContextMenuStrip = rootContextMenuStrip;
                        queueListNode.ContextMenuStrip = queuesContextMenuStrip;
                        topicListNode.ContextMenuStrip = topicsContextMenuStrip;
                        relayServiceListNode.ContextMenuStrip = relayServicesContextMenuStrip;
                    }
                    updating = true;
                    if (entityType == EntityType.All ||
                        entityType == EntityType.RelayService)
                    {
                        relayServiceListNode.Nodes.Clear();
                        BuildRelayServiceSubTree(serviceBusHelper.AtomFeedUri, relayServiceListNode, null);
                        DeleteVoidRelayServiceSubTree(relayServiceListNode);
                        if (entityType == EntityType.RelayService)
                        {
                            serviceBusTreeView.SelectedNode = relayServiceListNode;
                            HandleNodeMouseClick(relayServiceListNode);
                        }
                    }
                    if (entityType == EntityType.All ||
                        entityType == EntityType.Queue)
                    {
                        var queues = serviceBusHelper.GetQueues();
                        queueListNode.Nodes.Clear();
                        if (queues != null)
                        {
                            foreach (var queue in queues)
                            {
                                if (string.IsNullOrEmpty(queue.Path))
                                {
                                    continue;
                                }
                                CreateNode(queue.Path, queue, queueListNode, true);
                            }
                        }
                        if (entityType == EntityType.Queue)
                        {
                            serviceBusTreeView.SelectedNode = queueListNode;
                            HandleNodeMouseClick(queueListNode);
                        }
                    }
                    if (entityType == EntityType.All ||
                        entityType == EntityType.Topic)
                    {
                        var topics = serviceBusHelper.GetTopics();
                        topicListNode.Nodes.Clear();
                        if (topics != null)
                        {
                            foreach (var topic in topics)
                            {
                                if (string.IsNullOrEmpty(topic.Path))
                                {
                                    continue;
                                }
                                var entityNode = CreateNode(topic.Path, topic, topicListNode, true);
                                try
                                {
                                    var subscriptions = serviceBusHelper.GetSubscriptions(topic);
                                    if (subscriptions != null &&
                                        subscriptions.Count() > 0)
                                    {
                                        entityNode.Nodes.Clear();
                                        var subscriptionsNode = entityNode.Nodes.Add(SubscriptionEntities, SubscriptionEntities, SubscriptionListIconIndex, SubscriptionListIconIndex);
                                        subscriptionsNode.ContextMenuStrip = subscriptionsContextMenuStrip;
                                        subscriptionsNode.Tag = new SubscriptionWrapper(null, topic);
                                        foreach (var subscription in subscriptions)
                                        {
                                            var subscriptionNode = subscriptionsNode.Nodes.Add(subscription.Name, subscription.Name, SubscriptionIconIndex, SubscriptionIconIndex);
                                            subscriptionNode.ContextMenuStrip = subscriptionContextMenuStrip;
                                            subscriptionNode.Tag = new SubscriptionWrapper(subscription, topic);
                                            WriteToLog(string.Format(CultureInfo.CurrentCulture, SubscriptionRetrievedFormat, subscription.Name, topic.Path));
                                            var rules = serviceBusHelper.GetRules(subscription);
                                            if (rules != null &&
                                                rules.Count() > 0)
                                            {
                                                subscriptionNode.Nodes.Clear();
                                                var rulesNode = subscriptionNode.Nodes.Add(RuleEntities, RuleEntities, RuleListIconIndex, RuleListIconIndex);
                                                rulesNode.ContextMenuStrip = rulesContextMenuStrip;
                                                rulesNode.Tag = new RuleWrapper(null, subscription);
                                                foreach (var rule in rules)
                                                {
                                                    var ruleNode = rulesNode.Nodes.Add(rule.Name, rule.Name, RuleIconIndex, RuleIconIndex);
                                                    ruleNode.ContextMenuStrip = ruleContextMenuStrip;
                                                    ruleNode.Tag = new RuleWrapper(rule, subscription);
                                                    WriteToLog(string.Format(CultureInfo.CurrentCulture, RuleRetrievedFormat, rule.Name, subscription.Name, topic.Path));
                                                }
                                            }
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    HandleException(ex);
                                }
                            }
                        }
                        if (entityType == EntityType.Topic)
                        {
                            serviceBusTreeView.SelectedNode = topicListNode;
                            HandleNodeMouseClick(topicListNode);
                        }
                    }
                    if (queueListNode != null)
                    {
                        queueListNode.Expand();
                    }
                    if (topicListNode != null)
                    {
                        topicListNode.Expand();
                    }
                    if (relayServiceListNode != null)
                    {
                        relayServiceListNode.Expand();
                    }
                    rootNode.Expand();
                    if (entityType == EntityType.All)
                    {
                        serviceBusTreeView.SelectedNode = rootNode;
                        HandleNodeMouseClick(rootNode);
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                if (updating)
                {
                    serviceBusTreeView.ResumeDrawing();
                    serviceBusTreeView.ResumeLayout();
                    serviceBusTreeView.EndUpdate();
                    serviceBusTreeView.Refresh();
                }
            }
        }

        private void ShowQueue(QueueDescription queue, string path)
        {
            HandleQueueControl queueControl = null;

            try
            {
                panelMain.SuspendDrawing();
                panelMain.Controls.Clear();
                panelMain.BackColor = SystemColors.GradientInactiveCaption;
                queueControl = new HandleQueueControl(this, WriteToLog, serviceBusHelper, queue, path);
                queueControl.SuspendDrawing();
                queueControl.Location = new Point(1, panelLog.HeaderHeight + 1);
                panelMain.Controls.Add(queueControl);
                SetControlSize(queueControl);
                queueControl.OnCancel += MainForm_OnCancel;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                panelMain.ResumeDrawing();
                if (queueControl != null)
                {
                    queueControl.ResumeDrawing();
                }
            }
        }

        private void ShowTopic(TopicDescription topic, string path)
        {
            HandleTopicControl topicControl = null;

            try
            {
                panelMain.SuspendDrawing();
                panelMain.Controls.Clear();
                panelMain.BackColor = SystemColors.GradientInactiveCaption;
                topicControl = new HandleTopicControl(this, WriteToLog, serviceBusHelper, topic, path);
                topicControl.SuspendDrawing();
                topicControl.Location = new Point(1, panelLog.HeaderHeight + 1);
                panelMain.Controls.Add(topicControl);
                SetControlSize(topicControl);
                topicControl.OnCancel += MainForm_OnCancel;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                panelMain.ResumeDrawing();
                if (topicControl != null)
                {
                    topicControl.ResumeDrawing();
                }
            }
        }

        private void ShowSubscription(SubscriptionWrapper wrapper)
        {
            HandleSubscriptionControl subscriptionControl = null;

            try
            {
                panelMain.SuspendDrawing();
                panelMain.Controls.Clear();
                panelMain.BackColor = SystemColors.GradientInactiveCaption;
                subscriptionControl = new HandleSubscriptionControl(this, WriteToLog, serviceBusHelper, wrapper);
                subscriptionControl.SuspendDrawing();
                subscriptionControl.Location = new Point(1, panelLog.HeaderHeight + 1);
                panelMain.Controls.Add(subscriptionControl);
                SetControlSize(subscriptionControl);
                subscriptionControl.OnCancel += MainForm_OnCancel;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                panelMain.ResumeDrawing();
                if (subscriptionControl != null)
                {
                    subscriptionControl.ResumeDrawing();
                }
            }
        }

        private void ShowRule(RuleWrapper wrapper, bool? isFirstRule)
        {
            HandleRuleControl ruleControl = null;

            try
            {
                panelMain.SuspendDrawing();
                panelMain.Controls.Clear();
                panelMain.BackColor = SystemColors.GradientInactiveCaption;
                ruleControl = new HandleRuleControl(this, WriteToLog, serviceBusHelper, wrapper, isFirstRule);
                ruleControl.SuspendDrawing();
                ruleControl.Location = new Point(1, panelLog.HeaderHeight + 1);
                panelMain.Controls.Add(ruleControl);
                SetControlSize(ruleControl);
                ruleControl.OnCancel += MainForm_OnCancel;
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                panelMain.ResumeDrawing();
                if (ruleControl != null)
                {
                    ruleControl.ResumeDrawing();
                }
            }
        }

        private void TestQueue(QueueDescription queueDescription, bool sdi)
        {
            if (sdi)
            {
                TestQueueControl queueControl = null;

                try
                {
                    panelMain.SuspendDrawing();
                    panelMain.Controls.Clear();
                    panelMain.BackColor = SystemColors.GradientInactiveCaption;
                    queueControl = new TestQueueControl(this,
                                                        WriteToLog,
                                                        serviceBusHelper,
                                                        queueDescription);
                    queueControl.SuspendDrawing();
                    queueControl.Location = new Point(1, panelLog.HeaderHeight + 1);
                    panelMain.Controls.Add(queueControl);
                    SetControlSize(queueControl);
                    queueControl.OnCancel += MainForm_OnCancel;
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
                finally
                {
                    panelMain.ResumeDrawing();
                    if (queueControl != null)
                    {
                        queueControl.ResumeDrawing();
                    }
                }
            }
            else
            {
                var form = new ContainerForm(serviceBusHelper, this, FormTypeEnum.Test, queueDescription);
                form.Show();
            }
        }

        private void TestTopic(TopicDescription topicDescription, List<SubscriptionDescription> subscriptionList, bool sdi)
        {
            if (sdi)
            {
                TestTopicControl topicControl = null;

                try
                {
                    panelMain.SuspendDrawing();
                    panelMain.Controls.Clear();
                    panelMain.BackColor = SystemColors.GradientInactiveCaption;
                    topicControl = new TestTopicControl(this,
                                                        WriteToLog, 
                                                        serviceBusHelper,
                                                        topicDescription,
                                                        subscriptionList);
                    topicControl.SuspendDrawing();
                    topicControl.Location = new Point(1, panelLog.HeaderHeight + 1);
                    panelMain.Controls.Add(topicControl);
                    SetControlSize(topicControl);
                    topicControl.OnCancel += MainForm_OnCancel;
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
                finally
                {
                    panelMain.ResumeDrawing();
                    if (topicControl != null)
                    {
                        topicControl.ResumeDrawing();
                    }
                }
            }
            else
            {
                var form = new ContainerForm(serviceBusHelper, this, FormTypeEnum.Test, topicDescription, subscriptionList);
                form.Show();
            }
        }

        private void TestSubscription(SubscriptionWrapper subscriptionWrapper, bool sdi)
        {
            if (sdi)
            {
                TestSubscriptionControl subscriptionControl = null;

                try
                {
                    panelMain.SuspendDrawing();
                    panelMain.Controls.Clear();
                    panelMain.BackColor = SystemColors.GradientInactiveCaption;
                    subscriptionControl = new TestSubscriptionControl(this, WriteToLog, serviceBusHelper, subscriptionWrapper);
                    subscriptionControl.SuspendDrawing();
                    subscriptionControl.Location = new Point(1, panelLog.HeaderHeight + 1);
                    panelMain.Controls.Add(subscriptionControl);
                    SetControlSize(subscriptionControl);
                    subscriptionControl.OnCancel += MainForm_OnCancel;
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
                finally
                {
                    panelMain.ResumeDrawing();
                    if (subscriptionControl != null)
                    {
                        subscriptionControl.ResumeDrawing();
                    }
                }
            }
            else
            {
                var form = new ContainerForm(serviceBusHelper, this, subscriptionWrapper);
                form.Show();
            }
        }

        private void TestRelayService(RelayServiceWrapper relayServiceWrapper, bool sdi)
        {
            if (sdi)
            {
                TestRelayServiceControl relayServiceControl = null;

                try
                {
                    panelMain.SuspendDrawing();
                    panelMain.Controls.Clear();
                    panelMain.BackColor = SystemColors.GradientInactiveCaption;
                    relayServiceControl = new TestRelayServiceControl(this, WriteToLog, relayServiceWrapper, serviceBusHelper);
                    relayServiceControl.SuspendDrawing();
                    relayServiceControl.Location = new Point(1, panelLog.HeaderHeight + 1);
                    panelMain.Controls.Add(relayServiceControl);
                    SetControlSize(relayServiceControl);
                    relayServiceControl.OnCancel += MainForm_OnCancel;
                }
                catch (Exception ex)
                {
                    HandleException(ex);
                }
                finally
                {
                    panelMain.ResumeDrawing();
                    if (relayServiceControl != null)
                    {
                        relayServiceControl.ResumeDrawing();
                    }
                }
            }
            else
            {
                
            }
        }

        private void ExportEntities(List<EntityDescription> list, string entityName, string entityType)
        {
            var xml = serviceBusHelper.ExportEntities(list);
            var path = entityType == null ?
                       CreateFileName(string.Format(EntitiesFileNameFormat, serviceBusHelper.Namespace, entityName)) :
                       CreateFileName(string.Format(EntityFileNameFormat, serviceBusHelper.Namespace, entityName, entityType));
            WriteToLog(string.Format(EntitiesExported, SaveEntityToFile(xml, path)));
        }

        private void copyEntityUrl_Click(object sender, EventArgs e)
        {
            if (sender != null &&
                sender is ToolStripMenuItem &&
                serviceBusHelper != null)
            {
                var toolStripMenuItem = sender as ToolStripMenuItem;
                Uri uri = null;
                switch (toolStripMenuItem.Name)
                {
                    case "copyQueueUrlMenuItem":
                        if (serviceBusTreeView.SelectedNode != null &&
                            serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                        {
                            uri = serviceBusHelper.GetQueueUri(((QueueDescription)serviceBusTreeView.SelectedNode.Tag).Path);
                        }
                        break;
                    case "copyQueueDeadletterQueueUrlMenuItem":
                        if (serviceBusTreeView.SelectedNode != null &&
                            serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                        {
                            uri = serviceBusHelper.GetQueueDeadLetterQueueUri(((QueueDescription)serviceBusTreeView.SelectedNode.Tag).Path);
                        }
                        break;
                    case "copyTopicUrlMenuItem":
                        if (serviceBusTreeView.SelectedNode != null &&
                            serviceBusTreeView.SelectedNode.Tag is TopicDescription)
                        {
                            uri = serviceBusHelper.GetTopicUri(((TopicDescription)serviceBusTreeView.SelectedNode.Tag).Path);
                        }
                        break;
                    case "copySubscriptionUrlMenuItem":
                        if (serviceBusTreeView.SelectedNode != null &&
                            serviceBusTreeView.SelectedNode.Tag is SubscriptionWrapper)
                        {
                            var wrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                            if (wrapper.SubscriptionDescription != null)
                            {
                                uri =
                                    serviceBusHelper.GetSubscriptionUri(wrapper.SubscriptionDescription.TopicPath,
                                                                        wrapper.SubscriptionDescription.Name);
                            }
                        }
                        break;
                    case "copySubscriptionDeadletterSubscriptionUrlMenuItem":
                        if (serviceBusTreeView.SelectedNode != null &&
                            serviceBusTreeView.SelectedNode.Tag is SubscriptionWrapper)
                        {
                            var wrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                            if (wrapper.SubscriptionDescription != null)
                            {
                                uri =
                                    serviceBusHelper.GetSubscriptionDeadLetterQueueUri(wrapper.SubscriptionDescription.TopicPath,
                                                                                       wrapper.SubscriptionDescription.Name);
                            }
                        }
                        break;
                    case "copyRelayServiceUrlMenuItem":
                        if (serviceBusTreeView.SelectedNode != null &&
                            serviceBusTreeView.SelectedNode.Tag is RelayServiceWrapper)
                        {
                            var wrapper = serviceBusTreeView.SelectedNode.Tag as RelayServiceWrapper;
                            if (wrapper.Uri != null)
                            {
                                uri = wrapper.Uri;
                            }
                        }
                        break;
                }
                if (uri != null &&
                    !string.IsNullOrEmpty(uri.AbsoluteUri))
                {
                    var url = uri.AbsoluteUri.Substring(0, uri.AbsoluteUri.Length - 1);
                    var form = new ClipboardForm(url);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Clipboard.SetText(url);
                    }
                }
            }
        }
        
        private List<ToolStripItem> CloneItems(ToolStripItemCollection collection)
        {
            var list = new List<ToolStripItem>();
            if (collection != null)
            {
                var enumerable = collection.Cast<ToolStripItem>();
                foreach (var toolStripItem in enumerable)
                {
                    if (toolStripItem is ToolStripSeparator)
                    {
                        list.Add(new ToolStripSeparator());
                    }
                    else
                    {
                        var item = new ToolStripMenuItem
                                        {
                                            Name = toolStripItem.Name,
                                            Size = toolStripItem.Size,
                                            Text = toolStripItem.Text,
                                            ToolTipText = toolStripItem.ToolTipText
                                        };
                        var events = (EventHandlerList)eventsPropertyInfo.GetValue(toolStripItem, null);
                        var secret = eventClickFieldInfo.GetValue(null); 
                        var handlers = events[secret];
                        events = (EventHandlerList)eventsPropertyInfo.GetValue(item, null);
                        events.AddHandler(secret, handlers); 
                        list.Add(item);
                    }
                }
            }
            return list;
        }

        private void AddImportAndSeparatorMenuItems(List<ToolStripItem> list)
        {
            if (list == null)
            {
                return;
            }
            if (list.Count > 0)
            {
                list.Add(new ToolStripSeparator());
            }
            var item = new ToolStripMenuItem
                            {
                                Name = ImportToolStripMenuItemName,
                                Size = new Size(154, 22),
                                Text = ImportToolStripMenuItemText,
                                ToolTipText = ImportToolStripMenuItemToolTipText
                            };

            item.Click += importEntity_Click;
            list.Add(item);
        }

        private static string CreateFileName(string text)
        {
            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return string.Empty;
            }
            // Return char and concat substring.
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(text).Replace(' ', '_').Replace('/', '_');
        }

        private void DeleteNode(string path, TreeNode node)
        {
            if (string.IsNullOrEmpty(path) || node == null)
            {
                return;
            }
            var segments = path.Split('/');
            if (segments.Length > 1)
            {
                var index = path.IndexOf('/');
                if (index >= 0 &&
                    !string.IsNullOrEmpty(segments[0]) &&
                    node.Nodes.ContainsKey(segments[0]))
                {
                    var entityNode = node.Nodes[segments[0]];
                    DeleteNode(path.Substring(index + 1), entityNode);
                    if (entityNode.Nodes.Count == 0)
                    {
                        node.Nodes.RemoveByKey(segments[0]);
                    }
                }
            }
            else
            {
                if (node.Nodes.ContainsKey(path))
                {
                    node.Nodes.RemoveByKey(path);
                }
            }
        }

        private TreeNode FindNode(string path, TreeNode node)
        {
            if (string.IsNullOrEmpty(path) || node == null)
            {
                return null;
            }
            var segments = path.Split('/');
            if (segments.Length > 1)
            {
                var index = path.IndexOf('/');
                if (index >= 0 &&
                    !string.IsNullOrEmpty(segments[0]) &&
                    node.Nodes.ContainsKey(segments[0]))
                {
                    var entityNode = node.Nodes[segments[0]];
                    return FindNode(path.Substring(index + 1), entityNode);
                }
            }
            else
            {
                if (node.Nodes.ContainsKey(path))
                {
                    return node.Nodes[path];
                }
            }
            return null;
        }

        private TreeNode CreateNode(string path, 
                                    object tag, 
                                    TreeNode node,
                                    bool log)
        {
            if (string.IsNullOrEmpty(path) || node == null)
            {
                return null;
            }
            var segments = path.Split('/');
            var entityNode = node;
            var currentUrl = serviceBusHelper.NamespaceUri.AbsoluteUri;
            for (var i = 0; i < segments.Length; i++)
            {
                if (i < segments.Length - 1)
                {
                    currentUrl = currentUrl[currentUrl.Length - 1] == '/' ?
                                 currentUrl + segments[i] :
                                 string.Format(UrlSegmentFormat, currentUrl, segments[i]);
                }
                if (entityNode.Nodes.ContainsKey(segments[i]))
                {
                    entityNode = entityNode.Nodes[segments[i]];
                }
                else
                {
                    if (i < segments.Length - 1)
                    {
                        entityNode = entityNode.Nodes.Add(segments[i],
                                                          segments[i],
                                                          UrlSegmentIconIndex,
                                                          UrlSegmentIconIndex);
                        var entityType = EntityType.Queue;
                        if (tag is QueueDescription)
                        {
                            entityNode.ContextMenuStrip = queueFolderContextMenuStrip;
                        }
                        if (tag is TopicDescription)
                        {
                            entityNode.ContextMenuStrip = topicFolderContextMenuStrip;
                            entityType = EntityType.Topic;
                        }
                        entityNode.Tag = new UrlSegmentWrapper(entityType, new Uri(currentUrl));
                    }
                    else
                    {
                        if (tag is QueueDescription)
                        {
                            entityNode = entityNode.Nodes.Add(segments[i],
                                                              segments[i],
                                                              QueueIconIndex,
                                                              QueueIconIndex);
                            entityNode.ContextMenuStrip = queueContextMenuStrip;
                            entityNode.Tag = tag;
                            var queue = tag as QueueDescription;
                            if (log)
                            {
                                WriteToLog(string.Format(CultureInfo.CurrentCulture, QueueRetrievedFormat, queue.Path));
                            }
                            return entityNode;
                        }
                        if (tag is TopicDescription)
                        {
                            entityNode = entityNode.Nodes.Add(segments[i],
                                                              segments[i],
                                                              TopicIconIndex,
                                                              TopicIconIndex);
                            entityNode.ContextMenuStrip = topicContextMenuStrip;
                            entityNode.Tag = tag;
                            var topic = tag as TopicDescription;
                            if (log)
                            {
                                WriteToLog(string.Format(CultureInfo.CurrentCulture, TopicRetrievedFormat, topic.Path));
                            }
                            return entityNode;
                        }
                    }
                }
            }
            return null;
        }

        private void GetQueueList(ICollection<string> list, TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            if (node.Tag is QueueDescription)
            {
                list.Add(((QueueDescription)node.Tag).Path);
                return;
            }
            for (var i = 0; i < node.Nodes.Count; i++)
            {
                GetQueueList(list, node.Nodes[i]);
            }
        }

        private void GetQueueList(ICollection<EntityDescription> list, TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            if (node.Tag is QueueDescription)
            {
                list.Add((QueueDescription)node.Tag);
                return;
            }
            for (var i = 0; i < node.Nodes.Count; i++)
            {
                GetQueueList(list, node.Nodes[i]);
            }
        }

        private void GetTopicList(ICollection<string> list, TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            if (node.Tag is TopicDescription)
            {
                list.Add(((TopicDescription)node.Tag).Path);
                return;
            }
            for (var i = 0; i < node.Nodes.Count; i++)
            {
                GetTopicList(list, node.Nodes[i]);
            }
        }

        private void GetTopicList(ICollection<EntityDescription> list, TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            if (node.Tag is TopicDescription)
            {
                list.Add((TopicDescription)node.Tag);
                return;
            }
            for (var i = 0; i < node.Nodes.Count; i++)
            {
                GetTopicList(list, node.Nodes[i]);
            }
        }

        private string FormatAbsolutePathForEdit(Uri uri)
        {
            if (uri == null)
            {
                return string.Empty;
            }
            var url = uri.AbsolutePath;
            if (url[0] == '/')
            {
                if (url.Length == 1)
                {
                    return string.Empty;
                }
                else
                {
                    url = url.Substring(1);
                }
            }
            if (url[url.Length - 1] != '/')
            {
                url += '/';
            }
            return url;
        }

        private string FormatAbsolutePathForExport(Uri uri)
        {
            if (uri == null ||
                string.IsNullOrEmpty(uri.AbsolutePath))
            {
                return string.Empty;
            }
            var url = uri.AbsolutePath;
            if (url[0] == '/')
            {
                if (url.Length == 1)
                {
                    return string.Empty;
                }
                else
                {
                    url = url.Substring(1);
                }
            }
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(url.Split('/').Aggregate((left, right) => left + '_' + right));
        }

        private void setDefaultLayouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainSplitContainer.SplitterDistance = mainSplitterDistance;
            splitContainer.SplitterDistance = splitterContainerDistance;
            lstLog.Font = new Font(lstLog.Font.FontFamily, logFontSize);
            serviceBusTreeView.Font = new Font(serviceBusTreeView.Font.FontFamily, treeViewFontSize);
        }

        private void receiveMessages_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                if (serviceBusTreeView.SelectedNode != null)
                {
                    EntityDescription entityDescription = null;
                    // Queue Node
                    if (serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                    {
                        entityDescription = serviceBusTreeView.SelectedNode.Tag as QueueDescription;
                    }

                    // Subscription Node
                    if (serviceBusTreeView.SelectedNode.Tag is SubscriptionWrapper)
                    {
                        var wrapper = serviceBusTreeView.SelectedNode.Tag as SubscriptionWrapper;
                        if (wrapper.SubscriptionDescription != null)
                        {
                            entityDescription = wrapper.SubscriptionDescription;
                        }
                    }
                    if (entityDescription != null)
                    {
                        cancellationTokenSource = new CancellationTokenSource();
                        var text = ((ToolStripMenuItem) sender).Text;
                        if (string.Compare(text, queueReceiveAllMessagesMenuItem.Text, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            serviceBusHelper.ReceiveMessages(entityDescription, null, true, false, TimeSpan.FromSeconds(receiveTimeout), TimeSpan.FromSeconds(sessionTimeout), cancellationTokenSource);
                            return;
                        }
                        if (string.Compare(text, queueReceiveTopMessagesMenuItem.Text, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            serviceBusHelper.ReceiveMessages(entityDescription, topCount, true, false, TimeSpan.FromSeconds(receiveTimeout), TimeSpan.FromSeconds(sessionTimeout), cancellationTokenSource);
                            return;
                        }
                        if (string.Compare(text, queuePeekAllMessagesMenuItem.Text, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            serviceBusHelper.ReceiveMessages(entityDescription, null, false, false, TimeSpan.FromSeconds(receiveTimeout), TimeSpan.FromSeconds(sessionTimeout), cancellationTokenSource);
                            return;
                        }
                        if (string.Compare(text, queuePeekTopMessagesMenuItem.Text, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            serviceBusHelper.ReceiveMessages(entityDescription, topCount, false, false, TimeSpan.FromSeconds(receiveTimeout), TimeSpan.FromSeconds(sessionTimeout), cancellationTokenSource);
                            return;
                        }
                        if (string.Compare(text, queueReceiveDeadletterQueueMessagesMenuItem.Text, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            serviceBusHelper.ReceiveMessages(entityDescription, null, true, false, TimeSpan.FromSeconds(receiveTimeout), TimeSpan.FromSeconds(sessionTimeout), cancellationTokenSource);
                            return;
                        }
                        if (string.Compare(text, queuePeekDeadletterQueueMessagesMenuItem.Text, StringComparison.OrdinalIgnoreCase) == 0)
                        {
                            serviceBusHelper.ReceiveMessages(entityDescription, null, true, false, TimeSpan.FromSeconds(receiveTimeout), TimeSpan.FromSeconds(sessionTimeout), cancellationTokenSource);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void sendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceBusTreeView.SelectedNode != null)
                {
                    ContainerForm form = null;

                    // Queue Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is QueueDescription)
                    {
                        var queueDescription = serviceBusTreeView.SelectedNode.Tag as QueueDescription;
                        form = new ContainerForm(serviceBusHelper, this, FormTypeEnum.Send, queueDescription);
                    }

                    // Topic Node
                    if (serviceBusTreeView.SelectedNode.Tag != null &&
                        serviceBusTreeView.SelectedNode.Tag is TopicDescription)
                    {
                        var topicDescription = serviceBusTreeView.SelectedNode.Tag as TopicDescription;
                        var subscriptionList = new List<SubscriptionDescription>();
                        if (serviceBusTreeView.SelectedNode.Nodes.ContainsKey(SubscriptionEntities))
                        {
                            var subscriptionsNode = serviceBusTreeView.SelectedNode.Nodes[SubscriptionEntities];
                            if (subscriptionsNode != null &&
                                subscriptionsNode.Nodes.Count > 0)
                            {
                                for (var i = 0; i < subscriptionsNode.Nodes.Count; i++)
                                {
                                    var wrapper = subscriptionsNode.Nodes[i].Tag as SubscriptionWrapper;
                                    if (wrapper != null &&
                                        wrapper.SubscriptionDescription != null)
                                    {
                                        subscriptionList.Add(wrapper.SubscriptionDescription);
                                    }
                                }
                            }
                        }

                        form = new ContainerForm(serviceBusHelper, this, FormTypeEnum.Send, topicDescription, subscriptionList);
                    }

                    if (form != null)
                    {
                        form.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void SetTopMenuItemLabel()
        {
            queueReceiveTopMessagesMenuItem.Text = string.Format(CultureInfo.CurrentCulture, ReceiveTopMessagesMenuItem, topCount);
            subReceiveTopMessagesMenuItem.Text = string.Format(CultureInfo.CurrentCulture, ReceiveTopMessagesMenuItem, topCount);
            queuePeekTopMessagesMenuItem.Text = string.Format(CultureInfo.CurrentCulture, PeekTopMessagesMenuItem, topCount);
            subPeekTopMessagesMenuItem.Text = string.Format(CultureInfo.CurrentCulture, PeekTopMessagesMenuItem, topCount);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
            }
            if (saveMessageToFile)
            {
                MessageAndPropertiesHelper.WriteMessage(messageText);
            }
            if (savePropertiesToFile)
            {
                MessageAndPropertiesHelper.WriteProperties();
            }
        }
        #endregion
    }

    public enum EntityType
    {
        All,
        Queue,
        Topic,
        Subscription,
        Rule,
        RelayService
    }

    public enum DirectionType
    {
        Send,
        Receive
    }
}