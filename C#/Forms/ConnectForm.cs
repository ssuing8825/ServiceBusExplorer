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
using System.Drawing;
using System.Linq;
using System.Windows.Forms; 
#endregion

namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    public partial class ConnectForm : Form
    {
        #region Private Constants
        private const string SelectServiceBusNamespace = "Select a service bus namespace...";
        #endregion

        #region Private Fields
        private readonly ServiceBusHelper serviceBusHelper;
        #endregion

        #region Public Constructor
        public ConnectForm(ServiceBusHelper serviceBusHelper)
        {
            InitializeComponent();
            this.serviceBusHelper = serviceBusHelper;
            cboServiceBusNamespace.Items.Add(SelectServiceBusNamespace);
            if (serviceBusHelper.ServiceBusNamespaces != null)
            {
                cboServiceBusNamespace.Items.AddRange(serviceBusHelper.ServiceBusNamespaces.Keys.ToArray());
            }
            cboServiceBusNamespace.SelectedIndex = 0;
            btnOk.Enabled = false;
        }
        #endregion

        #region Public Properties
        public string Uri { get; private set; }
        public string Namespace { get; private set; }
        public string ServicePath { get; private set; }
        public string IssuerName { get; private set; }
        public string IssuerSecret { get; private set; }
        #endregion

        #region Event Handlers
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Uri = txtUri.Text;
            Namespace = txtNamespace.Text;
            ServicePath = txtServicePath.Text;
            IssuerName = txtIssuerName.Text;
            IssuerSecret = txtIssuerSecret.Text;
            DialogResult = DialogResult.OK;
        }

        private void validation_TextChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = (!string.IsNullOrEmpty(txtUri.Text) ||
                            !string.IsNullOrEmpty(txtNamespace.Text)) &&
                            !string.IsNullOrEmpty(txtIssuerName.Text) &&
                            !string.IsNullOrEmpty(txtIssuerSecret.Text);
        }

        private void cboServiceBusNamespace_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboServiceBusNamespace.SelectedIndex != 0)
            {
                var ns = serviceBusHelper.ServiceBusNamespaces[cboServiceBusNamespace.Text];
                if (ns != null)
                {
                    txtUri.Text = ns.Uri;
                    txtNamespace.Text = ns.Namespace;
                    txtServicePath.Text = ns.ServicePath;
                    txtIssuerName.Text = ns.IssuerName;
                    txtIssuerSecret.Text = ns.IssuerSecret;
                }
            }
        }

        private void ConnectForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == '\r';
            if (e.Handled)
            {
                btnOk_Click(sender, null);
            }
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            if (sender != null && sender is Control)
            {
                ((Control)sender).ForeColor = Color.White;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            if (sender != null && sender is Control)
            {
                ((Control)sender).ForeColor = SystemColors.ControlText;
            }
        }
        #endregion
    }
}
