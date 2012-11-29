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
    public partial class HandleQueueControl : UserControl
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
        private const int EnableDeadLetteringOnMessageExpirationIndex = 1;
        private const int RequiresDuplicateDetectionIndex = 2;
        private const int RequiresSessionIndex = 3;

        //***************************
        // Texts
        //***************************
        private const string DeleteText = "Delete";
        private const string CreateText = "Create";
        private const string QueueEntity = "QueueDescription";

        //***************************
        // Messages
        //***************************
        private const string PathCannotBeNull = "The Path field cannot be null.";
        private const string MaxQueueSizeInBytesMustBeANumber = "The MaxSizeInMegabytes field must be a number.";
        private const string MaxDeliveryCountMustBeANumber = "The MaxDeliveryCount field must be a number.";
        private const string DefaultMessageTimeToLiveDaysMustBeANumber = "The Days value of the DefaultMessageTimeToLive field must be a number.";
        private const string DefaultMessageTimeToLiveHoursMustBeANumber = "The Hours value of the DefaultMessageTimeToLive field must be a number.";
        private const string DefaultMessageTimeToLiveMinutesMustBeANumber = "The Minutes value of the DefaultMessageTimeToLive field must be a number.";
        private const string DefaultMessageTimeToLiveSecondsMustBeANumber = "The Seconds value of the DefaultMessageTimeToLive field must be a number.";
        private const string DefaultMessageTimeToLiveMillisecondsMustBeANumber = "The Milliseconds value of the DefaultMessageTimeToLive field must be a number.";

        private const string DuplicateDetectionHistoryTimeWindowDaysMustBeANumber = "The Days value of the DuplicateDetectionHistoryTimeWindow field must be a number.";
        private const string DuplicateDetectionHistoryTimeWindowHoursMustBeANumber = "The Hours value of the DuplicateDetectionHistoryTimeWindow field must be a number.";
        private const string DuplicateDetectionHistoryTimeWindowMinutesMustBeANumber = "The Minutes value of the DuplicateDetectionHistoryTimeWindow field must be a number.";
        private const string DuplicateDetectionHistoryTimeWindowSecondsMustBeANumber = "The Seconds value of the DuplicateDetectionHistoryTimeWindow field must be a number.";
        private const string DuplicateDetectionHistoryTimeWindowMillisecondsMustBeANumber = "The Milliseconds value of the DuplicateDetectionHistoryTimeWindow field must be a number.";

        private const string LockDurationDaysMustBeANumber = "The Days value of the LockDuration field must be a number.";
        private const string LockDurationHoursMustBeANumber = "The Hours value of the LockDuration field must be a number.";
        private const string LockDurationMinutesMustBeANumber = "The Minutes value of the LockDuration field must be a number.";
        private const string LockDurationSecondsMustBeANumber = "The Seconds value of the LockDuration field must be a number.";
        private const string LockDurationMillisecondsMustBeANumber = "The Milliseconds value of the LockDuration field must be a number.";

        //***************************
        // Tooltips
        //***************************
        private const string PathTooltip = "Gets or sets the queue path.";
        private const string MaxQueueSizeInMegabytesTooltip = "Gets or sets the maximum queue size in megabytes.";
        private const string DefaultMessageTimeToLiveTooltip = "Gets or sets the default message time to live of a queue.";
        private const string DuplicateDetectionHistoryTimeWindowTooltip = "Gets or sets the duration of the time window for duplicate detection history.";
        private const string LockDurationTooltip = "Gets or sets the lock duration timespan associated with this queue.";
        private const string SizeInBytesTooltip = "Gets the size of the queue in bytes.";
        private const string MessageCountTooltip = "Gets the number of messages in the queue.";
        private const string MaxDeliveryCountTooltip = "Gets or sets the maximum delivery count. A message is automatically deadlettered after this number of deliveries.";
        #endregion

        #region Private Fields
        private QueueDescription queueDescription;
        private readonly ServiceBusHelper serviceBusHelper;
        private readonly MainForm mainForm;
        private readonly WriteToLogDelegate writeToLog;
        private readonly string path;
        #endregion

        #region Public Constructors
        public HandleQueueControl(MainForm mainForm, WriteToLogDelegate writeToLog, ServiceBusHelper serviceBusHelper, QueueDescription queueDescription, string path)
        {
            this.mainForm = mainForm;
            this.writeToLog = writeToLog;
            this.serviceBusHelper = serviceBusHelper;
            this.path = path;
            this.queueDescription = queueDescription;
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
            if (queueDescription != null)
            {
                btnAction.Text = DeleteText;
                btnCancel.Enabled = false;
                SetReadOnly(this);

                // Path
                if (!string.IsNullOrEmpty(queueDescription.Path))
                {
                    txtPath.Text = queueDescription.Path;
                }
                // MaxQueueSizeInBytes
                txtMaxQueueSizeInMegabytes.Text = queueDescription.MaxSizeInMegabytes.ToString(CultureInfo.InvariantCulture);

                // MaxDeliveryCount
                txtMaxDeliveryCount.Text = queueDescription.MaxDeliveryCount.ToString(CultureInfo.InvariantCulture);

                // MessageCount
                txtMessageCount.Text = queueDescription.MessageCount.ToString(CultureInfo.InvariantCulture);

                // SizeInBytesTooltip
                txtSizeInBytes.Text = queueDescription.SizeInBytes.ToString(CultureInfo.InvariantCulture);

                // DefaultMessageTimeToLive
                txtDefaultMessageTimeToLiveDays.Text = queueDescription.DefaultMessageTimeToLive.Days.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveHours.Text = queueDescription.DefaultMessageTimeToLive.Hours.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveMinutes.Text = queueDescription.DefaultMessageTimeToLive.Minutes.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveSeconds.Text = queueDescription.DefaultMessageTimeToLive.Seconds.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveMilliseconds.Text = queueDescription.DefaultMessageTimeToLive.Milliseconds.ToString(CultureInfo.InvariantCulture);

                // DuplicateDetectionHistoryTimeWindow
                txtDuplicateDetectionHistoryTimeWindowDays.Text = queueDescription.DuplicateDetectionHistoryTimeWindow.Days.ToString(CultureInfo.InvariantCulture);
                txtDuplicateDetectionHistoryTimeWindowHours.Text = queueDescription.DuplicateDetectionHistoryTimeWindow.Hours.ToString(CultureInfo.InvariantCulture);
                txtDuplicateDetectionHistoryTimeWindowMinutes.Text = queueDescription.DuplicateDetectionHistoryTimeWindow.Minutes.ToString(CultureInfo.InvariantCulture);
                txtDuplicateDetectionHistoryTimeWindowSeconds.Text = queueDescription.DuplicateDetectionHistoryTimeWindow.Seconds.ToString(CultureInfo.InvariantCulture);
                txtDuplicateDetectionHistoryTimeWindowMilliseconds.Text = queueDescription.DuplicateDetectionHistoryTimeWindow.Milliseconds.ToString(CultureInfo.InvariantCulture);

                // LockDuration
                txtLockDurationDays.Text = queueDescription.LockDuration.Days.ToString(CultureInfo.InvariantCulture);
                txtLockDurationHours.Text = queueDescription.LockDuration.Hours.ToString(CultureInfo.InvariantCulture);
                txtLockDurationMinutes.Text = queueDescription.LockDuration.Minutes.ToString(CultureInfo.InvariantCulture);
                txtLockDurationSeconds.Text = queueDescription.LockDuration.Seconds.ToString(CultureInfo.InvariantCulture);
                txtLockDurationMilliseconds.Text = queueDescription.LockDuration.Milliseconds.ToString(CultureInfo.InvariantCulture);

                // EnableBatchedOperations
                checkedListBox.SetItemChecked(EnableBatchedOperationsIndex,
                                              queueDescription.EnableBatchedOperations);

                // EnableDeadLetteringOnMessageExpiration
                checkedListBox.SetItemChecked(EnableDeadLetteringOnMessageExpirationIndex,
                                              queueDescription.EnableDeadLetteringOnMessageExpiration);

                // RequiresDuplicateDetectionIndex
                checkedListBox.SetItemChecked(RequiresDuplicateDetectionIndex,
                                              queueDescription.RequiresDuplicateDetection);

                // RequiresSessionIndex
                checkedListBox.SetItemChecked(RequiresSessionIndex,
                                              queueDescription.RequiresSession);

                checkedListBox.ItemCheck += checkedListBox_ItemCheck;

                toolTip.SetToolTip(txtPath, PathTooltip);
                toolTip.SetToolTip(txtMaxQueueSizeInMegabytes, MaxQueueSizeInMegabytesTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveDays, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveHours, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveMinutes, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveSeconds, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDefaultMessageTimeToLiveMilliseconds, DefaultMessageTimeToLiveTooltip);
                toolTip.SetToolTip(txtDuplicateDetectionHistoryTimeWindowDays, DuplicateDetectionHistoryTimeWindowTooltip);
                toolTip.SetToolTip(txtDuplicateDetectionHistoryTimeWindowHours, DuplicateDetectionHistoryTimeWindowTooltip);
                toolTip.SetToolTip(txtDuplicateDetectionHistoryTimeWindowMinutes, DuplicateDetectionHistoryTimeWindowTooltip);
                toolTip.SetToolTip(txtDuplicateDetectionHistoryTimeWindowSeconds, DuplicateDetectionHistoryTimeWindowTooltip);
                toolTip.SetToolTip(txtDuplicateDetectionHistoryTimeWindowMilliseconds, DuplicateDetectionHistoryTimeWindowTooltip);
                toolTip.SetToolTip(txtLockDurationDays, LockDurationTooltip);
                toolTip.SetToolTip(txtLockDurationHours, LockDurationTooltip);
                toolTip.SetToolTip(txtLockDurationMinutes, LockDurationTooltip);
                toolTip.SetToolTip(txtLockDurationSeconds, LockDurationTooltip);
                toolTip.SetToolTip(txtLockDurationMilliseconds, LockDurationTooltip);
                toolTip.SetToolTip(txtSizeInBytes, SizeInBytesTooltip);
                toolTip.SetToolTip(txtMessageCount, MessageCountTooltip);
                toolTip.SetToolTip(txtMaxDeliveryCount, MaxDeliveryCountTooltip);                
            }
            else
            {
                btnAction.Text = CreateText;
                if (!string.IsNullOrEmpty(path))
                {
                    txtPath.Text = path;
                }
            }
            txtPath.Focus();
        }

        private void SetReadOnly(Control control)
        {
            if (control != null &&
                control.Controls.Count > 0)
            {
                for (var i = 0; i < control.Controls.Count; i++)
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
                if (serviceBusHelper == null)
                {
                    return;
                }
                if (btnAction.Text == DeleteText)
                {
                    var deleteForm = new DeleteForm(queueDescription.Path, QueueEntity.ToLower());
                    if (deleteForm.ShowDialog() == DialogResult.OK)
                    {
                        serviceBusHelper.DeleteQueue(queueDescription);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPath.Text))
                    {
                        writeToLog(PathCannotBeNull);
                        return;
                    }

                    var description = new QueueDescription(txtPath.Text);

                    if (!string.IsNullOrEmpty(txtMaxQueueSizeInMegabytes.Text))
                    {
                        long value;
                        if (long.TryParse(txtMaxQueueSizeInMegabytes.Text, out value))
                        {
                            description.MaxSizeInMegabytes = value;
                        }
                        else
                        {
                            writeToLog(MaxQueueSizeInBytesMustBeANumber);
                            return;
                        }
                    }

                    if (!string.IsNullOrEmpty(txtMaxDeliveryCount.Text))
                    {
                        int value;
                        if (int.TryParse(txtMaxDeliveryCount.Text, out value))
                        {
                            description.MaxDeliveryCount = value;
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
                        description.DefaultMessageTimeToLive = new TimeSpan(days, hours, minutes, seconds, milliseconds);
                    }

                    days = 0;
                    hours = 0;
                    minutes = 0;
                    seconds = 0;
                    milliseconds = 0;

                    if (!string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowDays.Text) ||
                        !string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowHours.Text) ||
                        !string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowMinutes.Text) ||
                        !string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowSeconds.Text) ||
                        !string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowMilliseconds.Text))
                    {
                        if (!string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowDays.Text))
                        {
                            if (!int.TryParse(txtDuplicateDetectionHistoryTimeWindowDays.Text, out days))
                            {
                                writeToLog(DuplicateDetectionHistoryTimeWindowDaysMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowHours.Text))
                        {
                            if (!int.TryParse(txtDuplicateDetectionHistoryTimeWindowHours.Text, out hours))
                            {
                                writeToLog(DuplicateDetectionHistoryTimeWindowHoursMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowMinutes.Text))
                        {
                            if (!int.TryParse(txtDuplicateDetectionHistoryTimeWindowMinutes.Text, out minutes))
                            {
                                writeToLog(DuplicateDetectionHistoryTimeWindowMinutesMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowSeconds.Text))
                        {
                            if (!int.TryParse(txtDuplicateDetectionHistoryTimeWindowSeconds.Text, out seconds))
                            {
                                writeToLog(DuplicateDetectionHistoryTimeWindowSecondsMustBeANumber);
                                return;
                            }
                        }
                        if (!string.IsNullOrEmpty(txtDuplicateDetectionHistoryTimeWindowMilliseconds.Text))
                        {
                            if (!int.TryParse(txtDuplicateDetectionHistoryTimeWindowMilliseconds.Text, out milliseconds))
                            {
                                writeToLog(DuplicateDetectionHistoryTimeWindowMillisecondsMustBeANumber);
                                return;
                            }
                        }
                        description.DuplicateDetectionHistoryTimeWindow = new TimeSpan(days, hours, minutes, seconds, milliseconds);
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
                        description.LockDuration = new TimeSpan(days, hours, minutes, seconds, milliseconds);
                    }

                    description.EnableBatchedOperations = checkedListBox.GetItemChecked(EnableBatchedOperationsIndex);
                    description.EnableDeadLetteringOnMessageExpiration = checkedListBox.GetItemChecked(EnableDeadLetteringOnMessageExpirationIndex);
                    description.RequiresDuplicateDetection = checkedListBox.GetItemChecked(RequiresDuplicateDetectionIndex);
                    description.RequiresSession = checkedListBox.GetItemChecked(RequiresSessionIndex);

                    queueDescription = serviceBusHelper.CreateQueue(description);
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
            if (queueDescription != null)
            {
                e.NewValue = e.CurrentValue;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnCancel();
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
