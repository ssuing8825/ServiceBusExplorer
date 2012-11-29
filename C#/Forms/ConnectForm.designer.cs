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

namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    partial class ConnectForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        #region Private Fields
        private System.ComponentModel.IContainer components = null;
        #endregion

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectForm));
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grouperServiceBusNamespaceSettings = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.lblUri = new System.Windows.Forms.Label();
            this.txtServicePath = new System.Windows.Forms.TextBox();
            this.lblPath = new System.Windows.Forms.Label();
            this.txtIssuerSecret = new System.Windows.Forms.TextBox();
            this.lblIssuerSecret = new System.Windows.Forms.Label();
            this.txtIssuerName = new System.Windows.Forms.TextBox();
            this.lblIssuerName = new System.Windows.Forms.Label();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.grouperServiceBusNamespaces = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.cboServiceBusNamespace = new System.Windows.Forms.ComboBox();
            this.grouperServiceBusNamespaceSettings.SuspendLayout();
            this.grouperServiceBusNamespaces.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnOk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(232, 388);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(72, 24);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(312, 388);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 24);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // grouperServiceBusNamespaceSettings
            // 
            this.grouperServiceBusNamespaceSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperServiceBusNamespaceSettings.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperServiceBusNamespaceSettings.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperServiceBusNamespaceSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperServiceBusNamespaceSettings.BorderThickness = 1F;
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.txtUri);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.lblUri);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.txtServicePath);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.lblPath);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.txtIssuerSecret);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.lblIssuerSecret);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.txtIssuerName);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.lblIssuerName);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.txtNamespace);
            this.grouperServiceBusNamespaceSettings.Controls.Add(this.lblNamespace);
            this.grouperServiceBusNamespaceSettings.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperServiceBusNamespaceSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperServiceBusNamespaceSettings.ForeColor = System.Drawing.Color.White;
            this.grouperServiceBusNamespaceSettings.GroupImage = null;
            this.grouperServiceBusNamespaceSettings.GroupTitle = "Connection Settings";
            this.grouperServiceBusNamespaceSettings.Location = new System.Drawing.Point(16, 96);
            this.grouperServiceBusNamespaceSettings.Name = "grouperServiceBusNamespaceSettings";
            this.grouperServiceBusNamespaceSettings.Padding = new System.Windows.Forms.Padding(20);
            this.grouperServiceBusNamespaceSettings.PaintGroupBox = true;
            this.grouperServiceBusNamespaceSettings.RoundCorners = 4;
            this.grouperServiceBusNamespaceSettings.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperServiceBusNamespaceSettings.ShadowControl = false;
            this.grouperServiceBusNamespaceSettings.ShadowThickness = 1;
            this.grouperServiceBusNamespaceSettings.Size = new System.Drawing.Size(368, 280);
            this.grouperServiceBusNamespaceSettings.TabIndex = 33;
            // 
            // txtUri
            // 
            this.txtUri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUri.Location = new System.Drawing.Point(16, 48);
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(336, 20);
            this.txtUri.TabIndex = 0;
            this.txtUri.TextChanged += new System.EventHandler(this.validation_TextChanged);
            // 
            // lblUri
            // 
            this.lblUri.AutoSize = true;
            this.lblUri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUri.Location = new System.Drawing.Point(16, 32);
            this.lblUri.Name = "lblUri";
            this.lblUri.Size = new System.Drawing.Size(108, 13);
            this.lblUri.TabIndex = 43;
            this.lblUri.Text = "URI or Server FQDN:";
            // 
            // txtServicePath
            // 
            this.txtServicePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtServicePath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtServicePath.Location = new System.Drawing.Point(16, 144);
            this.txtServicePath.Name = "txtServicePath";
            this.txtServicePath.Size = new System.Drawing.Size(336, 20);
            this.txtServicePath.TabIndex = 2;
            this.txtServicePath.Text = "Path";
            this.txtServicePath.TextChanged += new System.EventHandler(this.validation_TextChanged);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPath.Location = new System.Drawing.Point(16, 128);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(32, 13);
            this.lblPath.TabIndex = 41;
            this.lblPath.Text = "Path:";
            // 
            // txtIssuerSecret
            // 
            this.txtIssuerSecret.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIssuerSecret.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIssuerSecret.Location = new System.Drawing.Point(16, 240);
            this.txtIssuerSecret.Name = "txtIssuerSecret";
            this.txtIssuerSecret.PasswordChar = '*';
            this.txtIssuerSecret.Size = new System.Drawing.Size(336, 20);
            this.txtIssuerSecret.TabIndex = 4;
            this.txtIssuerSecret.Text = "None";
            this.txtIssuerSecret.TextChanged += new System.EventHandler(this.validation_TextChanged);
            // 
            // lblIssuerSecret
            // 
            this.lblIssuerSecret.AutoSize = true;
            this.lblIssuerSecret.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIssuerSecret.Location = new System.Drawing.Point(16, 224);
            this.lblIssuerSecret.Name = "lblIssuerSecret";
            this.lblIssuerSecret.Size = new System.Drawing.Size(72, 13);
            this.lblIssuerSecret.TabIndex = 40;
            this.lblIssuerSecret.Text = "Issuer Secret:";
            // 
            // txtIssuerName
            // 
            this.txtIssuerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIssuerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIssuerName.Location = new System.Drawing.Point(16, 192);
            this.txtIssuerName.Name = "txtIssuerName";
            this.txtIssuerName.Size = new System.Drawing.Size(336, 20);
            this.txtIssuerName.TabIndex = 3;
            this.txtIssuerName.Text = "None";
            this.txtIssuerName.TextChanged += new System.EventHandler(this.validation_TextChanged);
            // 
            // lblIssuerName
            // 
            this.lblIssuerName.AutoSize = true;
            this.lblIssuerName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIssuerName.Location = new System.Drawing.Point(16, 176);
            this.lblIssuerName.Name = "lblIssuerName";
            this.lblIssuerName.Size = new System.Drawing.Size(69, 13);
            this.lblIssuerName.TabIndex = 39;
            this.lblIssuerName.Text = "Issuer Name:";
            // 
            // txtNamespace
            // 
            this.txtNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNamespace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNamespace.Location = new System.Drawing.Point(16, 96);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(336, 20);
            this.txtNamespace.TabIndex = 1;
            this.txtNamespace.Text = "ServiceBusDefaultNamespace";
            this.txtNamespace.TextChanged += new System.EventHandler(this.validation_TextChanged);
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNamespace.Location = new System.Drawing.Point(16, 80);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(67, 13);
            this.lblNamespace.TabIndex = 38;
            this.lblNamespace.Text = "Namespace:";
            // 
            // grouperServiceBusNamespaces
            // 
            this.grouperServiceBusNamespaces.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperServiceBusNamespaces.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperServiceBusNamespaces.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperServiceBusNamespaces.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperServiceBusNamespaces.BorderThickness = 1F;
            this.grouperServiceBusNamespaces.Controls.Add(this.cboServiceBusNamespace);
            this.grouperServiceBusNamespaces.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperServiceBusNamespaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperServiceBusNamespaces.ForeColor = System.Drawing.Color.White;
            this.grouperServiceBusNamespaces.GroupImage = null;
            this.grouperServiceBusNamespaces.GroupTitle = "Service Bus Namespaces";
            this.grouperServiceBusNamespaces.Location = new System.Drawing.Point(16, 8);
            this.grouperServiceBusNamespaces.Name = "grouperServiceBusNamespaces";
            this.grouperServiceBusNamespaces.Padding = new System.Windows.Forms.Padding(20);
            this.grouperServiceBusNamespaces.PaintGroupBox = true;
            this.grouperServiceBusNamespaces.RoundCorners = 4;
            this.grouperServiceBusNamespaces.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperServiceBusNamespaces.ShadowControl = false;
            this.grouperServiceBusNamespaces.ShadowThickness = 1;
            this.grouperServiceBusNamespaces.Size = new System.Drawing.Size(368, 72);
            this.grouperServiceBusNamespaces.TabIndex = 32;
            // 
            // cboServiceBusNamespace
            // 
            this.cboServiceBusNamespace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboServiceBusNamespace.BackColor = System.Drawing.SystemColors.Window;
            this.cboServiceBusNamespace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboServiceBusNamespace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboServiceBusNamespace.FormattingEnabled = true;
            this.cboServiceBusNamespace.Location = new System.Drawing.Point(16, 32);
            this.cboServiceBusNamespace.Name = "cboServiceBusNamespace";
            this.cboServiceBusNamespace.Size = new System.Drawing.Size(336, 21);
            this.cboServiceBusNamespace.TabIndex = 0;
            this.cboServiceBusNamespace.SelectedIndexChanged += new System.EventHandler(this.cboServiceBusNamespace_SelectedIndexChanged);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(402, 425);
            this.Controls.Add(this.grouperServiceBusNamespaceSettings);
            this.Controls.Add(this.grouperServiceBusNamespaces);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to a Service Bus Namespace";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConnectForm_KeyPress);
            this.grouperServiceBusNamespaceSettings.ResumeLayout(false);
            this.grouperServiceBusNamespaceSettings.PerformLayout();
            this.grouperServiceBusNamespaces.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private Grouper grouperServiceBusNamespaces;
        private System.Windows.Forms.ComboBox cboServiceBusNamespace;
        private Grouper grouperServiceBusNamespaceSettings;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.Label lblUri;
        private System.Windows.Forms.TextBox txtServicePath;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox txtIssuerSecret;
        private System.Windows.Forms.Label lblIssuerSecret;
        private System.Windows.Forms.TextBox txtIssuerName;
        private System.Windows.Forms.Label lblIssuerName;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label lblNamespace;
    }
}