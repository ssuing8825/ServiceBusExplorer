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
using System.Globalization;
using System.Windows.Forms;
using Microsoft.ServiceBus.Messaging;
#endregion

namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    public partial class HandleRuleControl : UserControl
    {
        #region Private Constants
        //***************************
        // Formats
        //***************************
        private const string ExceptionFormat = "Exception: {0}";
        private const string InnerExceptionFormat = "InnerException: {0}";

        //***************************
        // Texts
        //***************************
        private const string RemoveText = "Remove";
        private const string AddText = "Add";
        private const string RuleEntity = "RuleDescription";

        //***************************
        // Messages
        //***************************
        private const string NameCannotBeNull = "The Name field cannot be null.";

        //***************************
        // Tooltips
        //***************************
        private const string NameTooltip = "Gets or sets the rule name.";
        private const string FilterExpressionTooltip = "Gets or sets the filter expression.";
        private const string FilterActionTooltip = "Gets or sets the filter action.";
        #endregion

        #region Private Fields
        private readonly RuleWrapper ruleWrapper;
        private readonly ServiceBusHelper serviceBusHelper;
        private readonly MainForm mainForm;
        private readonly WriteToLogDelegate writeToLog;
        private bool? isFirstRule = false;
        #endregion

        #region Public Constructors
        public HandleRuleControl(MainForm mainForm, WriteToLogDelegate writeToLog, ServiceBusHelper serviceBusHelper, RuleWrapper ruleWrapper, bool? isFirstRule)
        {
            this.mainForm = mainForm;
            this.writeToLog = writeToLog;
            this.serviceBusHelper = serviceBusHelper;
            this.ruleWrapper = ruleWrapper;
            this.isFirstRule = isFirstRule;
            InitializeComponent();
            InitializeData();
        } 
        #endregion

        #region Public Events
        public event Action OnCancel;
        #endregion

        #region Private Methods
        private void InitializeData()
        {
            if (ruleWrapper != null &&
                ruleWrapper.SubscriptionDescription != null &&
                ruleWrapper.RuleDescription != null)
            {
                btnAction.Text = RemoveText;
                btnCancel.Enabled = false;
                checkBoxDefault.Checked = true;
                checkBoxDefault.Enabled = false;
                checkBoxDefault.CheckedChanged += checkBoxDefault_CheckedChanged;
                SetReadOnly(this);
                if (!string.IsNullOrEmpty(ruleWrapper.RuleDescription.Name))
                {
                    txtName.Text = ruleWrapper.RuleDescription.Name;
                }
                if (ruleWrapper.RuleDescription.Filter != null &&
                    ruleWrapper.RuleDescription.Filter is SqlFilter)
                {
                    txtSqlFilterExpression.Text = (ruleWrapper.RuleDescription.Filter as SqlFilter).SqlExpression ?? string.Empty;
                }
                if (ruleWrapper.RuleDescription.Action != null &&
                    ruleWrapper.RuleDescription.Action is SqlRuleAction)
                {
                    txtSqlFilterAction.Text = (ruleWrapper.RuleDescription.Action as SqlRuleAction).SqlExpression ?? string.Empty;
                }
                toolTip.SetToolTip(txtName, NameTooltip);
                toolTip.SetToolTip(txtSqlFilterExpression, FilterExpressionTooltip);
                toolTip.SetToolTip(txtSqlFilterAction, FilterActionTooltip);
            }
            else
            {
                btnAction.Text = AddText;
                if (isFirstRule.HasValue)
                {
                    checkBoxDefault.Checked = isFirstRule.Value;
                }
            }
            txtName.Focus();
        }

        private void SetReadOnly(Control control)
        {
            if (control != null &&
                control.Controls.Count > 0)
            {
                for (int i = 0; i < control.Controls.Count; i++)
                {
                    if (control.Controls[i] is TextBox)
                    {
                        var textBox = ((TextBox)(control.Controls[i]));
                        textBox.ReadOnly = true;
                        textBox.BackColor = SystemColors.Window;
                        continue;
                    }
                    SetReadOnly(control.Controls[i]);
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (serviceBusHelper == null ||
                    ruleWrapper == null ||
                    ruleWrapper.SubscriptionDescription == null)
                {
                    return;
                }
                if (btnAction.Text == RemoveText &&
                    ruleWrapper.SubscriptionDescription != null &&
                    !string.IsNullOrEmpty(ruleWrapper.SubscriptionDescription.Name) &&
                    ruleWrapper.RuleDescription != null &&
                    !string.IsNullOrEmpty(ruleWrapper.RuleDescription.Name))
                {
                    var deleteForm = new DeleteForm(ruleWrapper.RuleDescription.Name, RuleEntity.ToLower());
                    if (deleteForm.ShowDialog() == DialogResult.OK)
                    {
                        serviceBusHelper.RemoveRule(ruleWrapper.SubscriptionDescription, ruleWrapper.RuleDescription);
                    }
                    return;
                }
                if (btnAction.Text == AddText)
                {
                    if (string.IsNullOrEmpty(txtName.Text))
                    {
                        writeToLog(NameCannotBeNull);
                        return;
                    }

                    var ruleDescription = new RuleDescription(txtName.Text);

                    if (!string.IsNullOrEmpty(txtSqlFilterExpression.Text))
                    {
                        ruleDescription.Filter = new SqlFilter(txtSqlFilterExpression.Text);
                    }
                    if (!string.IsNullOrEmpty(txtSqlFilterAction.Text))
                    {
                        ruleDescription.Action = new SqlRuleAction(txtSqlFilterAction.Text);
                    }

                    ruleWrapper.RuleDescription = serviceBusHelper.AddRule(ruleWrapper.SubscriptionDescription, ruleDescription);
                    InitializeData();
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }

        private void HandleException(Exception ex)
        {
            if (ex != null && !string.IsNullOrEmpty(ex.Message))
            {
                writeToLog(string.Format(CultureInfo.CurrentCulture, ExceptionFormat, ex.Message));
                if (ex.InnerException != null && !string.IsNullOrEmpty(ex.InnerException.Message))
                {
                    writeToLog(string.Format(CultureInfo.CurrentCulture, InnerExceptionFormat, ex.InnerException.Message));
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancel();
        }

        private void checkBoxDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDefault.Checked)
            {
                txtName.Text = RuleDescription.DefaultRuleName;
            }
        }

        private void HandleRuleControl_Resize(object sender, EventArgs e)
        {
            var width = (Size.Width - 48) / 2;
            var height = Size.Height - 152;
            grouperFilter.Size = new Size(width, height);
            grouperAction.Size = new Size(width, height);
            grouperAction.Location = new Point(grouperFilter.Location.X + width + 16, 
                                                         grouperAction.Location.Y);
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
