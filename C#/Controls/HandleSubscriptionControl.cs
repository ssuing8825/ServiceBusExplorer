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
    public partial class HandleSubscriptionControl : UserControl
    {
        #region Private Constants
        //***************************
        // Formats
        //***************************
        private const string ExceptionFormat = "Exception: {0}";
        private const string InnerExceptionFormat = "InnerException: {0}";

        //***************************
        // Indexes
        //***************************
        private const int EnableBatchedOperationsIndex = 0;
        private const int EnableDeadLetteringOnFilterEvaluationExceptionsIndex = 1;
        private const int EnableDeadLetteringOnMessageExpirationIndex = 2;
        private const int RequiresSessionIndex = 3;

        //***************************
        // Texts
        //***************************
        private const string DeleteText = "Delete";
        private const string CreateText = "Create";
        private const string SubscriptionEntity = "SubscriptionDescription";
        private const string FilterExpression = "Filter Expression";
        private const string ActionExpression = "Action Expression";

        //***************************
        // Messages
        //***************************
        private const string NameCannotBeNull = "The Name field cannot be null.";
        private const string MaxDeliveryCountMustBeANumber = "The MaxDeliveryCount field must be a number.";

        private const string DefaultMessageTimeToLiveDaysMustBeANumber = "The Days value of the DefaultMessageTimeToLive field must be a number.";
        private const string DefaultMessageTimeToLiveHoursMustBeANumber = "The Hours value of the DefaultMessageTimeToLive field must be a number.";
        private const string DefaultMessageTimeToLiveMinutesMustBeANumber = "The Minutes value of the DefaultMessageTimeToLive field must be a number.";
        private const string DefaultMessageTimeToLiveSecondsMustBeANumber = "The Seconds value of the DefaultMessageTimeToLive field must be a number.";
        private const string DefaultMessageTimeToLiveMillisecondsMustBeANumber = "The Milliseconds value of the DefaultMessageTimeToLive field must be a number.";

        private const string LockDurationDaysMustBeANumber = "The Days value of the LockDuration field must be a number.";
        private const string LockDurationHoursMustBeANumber = "The Hours value of the LockDuration field must be a number.";
        private const string LockDurationMinutesMustBeANumber = "The Minutes value of the LockDuration field must be a number.";
        private const string LockDurationSecondsMustBeANumber = "The Seconds value of the LockDuration field must be a number.";
        private const string LockDurationMillisecondsMustBeANumber = "The Milliseconds value of the LockDuration field must be a number.";

        //***************************
        // Tooltips
        //***************************
        private const string NameTooltip = "Gets or sets the subscription name.";
        private const string DefaultMessageTimeToLiveTooltip = "Gets or sets the default message time to live of a queue.";
        private const string FilterExpressionTooltip = "Gets or sets the filter expression of the default rule.";
        private const string FilterActionTooltip = "Gets or sets the filter action of the default rule.";
        private const string LockDurationTooltip = "Gets or sets the lock duration timespan associated with this queue.";
        private const string MessageCountTooltip = "Gets the number of messages in the subscription.";
        private const string MaxDeliveryCountTooltip = "Gets or sets the maximum delivery count. A message is automatically deadlettered after this number of deliveries.";
        #endregion

        #region Private Fields
        private readonly SubscriptionWrapper wrapper;
        private readonly ServiceBusHelper serviceBusHelper;
        private readonly MainForm mainForm;
        private readonly WriteToLogDelegate writeToLog;
        #endregion

        #region Public Constructors
        public HandleSubscriptionControl(MainForm mainForm, WriteToLogDelegate writeToLog, ServiceBusHelper serviceBusHelper, SubscriptionWrapper wrapper)
        {
            this.mainForm = mainForm;
            this.writeToLog = writeToLog;
            this.serviceBusHelper = serviceBusHelper;
            this.wrapper = wrapper;
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
            if (wrapper != null &&
                wrapper.TopicDescription != null &&
                wrapper.SubscriptionDescription != null)
            {
                btnAction.Text = DeleteText;
                btnCancel.Enabled = false;
                SetReadOnly(this);
                grouperDefaultFilter.Visible = false;
                grouperSubscriptionSettings.Width = Width - 32;
                grouperSubscriptionSettings.Location = new Point(16, grouperSubscriptionSettings.Location.Y);

                // Name
                if (!string.IsNullOrEmpty(wrapper.SubscriptionDescription.Name))
                {
                    txtName.Text = wrapper.SubscriptionDescription.Name;
                }

                // MaxDeliveryCount
                txtMaxDeliveryCount.Text = wrapper.SubscriptionDescription.MaxDeliveryCount.ToString(CultureInfo.InvariantCulture);

                // MessageCount
                txtMessageCount.Text = wrapper.SubscriptionDescription.MessageCount.ToString(CultureInfo.InvariantCulture);

                // DefaultMessageTimeToLive
                txtDefaultMessageTimeToLiveDays.Text = wrapper.SubscriptionDescription.DefaultMessageTimeToLive.Days.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveHours.Text = wrapper.SubscriptionDescription.DefaultMessageTimeToLive.Hours.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveMinutes.Text = wrapper.SubscriptionDescription.DefaultMessageTimeToLive.Minutes.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveSeconds.Text = wrapper.SubscriptionDescription.DefaultMessageTimeToLive.Seconds.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveMilliseconds.Text = wrapper.SubscriptionDescription.DefaultMessageTimeToLive.Milliseconds.ToString(CultureInfo.InvariantCulture);

                // LockDuration
                txtLockDurationDays.Text = wrapper.SubscriptionDescription.LockDuration.Days.ToString(CultureInfo.InvariantCulture);
                txtLockDurationHours.Text = wrapper.SubscriptionDescription.LockDuration.Hours.ToString(CultureInfo.InvariantCulture);
                txtLockDurationMinutes.Text = wrapper.SubscriptionDescription.LockDuration.Minutes.ToString(CultureInfo.InvariantCulture);
                txtLockDurationSeconds.Text = wrapper.SubscriptionDescription.LockDuration.Seconds.ToString(CultureInfo.InvariantCulture);
                txtLockDurationMilliseconds.Text = wrapper.SubscriptionDescription.LockDuration.Milliseconds.ToString(CultureInfo.InvariantCulture);

                // EnableDeadLetteringOnFilterEvaluationExceptions
                checkedListBox.SetItemChecked(EnableBatchedOperationsIndex,
                                              wrapper.SubscriptionDescription.EnableBatchedOperations);

                // EnableDeadLetteringOnFilterEvaluationExceptions
                checkedListBox.SetItemChecked(EnableDeadLetteringOnFilterEvaluationExceptionsIndex,
                                              wrapper.SubscriptionDescription.EnableDeadLetteringOnFilterEvaluationExceptions);

                // EnableDeadLetteringOnMessageExpiration
                checkedListBox.SetItemChecked(EnableDeadLetteringOnMessageExpirationIndex,
                                              wrapper.SubscriptionDescription.EnableDeadLetteringOnMessageExpiration);

                // RequiresSession
                checkedListBox.SetItemChecked(RequiresSessionIndex,
                                              wrapper.SubscriptionDescription.RequiresSession);
                
                checkedListBox.ItemCheck += checkedListBox_ItemCheck;

                toolTip.SetToolTip(txtName, NameTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveDays, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveHours, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveMinutes, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveSeconds, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveMilliseconds, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtFilter, FilterExpressionTooltip);
                toolTip.SetToolTip(txtAction, FilterActionTooltip);
                toolTip.SetToolTip(txtLockDurationDays, LockDurationTooltip);
                toolTip.SetToolTip(txtLockDurationHours, LockDurationTooltip);
                toolTip.SetToolTip(txtLockDurationMinutes, LockDurationTooltip);
                toolTip.SetToolTip(txtLockDurationSeconds, LockDurationTooltip);
                toolTip.SetToolTip(txtLockDurationMilliseconds, LockDurationTooltip);
                toolTip.SetToolTip(txtMessageCount, MessageCountTooltip);
                toolTip.SetToolTip(txtMaxDeliveryCount, MaxDeliveryCountTooltip);
            }
            else
            {
                btnAction.Text = CreateText;
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
                    wrapper == null ||
                    wrapper.TopicDescription == null)
                {
                    return;
                }
                if (btnAction.Text == DeleteText &&
                    wrapper.SubscriptionDescription != null &&
                    !string.IsNullOrEmpty(wrapper.SubscriptionDescription.Name))
                {
                    var deleteForm = new DeleteForm(wrapper.SubscriptionDescription.Name, SubscriptionEntity.ToLower());
                    if (deleteForm.ShowDialog() == DialogResult.OK)
                    {
                        serviceBusHelper.DeleteSubscription(wrapper.SubscriptionDescription);
                    }
                    return;
                }
                if (btnAction.Text == CreateText)
                {
                    
                    if (string.IsNullOrEmpty(txtName.Text))
                    {
                        writeToLog(NameCannotBeNull);
                        return;
                    }

                    var subscriptionDescription = new SubscriptionDescription(wrapper.TopicDescription.Path, txtName.Text);

                    if (!string.IsNullOrEmpty(txtMaxDeliveryCount.Text))
                    {
                        int value;
                        if (int.TryParse(txtMaxDeliveryCount.Text, out value))
                        {
                            subscriptionDescription.MaxDeliveryCount = value;
                        }
                        else
                        {
                            writeToLog(MaxDeliveryCountMustBeANumber);
                            return;
                        }
                    }

                    var days = 0;
                    var hours = 0;
                    var minutes = 0;
                    var seconds = 0;
                    var milliseconds = 0;

                    if (!string.IsNullOrEmpty(txtDefaultMessageTimeToLiveDays.Text) ||
                        !string.IsNullOrEmpty(txtDefaultMessageTimeToLiveHours.Text) ||
                        !string.IsNullOrEmpty(txtDefaultMessageTimeToLiveMinutes.Text) ||
                        !string.IsNullOrEmpty(txtDefaultMessageTimeToLiveSeconds.Text) ||
                        !string.IsNullOrEmpty(txtDefaultMessageTimeToLiveMilliseconds.Text))
                    {
                        if (!string.IsNullOrEmpty(txtDefaultMessageTimeToLiveDays.Text))
                        {
                            if (!int.TryParse(txtDefaultMessageTimeToLiveDays.Text, out days))
                            {
                                writeToLog(DefaultMessageTimeToLiveDaysMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtDefaultMessageTimeToLiveHours.Text))
                        {
                            if (!int.TryParse(txtDefaultMessageTimeToLiveHours.Text, out hours))
                            {
                                writeToLog(DefaultMessageTimeToLiveHoursMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtDefaultMessageTimeToLiveMinutes.Text))
                        {
                            if (!int.TryParse(txtDefaultMessageTimeToLiveMinutes.Text, out minutes))
                            {
                                writeToLog(DefaultMessageTimeToLiveMinutesMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtDefaultMessageTimeToLiveSeconds.Text))
                        {
                            if (!int.TryParse(txtDefaultMessageTimeToLiveSeconds.Text, out seconds))
                            {
                                writeToLog(DefaultMessageTimeToLiveSecondsMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtDefaultMessageTimeToLiveMilliseconds.Text))
                        {
                            if (!int.TryParse(txtDefaultMessageTimeToLiveMilliseconds.Text, out milliseconds))
                            {
                                writeToLog(DefaultMessageTimeToLiveMillisecondsMustBeANumber);
                                return;
                            }
                        }
                        subscriptionDescription.DefaultMessageTimeToLive = new TimeSpan(days, hours, minutes, seconds, milliseconds);
                    }

                    days = 0;
                    hours = 0;
                    minutes = 0;
                    seconds = 0;
                    milliseconds = 0;

                    if (!string.IsNullOrEmpty(txtLockDurationDays.Text) ||
                        !string.IsNullOrEmpty(txtLockDurationHours.Text) ||
                        !string.IsNullOrEmpty(txtLockDurationMinutes.Text) ||
                        !string.IsNullOrEmpty(txtLockDurationSeconds.Text) ||
                        !string.IsNullOrEmpty(txtLockDurationMilliseconds.Text))
                    {
                        if (!string.IsNullOrEmpty(txtLockDurationDays.Text))
                        {
                            if (!int.TryParse(txtLockDurationDays.Text, out days))
                            {
                                writeToLog(LockDurationDaysMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtLockDurationHours.Text))
                        {
                            if (!int.TryParse(txtLockDurationHours.Text, out hours))
                            {
                                writeToLog(LockDurationHoursMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtLockDurationMinutes.Text))
                        {
                            if (!int.TryParse(txtLockDurationMinutes.Text, out minutes))
                            {
                                writeToLog(LockDurationMinutesMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtLockDurationSeconds.Text))
                        {
                            if (!int.TryParse(txtLockDurationSeconds.Text, out seconds))
                            {
                                writeToLog(LockDurationSecondsMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtLockDurationMilliseconds.Text))
                        {
                            if (!int.TryParse(txtLockDurationMilliseconds.Text, out milliseconds))
                            {
                                writeToLog(LockDurationMillisecondsMustBeANumber);
                                return;
                            }
                        }
                        subscriptionDescription.LockDuration = new TimeSpan(days, hours, minutes, seconds, milliseconds);
                    }

                    subscriptionDescription.EnableBatchedOperations = checkedListBox.GetItemChecked(EnableBatchedOperationsIndex);
                    subscriptionDescription.EnableDeadLetteringOnFilterEvaluationExceptions = checkedListBox.GetItemChecked(EnableDeadLetteringOnFilterEvaluationExceptionsIndex);
                    subscriptionDescription.EnableDeadLetteringOnMessageExpiration = checkedListBox.GetItemChecked(EnableDeadLetteringOnMessageExpirationIndex);
                    subscriptionDescription.RequiresSession = checkedListBox.GetItemChecked(RequiresSessionIndex);

                    var ruleDescription = new RuleDescription();

                    if (!string.IsNullOrEmpty(txtFilter.Text))
                    {
                        ruleDescription.Filter = new SqlFilter(txtFilter.Text);
                    }
                    if (!string.IsNullOrEmpty(txtAction.Text))
                    {
                        ruleDescription.Action = new SqlRuleAction(txtAction.Text);
                    }

                    wrapper.SubscriptionDescription = serviceBusHelper.CreateSubscription(wrapper.TopicDescription, 
                                                                                          subscriptionDescription, 
                                                                                          ruleDescription);
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

        private void checkedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (wrapper != null &&
                wrapper.SubscriptionDescription != null)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancel();
        }

        private void openOpenFilterForm_Click(object sender, EventArgs e)
        {
            var form = new TextForm(FilterExpression, txtFilter.Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtFilter.Text = form.Content;
            }
        }

        private void btnOpenActionForm_Click(object sender, EventArgs e)
        {
            var form = new TextForm(ActionExpression, txtAction.Text);
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtAction.Text = form.Content;
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
