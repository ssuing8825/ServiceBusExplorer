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
using System.Windows.Forms;
using System.Drawing;
#endregion

namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    public partial class DeleteForm : Form
    {
        #region Private Constants
        //***************************
        // Message
        //***************************
        private const string MessageFormat = "The [{0}] {1} will be permanently deleted.";
        private const string Unknown = "Unknown";
        #endregion

        #region Public Constructor
        public DeleteForm(string message)
        {
            InitializeComponent();
            lblMessage.Text = string.Format(message);
            Width = lblMessage.Width + 72;
        }

        public DeleteForm(string entityName, string entityType)
        {
            InitializeComponent();
            lblMessage.Text = string.Format(MessageFormat,
                                            entityName ?? Unknown,
                                            entityType ?? Unknown);
            Width = lblMessage.Width + 72;
        }
        #endregion

        #region Event Handlers
        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
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
