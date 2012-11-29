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



#endregion

using Microsoft.ServiceBus;

namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    /// <summary>
    /// This class represents a service bus namespace address and authentication credentials
    /// </summary>
    public class ServiceBusNamespace
    {
        #region Public Constructors
        /// <summary>
        /// Initializes a new instance of the ServiceBusHelper class.
        /// </summary>
        public ServiceBusNamespace()
        {
            Uri = default(string);
            Namespace = default(string);
            IssuerName = default(string);
            IssuerSecret = default(string);
            ServicePath = default(string);
        }

        /// <summary>
        /// Initializes a new instance of the ServiceBusNamespace class.
        /// </summary>
        /// <param name="uri">The full address of the service bus namespace.</param>
        /// <param name="ns">The service bus namespace.</param>
        /// <param name="issuerName">The issuer name of the shared secret credentials.</param>
        /// <param name="issuerSecret">The issuer secret of the shared secret credentials.</param>
        /// <param name="servicePath">The service path that follows the host name section of the URI.</param>
        /// <param name="transportType">The transport type to use to access the namespace.</param>
        public ServiceBusNamespace(string uri,
                                   string ns,
                                   string servicePath,
                                   string issuerName,
                                   string issuerSecret,
                                   string transportType)
        {
            Uri = uri;
            if (string.IsNullOrEmpty(uri))
            {
                Uri = ServiceBusEnvironment.CreateServiceUri(transportType, ns, servicePath).ToString();
            }
            Namespace = ns;
            IssuerName = issuerName;
            IssuerSecret = issuerSecret;
            ServicePath = servicePath;
            TransportType = transportType;
        }
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets or sets the full address of the service bus namespace.
        /// </summary>
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the service bus namespace.
        /// </summary>
        public string Namespace { get; set; }

        /// <summary>
        /// Gets or sets the issuer name of the shared secret credentials.
        /// </summary>
        public string IssuerName { get; set; }

        /// <summary>
        /// Gets or sets the issuer secret of the shared secret credentials.
        /// </summary>
        public string IssuerSecret { get; set; }
        /// <summary>
        /// Gets or sets the service path that follows the host name section of the URI.
        /// </summary>
        public string ServicePath { get; set; }
        /// <summary>
        /// Gets or sets the transport type to use to access the namespace.
        /// </summary>
        public string TransportType { get; set; }
        #endregion
    }
}
