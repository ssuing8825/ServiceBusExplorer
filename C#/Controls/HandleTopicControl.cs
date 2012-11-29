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
    public partial class HandleTopicControl : UserControl
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
        private const int RequiresDuplicateDetectionIndex = 1;

        //***************************
        // Texts
        //***************************
        private const string DeleteText = "Delete";
        private const string CreateText = "Create";
        private const string TopicEntity = "TopicDescription";

        //***************************
        // Messages
        //***************************
        private const string PathCannotBeNull = "The Path field cannot be null.";
        private const string MaxTopicSizeInBytesMustBeANumber = "The MaxSizeInMegabytes field must be a number.";
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

        //***************************
        // Tooltips
        //***************************
        private const string PathTooltip = "Gets or sets the queue path.";
        private const string MaxSizeInMegabytesTooltip = "Gets or sets the maximum topic size in megabytes.";
        private const string DefaultMessageTimeToLiveTooltip = "Gets or sets the default message time to live of a queue.";
        private const string DuplicateDetectionHistoryTimeWindowTooltip = "Gets or sets the duration of the time window for duplicate detection history.";
        private const string SizeInBytesTooltip = "Gets the size of the topic in bytes.";
        #endregion

        #region Private Fields
        private TopicDescription topic;
        private readonly ServiceBusHelper serviceBusHelper;
        private readonly MainForm mainForm;
        private readonly WriteToLogDelegate writeToLog;
        private readonly string path;
        #endregion

        #region Public Constructors
        public HandleTopicControl(MainForm mainForm, WriteToLogDelegate writeToLog, ServiceBusHelper serviceBusHelper, TopicDescription topic, string path)
        {
            this.mainForm = mainForm;
            this.writeToLog = writeToLog;
            this.serviceBusHelper = serviceBusHelper;
            this.topic = topic;
            this.path = path;
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
            if (topic != null)
            {
                btnAction.Text = DeleteText;
                btnCancel.Enabled = false;
                SetReadOnly(this);

                // Path
                if (!string.IsNullOrEmpty(topic.Path))
                {
                    txtPath.Text = topic.Path;
                }

                // MaxSizeInMegabytes
                txtMaxTopicSizeInMegabytes.Text = topic.MaxSizeInMegabytes.ToString(CultureInfo.InvariantCulture);

                // SizeInBytesTooltip
                txtSizeInBytes.Text = topic.SizeInBytes.ToString(CultureInfo.InvariantCulture);

                // DefaultMessageTimeToLive
                txtDefaultMessageTimeToLiveDays.Text = topic.DefaultMessageTimeToLive.Days.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveHours.Text = topic.DefaultMessageTimeToLive.Hours.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveMinutes.Text = topic.DefaultMessageTimeToLive.Minutes.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveSeconds.Text = topic.DefaultMessageTimeToLive.Seconds.ToString(CultureInfo.InvariantCulture);
                txtDefaultMessageTimeToLiveMilliseconds.Text = topic.DefaultMessageTimeToLive.Milliseconds.ToString(CultureInfo.InvariantCulture);

                // DuplicateDetectionHistoryTimeWindow
                txtDuplicateDetectionHistoryTimeWindowDays.Text = topic.DuplicateDetectionHistoryTimeWindow.Days.ToString(CultureInfo.InvariantCulture);
                txtDuplicateDetectionHistoryTimeWindowHours.Text = topic.DuplicateDetectionHistoryTimeWindow.Hours.ToString(CultureInfo.InvariantCulture);
                txtDuplicateDetectionHistoryTimeWindowMinutes.Text = topic.DuplicateDetectionHistoryTimeWindow.Minutes.ToString(CultureInfo.InvariantCulture);
                txtDuplicateDetectionHistoryTimeWindowSeconds.Text = topic.DuplicateDetectionHistoryTimeWindow.Seconds.ToString(CultureInfo.InvariantCulture);
                txtDuplicateDetectionHistoryTimeWindowMilliseconds.Text = topic.DuplicateDetectionHistoryTimeWindow.Milliseconds.ToString(CultureInfo.InvariantCulture);

                // EnableBatchedOperations
                checkedListBox.SetItemChecked(EnableBatchedOperationsIndex,
                                              topic.EnableBatchedOperations);
                // RequiresDuplicateDetection
                checkedListBox.SetItemChecked(RequiresDuplicateDetectionIndex,
                                              topic.RequiresDuplicateDetection);

                checkedListBox.ItemCheck += checkedListBox_ItemCheck;

                toolTip.SetToolTip(txtPath, PathTooltip);
                toolTip.SetToolTip(txtMaxTopicSizeInMegabytes, MaxSizeInMegabytesTooltip);
                toolTip.SetToolTip(txtSizeInBytes, SizeInBytesTooltip);
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
                    var deleteForm = new DeleteForm(topic.Path, TopicEntity.ToLower());
                    if (deleteForm.ShowDialog() == DialogResult.OK)
                    {
                        serviceBusHelper.DeleteTopic(topic);
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txtPath.Text))
                    {
                        writeToLog(PathCannotBeNull);
                        return;
                    }
                    var topicDescription = new TopicDescription(txtPath.Text);
                    if (!string.IsNullOrEmpty(txtMaxTopicSizeInMegabytes.Text))
                    {
                        long value;
                        if (long.TryParse(txtMaxTopicSizeInMegabytes.Text, out value))
                        {
                            topicDescription.MaxSizeInMegabytes = value;
                        }
                        else
                        {
                            writeToLog(MaxTopicSizeInBytesMustBeANumber);
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
                        topicDescription.DefaultMessageTimeToLive = new TimeSpan(days, hours, minutes, seconds, milliseconds);
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
                        topicDescription.DuplicateDetectionHistoryTimeWindow = new TimeSpan(days, hours, minutes, seconds, milliseconds);
                    }

                    topicDescription.EnableBatchedOperations = checkedListBox.GetItemChecked(EnableBatchedOperationsIndex);
                    topicDescription.RequiresDuplicateDetection = checkedListBox.GetItemChecked(RequiresDuplicateDetectionIndex);

                    topic = serviceBusHelper.CreateTopic(topicDescription);
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
            if (topic != null)
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
