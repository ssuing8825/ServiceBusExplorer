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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Transactions;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.ServiceBus.Messaging;
using Cursor = System.Windows.Forms.Cursor;

#endregion

namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    public partial class TestTopicControl : UserControl
    {
        #region Private Constants
        //***************************
        // Formats
        //***************************
        private const string ExceptionFormat = "Exception: {0}";
        private const string InnerExceptionFormat = "InnerException: {0}";
        private const string LabelFormat = "{0:0.000}";

        //***************************
        // Properties & Types
        //***************************
        private const string PropertyKey = "Key";
        private const string PropertyType = "Type";
        private const string PropertyValue = "Value";
        private const string DefaultSessionId = "1";
        private const string DefaultMessageCount = "1";
        private const string DefaultSenderTaskCount = "1";
        private const string DefaultReceiverTaskCount = "1";
        private const string DefaultReceiveTimeout = "1";
        private const string DefaultSessionTimeout = "3";
        private const string DefaultPrefetchCount = "0";
        private const string PeekLock = "PeekLock";
        private const string StartCaption = "Start";
        private const string StopCaption = "Stop";
        private const string DefaultFilterExpression = "1=1";

        //***************************
        // Messages
        //***************************
        private const string MessageCannotBeNull = "The Message field cannot be null.";
        private const string ReceiveTimeoutCannotBeNull = "The receive timeout field cannot be null and must be a positive integer number.";
        private const string SessionTimeoutCannotBeNull = "The session timeout field cannot be null and must be a positive integer number.";
        private const string PrefetchCountCannotBeNull = "The prefetch count field cannot be null and must be an integer number.";
        private const string DefaultMessageText = "Hi mate, how are you?";
        private const string MessageCountMustBeANumber = "The Message Count field must be an integer number greater or equal to zero.";
        private const string SendTaskCountMustBeANumber = "The Sender Task Count field must be an integer number greater than zero.";
        private const string ReceiveTaskCountMustBeANumber = "The Receiver Task Count field must be an integer number greater than zero.";
        private const string TransactionCommitted = " - Transaction committed.";
        private const string TransactionAborted = " - Transaction aborted.";
        private const string NoMoreSessionsToAccept = "Receiver[{0}]: No more sessions to accept.";
        private const string FilterExpressionIsNotValid = "The filter expression is not valid.";
        private const string NoSubscriptionSelected = "No subscription has been selected.";

        //***************************
        // Tooltips
        //***************************
        private const string ContentTypeTooltip = "Gets or sets the type of the content.";
        private const string ToTooltip = "Gets or sends the send to address.";
        private const string ScheduledEnqueueTimeUtcTooltip = "Gets or sets the timeout in seconds after which the message will be enqueued.";
        private const string ReceiveModeTooltip = "Gets or sets the receive mode of message receivers.";
        private const string MessageTextTooltip = "Gets or sets the message text.";
        private const string SenderEnabledToolTip = "Enable or disable message senders.";
        private const string ReceiverEnabledToolTip = "Enable or disable message receivers.";
        private const string LabelTooltip = "Gets or sets the message label.";
        private const string MessageIdTooltip = "Gets or sets the message id.";
        private const string SessionIdTooltip = "Gets or sets the session id.";
        private const string CorrelationIdTooltip = "Gets or sets the correlation id.";
        private const string ReplyToTooltip = "Gets or sets the replyTo field.";
        private const string ReplyToSessionIdTooltip = "Gets or sets the replyToSessionId field.";
        private const string MessagePropertiesTooltip = "Gets or sets the properties of the message.";
        private const string MessageCountTooltip = "Gets or sets the number of messages to send.";
        private const string SendTaskCountTooltip = "Gets or sets the count of message senders.";
        private const string ReceiverTaskCountTooltip = "Gets or sets the count of message receivers.";
        private const string UpdateMessageIdTooltip = "Gets or sets a boolean value indicating whether the id of the message must be updated when sending multiple messages.";
        private const string ReceiveTimeoutTooltip = "Gets or sets the receive timeout.";
        private const string SessionTimeoutTooltip = "Gets or sets the session timeout.";
        private const string FilterExpressionTooltip = "Gets or sets the filter expression used to select messages to move to the dead-letter queue or to defer.";
        private const string SubscriptionTooltip = "Select the subscription used to receive messages.";
        private const string EnableSenderLoggingTooltip = "Enable logging of message content and properties for message senders.";
        private const string EnableReceiverLoggingTooltip = "Enable logging of message content and properties for message receivers.";
        private const string EnableSenderVerboseLoggingTooltip = "Enable verbose logging for message senders.";
        private const string EnableReceiverVerboseLoggingTooltip = "Enable verbose logging for message receivers.";
        private const string EnableSenderTransactionTooltip = "Enable transactional behavior for message senders.";
        private const string EnableReceiverTransactionTooltip = "Enable transactional behavior for message receivers.";
        private const string EnableSenderCommitTooltip = "Enable transaction commit for message senders.";
        private const string EnableReceiverCommitTooltip = "Enable transaction commit for message receivers.";
        private const string EnableMessageIdUpdateTooltip = "Enable automatic message id update.";
        private const string OneSessionPerSenderTaskTooltip = "Use one session per sender task.";
        private const string EnableMoveToDeadLetterTooltip = "When this option is enabled, all received messages are moved to the DeadLetter queue.";
        private const string EnableReadFromDeadLetterTooltip = "When this option is enabled, the receivers attempts to read messages from the DeadLetter queue.";
        #endregion

        #region Private Instance Fields
        private readonly TopicDescription topic;
        private readonly ServiceBusHelper serviceBusHelper;
        private readonly MainForm mainForm;
        private readonly WriteToLogDelegate writeToLog;
        private readonly List<SubscriptionDescription> subscriptionList;
        private readonly BindingSource bindingSource = new BindingSource();
        private int receiveTimeout = 60;
        private int sessionTimeout = 60;
        private int prefetchCount;
        private List<MessageSender> messageSenderCollection;
        private CancellationTokenSource senderCancellationTokenSource;
        private CancellationTokenSource receiverCancellationTokenSource;
        private CancellationTokenSource managerCancellationTokenSource;
        private ManualResetEventSlim managerResetEvent;
        private long messageCount = 1;
        private long senderMessageNumber;
        private double senderMessagesPerSecond;
        private double senderMinimumTime;
        private double senderMaximumTime;
        private double senderAverageTime;
        private double senderTotalTime;
        private long receiverMessageNumber;
        private double receiverMessagesPerSecond;
        private double receiverMinimumTime;
        private double receiverMaximumTime;
        private double receiverAverageTime;
        private double receiverTotalTime;
        private int actionCount;
        private long currentIndex;
        private int senderTaskCount = 1;
        private int receiverTaskCount = 1;
        private bool isSenderFaulted;
        private Filter filter;
        private BlockingCollection<Tuple<long, DirectionType>> blockingCollection;
        #endregion

        #region Private Static Fields
        private static readonly List<string> types = new List<string> { "Boolean", "Byte", "Int16", "Int32", "Int64", "Single", "Double", "Decimal", "Guid", "DateTime", "String" };
        #endregion

        #region Public Constructors
        public TestTopicControl(MainForm mainForm,
                                WriteToLogDelegate writeToLog,
                                ServiceBusHelper serviceBusHelper, 
                                TopicDescription topic, 
                                List<SubscriptionDescription> subscriptionList)
        {
            this.mainForm = mainForm;
            this.writeToLog = writeToLog;
            this.serviceBusHelper = serviceBusHelper;
            this.topic = topic;
            this.subscriptionList = subscriptionList;
            InitializeComponent();
            InitializeControls();
        } 
        #endregion

        #region Public Events
        public event Action OnCancel;
        #endregion

        #region Private Methods
        private void InitializeControls()
        {
            try
            {
                bindingSource.DataSource = MessagePropertyInfo.Properties;

                // Initialize body type combo
                cboBodyType.SelectedIndex = 0;

                // Initialize the DataGridView.
                propertiesDataGridView.AutoGenerateColumns = false;
                propertiesDataGridView.AutoSize = true;
                propertiesDataGridView.DataSource = bindingSource;
                propertiesDataGridView.ForeColor = SystemColors.WindowText;

                // Create the Name column
                DataGridViewColumn textBoxColumn = new DataGridViewTextBoxColumn();
                textBoxColumn.DataPropertyName = PropertyKey;
                textBoxColumn.Name = PropertyKey;
                textBoxColumn.Width = 90;
                propertiesDataGridView.Columns.Add(textBoxColumn);

                // Create the Type column
                var comboBoxColumn = new DataGridViewComboBoxColumn
                                         {
                                             DataSource = types,
                                             DataPropertyName = PropertyType,
                                             Name = PropertyType,
                                             Width = 80
                                         };
                propertiesDataGridView.Columns.Add(comboBoxColumn);

                // Create the Value column
                textBoxColumn = new DataGridViewTextBoxColumn
                                    {
                                        DataPropertyName = PropertyValue, 
                                        Name = PropertyValue, 
                                        Width = 102
                                    };
                propertiesDataGridView.Columns.Add(textBoxColumn);

                txtMessageText.Text = mainForm != null &&
                                      !string.IsNullOrEmpty(mainForm.MessageText) ? 
                                      mainForm.MessageText : 
                                      DefaultMessageText;
                txtLabel.Text = mainForm != null &&
                                !string.IsNullOrEmpty(mainForm.Label) ?
                                mainForm.Label :
                                DefaultMessageText;
                txtMessageId.Text = Guid.NewGuid().ToString();
                txtSessionId.Text = DefaultSessionId;
                txtMessageCount.Text = DefaultMessageCount;
                txtSendTaskCount.Text = DefaultSenderTaskCount;
                txtReceiveTaskCount.Text = DefaultReceiverTaskCount;
                txtReceiveTimeout.Text = mainForm != null ?
                                         mainForm.ReceiveTimeout.ToString(CultureInfo.InvariantCulture) :
                                         DefaultReceiveTimeout;
                txtSessionTimeout.Text = mainForm != null ?
                                         mainForm.SessionTimeout.ToString(CultureInfo.InvariantCulture) :
                                         DefaultSessionTimeout;
                txtPrefetchCount.Text = mainForm != null ?
                                        mainForm.PrefetchCount.ToString(CultureInfo.InvariantCulture) :
                                        DefaultPrefetchCount;
                if (subscriptionList != null &&
                    subscriptionList.Count > 0)
                {
                    cboSubscriptions.Items.AddRange(subscriptionList.Select(s => s.Name).ToArray());
                    if (cboSubscriptions.Items.Count > 0)
                    {
                        cboSubscriptions.SelectedIndex = 0;
                    }
                }
                cboReceivedMode.SelectedIndex = 0;

                // Create Tooltips for controls
                toolTip.SetToolTip(senderEnabledCheckBox, SenderEnabledToolTip);
                toolTip.SetToolTip(receiverEnabledCheckBox, ReceiverEnabledToolTip);
                toolTip.SetToolTip(txtMessageText, MessageTextTooltip);
                toolTip.SetToolTip(propertiesDataGridView, MessagePropertiesTooltip);
                toolTip.SetToolTip(txtLabel, LabelTooltip);
                toolTip.SetToolTip(txtMessageId, MessageIdTooltip);
                toolTip.SetToolTip(txtSessionId, SessionIdTooltip);
                toolTip.SetToolTip(txtCorrelationId, CorrelationIdTooltip);
                toolTip.SetToolTip(txtReplyTo, ReplyToTooltip);
                toolTip.SetToolTip(txtReplyToSessionId, ReplyToSessionIdTooltip);
                toolTip.SetToolTip(txtMessageCount, MessageCountTooltip);
                toolTip.SetToolTip(txtSendTaskCount, SendTaskCountTooltip);
                toolTip.SetToolTip(txtReceiveTaskCount, ReceiverTaskCountTooltip);
                toolTip.SetToolTip(checkBoxUpdateMessageId, UpdateMessageIdTooltip);
                toolTip.SetToolTip(txtReceiveTimeout, ReceiveTimeoutTooltip);
                toolTip.SetToolTip(txtSessionTimeout, SessionTimeoutTooltip);
                toolTip.SetToolTip(txtFilterExpression, FilterExpressionTooltip);
                toolTip.SetToolTip(txtTo, ToTooltip);
                toolTip.SetToolTip(txtContentType, ContentTypeTooltip);
                toolTip.SetToolTip(txtScheduledEnqueueTimeUtc, ScheduledEnqueueTimeUtcTooltip);
                toolTip.SetToolTip(cboSubscriptions, SubscriptionTooltip);
                toolTip.SetToolTip(checkBoxEnableSenderLogging, EnableSenderLoggingTooltip);
                toolTip.SetToolTip(checkBoxEnableReceiverLogging, EnableReceiverLoggingTooltip);
                toolTip.SetToolTip(checkBoxSenderVerboseLogging, EnableSenderVerboseLoggingTooltip);
                toolTip.SetToolTip(checkBoxReceiverVerboseLogging, EnableReceiverVerboseLoggingTooltip);
                toolTip.SetToolTip(checkBoxOneSessionPerTask, OneSessionPerSenderTaskTooltip);
                toolTip.SetToolTip(checkBoxSenderUseTransaction, EnableSenderTransactionTooltip);
                toolTip.SetToolTip(checkBoxReceiverUseTransaction, EnableReceiverTransactionTooltip);
                toolTip.SetToolTip(checkBoxSenderCommitTransaction, EnableSenderCommitTooltip);
                toolTip.SetToolTip(checkBoxReceiverCommitTransaction, EnableReceiverCommitTooltip);
                toolTip.SetToolTip(checkBoxUpdateMessageId, EnableMessageIdUpdateTooltip);
                toolTip.SetToolTip(checkBoxMoveToDeadLetter, EnableMoveToDeadLetterTooltip);
                toolTip.SetToolTip(checkBoxReadFromDeadLetter, EnableReadFromDeadLetterTooltip);
                toolTip.SetToolTip(cboReceivedMode, ReceiveModeTooltip);

                splitContainer.SplitterWidth = 16;
                propertiesDataGridView.Size = txtMessageText.Size;
            }
            catch (Exception ex)
            {
                if (mainForm != null)
                {
                    mainForm.HandleException(ex);
                }
            }
        }

        private bool ValidateParameters()
        {
            try
            {
                if (string.IsNullOrEmpty(txtMessageText.Text))
                {
                    writeToLog(MessageCannotBeNull);
                    return false;
                }
                int temp;
                if (string.IsNullOrEmpty(txtReceiveTimeout.Text) ||
                    !int.TryParse(txtReceiveTimeout.Text, out temp) ||
                    temp <= 0)
                {
                    writeToLog(ReceiveTimeoutCannotBeNull);
                    return false;
                }
                receiveTimeout = temp;
                if (string.IsNullOrEmpty(txtSessionTimeout.Text) ||
                    !int.TryParse(txtSessionTimeout.Text, out temp) ||
                    temp <= 0)
                {
                    writeToLog(SessionTimeoutCannotBeNull);
                    return false;
                }
                sessionTimeout = temp;
                if (string.IsNullOrEmpty(txtPrefetchCount.Text) ||
                    !int.TryParse(txtPrefetchCount.Text, out temp))
                {
                    writeToLog(PrefetchCountCannotBeNull);
                    return false;
                }
                prefetchCount = temp;
                if (!int.TryParse(txtMessageCount.Text, out temp) || temp < 0)
                {
                    writeToLog(MessageCountMustBeANumber);
                    return false;
                }
                messageCount = temp;
                if (!int.TryParse(txtSendTaskCount.Text, out temp) || temp <= 0)
                {
                    writeToLog(SendTaskCountMustBeANumber);
                    return false;
                }
                senderTaskCount = temp;
                if (!int.TryParse(txtReceiveTaskCount.Text, out temp) || temp <= 0)
                {
                    writeToLog(ReceiveTaskCountMustBeANumber);
                    return false;
                }
                receiverTaskCount = temp;
                var sqlFilter = new SqlFilter(!string.IsNullOrEmpty(txtFilterExpression.Text)
                                                                  ? txtFilterExpression.Text
                                                                  : DefaultFilterExpression);
                sqlFilter.Validate();
                filter = sqlFilter.Preprocess();
                if (filter == null)
                {
                    writeToLog(FilterExpressionIsNotValid);
                }
            }
            catch (Exception ex)
            {
                mainForm.HandleException(ex);
                return false;
            }
            return true;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnAction.Text == StopCaption)
                {
                    CancelActions();
                    btnAction.Text = StartCaption;
                    return;
                }

                if (serviceBusHelper != null &&
                    ValidateParameters())
                {
                    btnAction.Enabled = false;
                    Cursor.Current = Cursors.WaitCursor;
                    //*****************************************************************************************************
                    //                                   Retrieve Messaging Factory
                    //*****************************************************************************************************
                    var messagingFactory = serviceBusHelper.MessagingFactory;

                    //*****************************************************************************************************
                    //                                   Initialize Statistics and Manager Action
                    //*****************************************************************************************************
                    actionCount = 0;
                    senderMessageNumber = 0;
                    senderMessagesPerSecond = 0;
                    senderMinimumTime = long.MaxValue;
                    senderMaximumTime = 0;
                    senderAverageTime = 0;
                    senderTotalTime = 0;
                    receiverMessageNumber = 0;
                    receiverMessagesPerSecond = 0;
                    receiverMinimumTime = long.MaxValue;
                    receiverMaximumTime = 0;
                    receiverAverageTime = 0;
                    receiverTotalTime = 0;
                    if (checkBoxSenderEnableGraph.Checked ||
                        checkBoxReceiverEnableGraph.Checked)
                    {
                        chart.Series.ToList().ForEach(s => s.Points.Clear());
                    }
                    managerResetEvent = new ManualResetEventSlim(false);
                    Action<CancellationTokenSource> managerAction = cts =>
                    {
                        if (cts == null)
                        {
                            return;
                        }
                        managerResetEvent.Wait(cts.Token);
                        if (!cts.IsCancellationRequested)
                        {
                            Invoke((MethodInvoker)delegate { btnAction.Text = StartCaption; });
                        }
                    };

                    Action updateGraphAction = () =>
                    {
                        var ok = true;
                        while (actionCount > 1 || ok)
                        {
                            Tuple<long, DirectionType> tuple;
                            ok = blockingCollection.TryTake(out tuple, TimeSpan.FromSeconds(1));
                            if (!ok)
                            {
                                continue;
                            }
                            if (InvokeRequired)
                            {
                                Invoke(new UpdateStatisticsDelegate(InternalUpdateStatistics),
                                       new object[] { tuple.Item1, tuple.Item2 });
                            }
                            else
                            {
                                InternalUpdateStatistics(tuple.Item1, tuple.Item2);
                            }
                        }
                        if (Interlocked.Decrement(ref actionCount) == 0)
                        {
                            managerResetEvent.Set();
                        }
                    };

                    AsyncCallback updateGraphCallback = a =>
                    {
                        var action = a.AsyncState as Action;
                        if (action != null)
                        {
                            action.EndInvoke(a);
                            if (Interlocked.Decrement(ref actionCount) == 0)
                            {
                                managerResetEvent.Set();
                            }
                        }
                    };

                    blockingCollection = new BlockingCollection<Tuple<long, DirectionType>>();
                    //*****************************************************************************************************
                    //                                   Sending messages to a Topic
                    //*****************************************************************************************************

                    if (senderEnabledCheckBox.Checked && messageCount > 0)
                    {
                        // Create message senders. They are cached for later usage to improve performance.
                        if (isSenderFaulted ||
                            messageSenderCollection == null ||
                            messageSenderCollection.Count == 0 ||
                            messageSenderCollection.Count < senderTaskCount)
                        {
                            messageSenderCollection = new List<MessageSender>(senderTaskCount);
                            for (var i = 0; i < senderTaskCount; i++)
                            {
                                messageSenderCollection.Add(messagingFactory.CreateMessageSender(topic.Path));
                            }
                            isSenderFaulted = false;
                        }

                        // Create outbound message template
                        var messageTemplate = serviceBusHelper.CreateMessage(txtMessageText.Text,
                                                                             txtLabel.Text,
                                                                             txtContentType.Text,
                                                                             GetMessageId(),
                                                                             txtSessionId.Text,
                                                                             txtCorrelationId.Text,
                                                                             txtTo.Text,
                                                                             txtReplyTo.Text,
                                                                             txtReplyToSessionId.Text,
                                                                             txtTimeToLive.Text,
                                                                             txtScheduledEnqueueTimeUtc.Text,
                                                                             bindingSource.Cast<MessagePropertyInfo>());

                        try
                        {
                            senderCancellationTokenSource = new CancellationTokenSource();
                            currentIndex = 0;

                            BodyType bodyType;
                            if (!Enum.TryParse(cboBodyType.Text, true, out bodyType))
                            {
                                bodyType = BodyType.Stream;
                            }

                            Func<long> getMessageNumber = () =>
                            {
                                lock (this)
                                {
                                    return currentIndex++;
                                }
                            };
                            Action<int, BrokeredMessage> senderAction = (taskId, template) =>
                            {
                                try
                                {
                                    string traceMessage;
                                    bool ok;
                                    
                                    if (checkBoxSenderUseTransaction.Checked)
                                    {
                                        using (var scope = new TransactionScope())
                                        {
                                            ok = serviceBusHelper.SendMessages(messageSenderCollection[taskId],
                                                                               template,
                                                                               getMessageNumber,
                                                                               messageCount,
                                                                               txtMessageText.Text,
                                                                               taskId,
                                                                               checkBoxUpdateMessageId.Checked,
                                                                               checkBoxAddMessageNumber.Checked,
                                                                               checkBoxOneSessionPerTask.Checked,
                                                                               checkBoxEnableSenderLogging.Checked,
                                                                               checkBoxSenderVerboseLogging.Checked,
                                                                               checkBoxSenderEnableStatistics.Checked,
                                                                               bodyType,
                                                                               UpdateStatistics,
                                                                               senderCancellationTokenSource,
                                                                               out traceMessage);
                                            var builder = new StringBuilder(traceMessage);
                                            if (checkBoxSenderCommitTransaction.Checked)
                                            {
                                                scope.Complete();
                                                builder.AppendLine(TransactionCommitted);
                                            }
                                            else
                                            {
                                                builder.AppendLine(TransactionAborted);
                                            }
                                            traceMessage = builder.ToString();
                                        }
                                    }
                                    else
                                    {
                                        ok = serviceBusHelper.SendMessages(messageSenderCollection[taskId],
                                                                           template,
                                                                           getMessageNumber,
                                                                           messageCount,
                                                                           txtMessageText.Text,
                                                                           taskId,
                                                                           checkBoxUpdateMessageId.Checked,
                                                                           checkBoxAddMessageNumber.Checked,
                                                                           checkBoxOneSessionPerTask.Checked,
                                                                           checkBoxEnableSenderLogging.Checked,
                                                                           checkBoxSenderVerboseLogging.Checked,
                                                                           checkBoxSenderEnableStatistics.Checked,
                                                                           bodyType,
                                                                           UpdateStatistics,
                                                                           senderCancellationTokenSource,
                                                                           out traceMessage);
                                    }
                                    if (!string.IsNullOrEmpty(traceMessage))
                                    {
                                        writeToLog(traceMessage.Substring(0,
                                                                               traceMessage.
                                                                                   Length - 1));
                                    }
                                    isSenderFaulted = !ok;
                                }
                                catch (Exception ex)
                                {
                                    isSenderFaulted = true;
                                    HandleException(ex);
                                }
                            };

                            // Define Sender AsyncCallback
                            AsyncCallback senderCallback = a =>
                            {
                                var action = a.AsyncState as Action<int, BrokeredMessage>;
                                if (action != null)
                                {
                                    action.EndInvoke(a);
                                    if (Interlocked.Decrement(ref actionCount) == 0)
                                    {
                                        managerResetEvent.Set();
                                    }
                                }
                            };

                            // Start Sender Actions
                            for (var i = 0; i < Math.Min(messageCount, senderTaskCount); i++)
                            {
                                senderAction.BeginInvoke(i, messageTemplate, senderCallback, senderAction);
                                Interlocked.Increment(ref actionCount);
                            }
                        }
                        catch (Exception ex)
                        {
                            HandleException(ex);
                        }
                    }
                    
                    //*****************************************************************************************************
                    //                                   Receiving messages from a Subscription
                    //*****************************************************************************************************
                    if (receiverEnabledCheckBox.Checked)
                    {
                        var currentSubscription = subscriptionList.SingleOrDefault(s => s.Name == cboSubscriptions.Text);
                        if (currentSubscription == null)
                        {
                            throw new ArgumentException(NoSubscriptionSelected);
                        }
                        var currentReceiveMode = cboReceivedMode.Text == PeekLock ?
                                                                         ReceiveMode.PeekLock :
                                                                         ReceiveMode.ReceiveAndDelete;
                        var currentMoveToDeadLetterQueue = checkBoxMoveToDeadLetter.Checked;
                        var currentReadFromDeadLetterQueue = checkBoxReadFromDeadLetter.Checked;

                        try
                        {
                            receiverCancellationTokenSource = new CancellationTokenSource();
                            Action<int> receiverAction = taskId =>
                            {
                                var allSessionsAccepted = false;

                                while (!allSessionsAccepted)
                                {
                                    try
                                    {
                                        MessageReceiver messageReceiver;
                                        if (currentReadFromDeadLetterQueue)
                                        {
                                            messageReceiver =
                                                messagingFactory.CreateMessageReceiver(SubscriptionClient.FormatDeadLetterPath(currentSubscription.TopicPath, 
                                                                                                                               currentSubscription.Name),
                                                                                       currentReceiveMode);
                                        }
                                        else
                                        {
                                            if (currentSubscription.RequiresSession)
                                            {
                                                var subscriptionClient = messagingFactory.CreateSubscriptionClient(currentSubscription.TopicPath, 
                                                                                                                   currentSubscription.Name,
                                                                                                                   currentReceiveMode);
                                                messageReceiver = subscriptionClient.AcceptMessageSession(TimeSpan.FromSeconds(sessionTimeout));
                                            }
                                            else
                                            {
                                                messageReceiver = messagingFactory.CreateMessageReceiver(SubscriptionClient.FormatSubscriptionPath(currentSubscription.TopicPath,
                                                                                                                                                   currentSubscription.Name),
                                                                                                         currentReceiveMode);
                                            }
                                        }
                                        messageReceiver.PrefetchCount = prefetchCount;
                                        string traceMessage;
                                        if (checkBoxReceiverUseTransaction.Checked)
                                        {
                                            using (var scope = new TransactionScope())
                                            {
                                                serviceBusHelper.ReceiveMessages(messageReceiver,
                                                                                 taskId,
                                                                                 receiveTimeout,
                                                                                 filter,
                                                                                 currentMoveToDeadLetterQueue,
                                                                                 checkBoxCompleteReceive.Checked,
                                                                                 checkBoxDeferMessage.Checked,
                                                                                 checkBoxEnableReceiverLogging.Checked,
                                                                                 checkBoxReceiverVerboseLogging.Checked,
                                                                                 checkBoxReceiverEnableStatistics.Checked,
                                                                                 UpdateStatistics,
                                                                                 receiverCancellationTokenSource,
                                                                                 out traceMessage);
                                                var builder = new StringBuilder(traceMessage);
                                                if (checkBoxReceiverCommitTransaction.Checked)
                                                {
                                                    scope.Complete();
                                                    builder.AppendLine(TransactionCommitted);
                                                }
                                                else
                                                {
                                                    builder.AppendLine(TransactionAborted);
                                                }
                                                traceMessage = builder.ToString();
                                            }
                                        }
                                        else
                                        {
                                            serviceBusHelper.ReceiveMessages(messageReceiver,
                                                                             taskId,
                                                                             receiveTimeout,
                                                                             filter,
                                                                             currentMoveToDeadLetterQueue,
                                                                             checkBoxCompleteReceive.Checked,
                                                                             checkBoxDeferMessage.Checked,
                                                                             checkBoxEnableReceiverLogging.Checked,
                                                                             checkBoxReceiverVerboseLogging.Checked,
                                                                             checkBoxReceiverEnableStatistics.Checked,
                                                                             UpdateStatistics,
                                                                             receiverCancellationTokenSource,
                                                                             out traceMessage);
                                        }
                                        if (!string.IsNullOrEmpty(traceMessage))
                                        {
                                            writeToLog(traceMessage.Substring(0, traceMessage.Length - 1));
                                        }
                                        allSessionsAccepted = !currentSubscription.RequiresSession;
                                    }
                                    catch (TimeoutException ex)
                                    {
                                        if (currentSubscription.RequiresSession)
                                        {
                                            writeToLog(string.Format(NoMoreSessionsToAccept, taskId));
                                            allSessionsAccepted = true;
                                        }
                                        else
                                        {
                                            HandleException(ex);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        HandleException(ex);
                                    }
                                }
                            };

                            // Define Receiver AsyncCallback
                            AsyncCallback receiverCallback = a =>
                            {
                                var action = a.AsyncState as Action<int>;
                                if (action != null)
                                {
                                    action.EndInvoke(a);
                                    if (Interlocked.Decrement(ref actionCount) == 0)
                                    {
                                        managerResetEvent.Set();
                                    }
                                }
                            };

                            // Start Receiver Actions
                            for (var i = 0; i < receiverTaskCount; i++)
                            {
                                receiverAction.BeginInvoke(i, receiverCallback, receiverAction);
                                Interlocked.Increment(ref actionCount);
                            }
                        }
                        catch (Exception ex)
                        {
                            HandleException(ex);
                        }
                    }
                    if (actionCount > 0)
                    {
                        managerCancellationTokenSource = new CancellationTokenSource();
                        managerAction.BeginInvoke(managerCancellationTokenSource, null, null);
                        updateGraphAction.BeginInvoke(updateGraphCallback, updateGraphAction);
                        Interlocked.Increment(ref actionCount);
                        btnAction.Text = StopCaption;
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            finally
            {
                btnAction.Enabled = true;
                Cursor.Current = Cursors.Default;
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

        private string GetMessageId()
        {
            if (checkBoxUpdateMessageId.Checked)
            {
                return Guid.NewGuid().ToString();
            }
            if (!string.IsNullOrEmpty(txtMessageId.Text))
            {
                return txtMessageId.Text;
            }
            return Guid.NewGuid().ToString();
        }

        private void DrawTabControlTabs(TabControl tabControl, DrawItemEventArgs e, ImageList images)
        {
            // Get the bounding end of tab strip rectangles.
            var tabstripEndRect = tabControl.GetTabRect(tabControl.TabPages.Count - 1);
            var tabstripEndRectF = new RectangleF(tabstripEndRect.X + tabstripEndRect.Width, tabstripEndRect.Y - 5,
            tabControl.Width - (tabstripEndRect.X + tabstripEndRect.Width), tabstripEndRect.Height + 5);
            var leftVerticalLineRect = new RectangleF(2, tabstripEndRect.Y + tabstripEndRect.Height + 2, 2, tabControl.TabPages[tabControl.SelectedIndex].Height + 2);
            var rightVerticalLineRect = new RectangleF(tabControl.TabPages[tabControl.SelectedIndex].Width + 4, tabstripEndRect.Y + tabstripEndRect.Height + 2, 2, tabControl.TabPages[tabControl.SelectedIndex].Height + 2);
            var bottomHorizontalLineRect = new RectangleF(2, tabstripEndRect.Y + tabstripEndRect.Height + tabControl.TabPages[tabControl.SelectedIndex].Height + 2, tabControl.TabPages[tabControl.SelectedIndex].Width + 4, 2);
            RectangleF leftVerticalBarNearFirstTab = new Rectangle(0, 0, 2, tabstripEndRect.Height + 2);

            // First, do the end of the tab strip.
            // If we have an image use it.
            if (tabControl.Parent.BackgroundImage != null)
            {
                var src = new RectangleF(tabstripEndRectF.X + tabControl.Left, tabstripEndRectF.Y + tabControl.Top, tabstripEndRectF.Width, tabstripEndRectF.Height);
                e.Graphics.DrawImage(tabControl.Parent.BackgroundImage, tabstripEndRectF, src, GraphicsUnit.Pixel);
            }
            // If we have no image, use the background color.
            else
            {
                using (Brush backBrush = new SolidBrush(tabControl.Parent.BackColor))
                {
                    e.Graphics.FillRectangle(backBrush, tabstripEndRectF);
                    e.Graphics.FillRectangle(backBrush, leftVerticalLineRect);
                    e.Graphics.FillRectangle(backBrush, rightVerticalLineRect);
                    e.Graphics.FillRectangle(backBrush, bottomHorizontalLineRect);
                    if (mainTabControl.SelectedIndex != 0)
                    {
                        e.Graphics.FillRectangle(backBrush, leftVerticalBarNearFirstTab);
                    }
                }
            }

            // Set up the page and the various pieces.
            var page = tabControl.TabPages[e.Index];
            using (var backBrush = new SolidBrush(page.BackColor))
            {
                using (var foreBrush = new SolidBrush(page.ForeColor))
                {
                    var tabName = page.Text;

                    // Set up the offset for an icon, the bounding rectangle and image size and then fill the background.
                    var iconOffset = 0;
                    Rectangle tabBackgroundRect;

                    if (e.Index == mainTabControl.SelectedIndex)
                    {
                        tabBackgroundRect = e.Bounds;
                        e.Graphics.FillRectangle(backBrush, tabBackgroundRect);
                    }
                    else
                    {
                        tabBackgroundRect = new Rectangle(e.Bounds.X, e.Bounds.Y - 2, e.Bounds.Width,
                                                          e.Bounds.Height + 4);
                        e.Graphics.FillRectangle(backBrush, tabBackgroundRect);
                        var rect = new Rectangle(e.Bounds.X - 2, e.Bounds.Y - 2, 1, 2);
                        e.Graphics.FillRectangle(backBrush, rect);
                        rect = new Rectangle(e.Bounds.X - 1, e.Bounds.Y - 2, 1, 2);
                        e.Graphics.FillRectangle(backBrush, rect);
                        rect = new Rectangle(e.Bounds.X + e.Bounds.Width, e.Bounds.Y - 2, 1, 2);
                        e.Graphics.FillRectangle(backBrush, rect);
                        rect = new Rectangle(e.Bounds.X + e.Bounds.Width + 1, e.Bounds.Y - 2, 1, 2);
                        e.Graphics.FillRectangle(backBrush, rect);
                    }

                    // If we have images, process them.
                    if (images != null)
                    {
                        // Get sice and image.
                        var size = images.ImageSize;
                        Image icon = null;
                        if (page.ImageIndex > -1)
                            icon = images.Images[page.ImageIndex];
                        else if (page.ImageKey != "")
                            icon = images.Images[page.ImageKey];

                        // If there is an image, use it.
                        if (icon != null)
                        {
                            var startPoint =
                                new Point(tabBackgroundRect.X + 2 + ((tabBackgroundRect.Height - size.Height) / 2),
                                          tabBackgroundRect.Y + 2 + ((tabBackgroundRect.Height - size.Height) / 2));
                            e.Graphics.DrawImage(icon, new Rectangle(startPoint, size));
                            iconOffset = size.Width + 4;
                        }
                    }

                    // Draw out the label.
                    var labelRect = new Rectangle(tabBackgroundRect.X + iconOffset, tabBackgroundRect.Y + 3,
                                                  tabBackgroundRect.Width - iconOffset, tabBackgroundRect.Height - 3);
                    using (var sf = new StringFormat { Alignment = StringAlignment.Center })
                    {
                        e.Graphics.DrawString(tabName, e.Font, foreBrush, labelRect, sf);
                    }
                }
            }
        }

        internal void CancelActions()
        {
            if (managerCancellationTokenSource != null)
            {
                managerCancellationTokenSource.Cancel();
            }
            if (senderCancellationTokenSource != null)
            {
                senderCancellationTokenSource.Cancel();
            }
            if (receiverCancellationTokenSource != null)
            {
                receiverCancellationTokenSource.Cancel();
            }
        }

        internal void btnCancel_Click(object sender, EventArgs e)
        {
            CancelActions();
            OnCancel();
        }

        private void mainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            DrawTabControlTabs(mainTabControl, e, null);
        }

        private void senderEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            grouperSender.Enabled = senderEnabledCheckBox.Checked;
            SetGraphLayout();
        }

        private void receiverEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            grouperReceiver.Enabled = receiverEnabledCheckBox.Checked;
            SetGraphLayout();
        }

        private void checkBoxEnableSenderLogging_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSenderVerboseLogging.Enabled = checkBoxEnableSenderLogging.Checked;
        }

        private void checkBoxEnableReceiverLogging_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxReceiverVerboseLogging.Enabled = checkBoxEnableReceiverLogging.Checked;
        }

        private void checkBoxSenderUseTransaction_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSenderCommitTransaction.Enabled = checkBoxSenderUseTransaction.Checked;
        }

        private void checkBoxReceiverUseTransaction_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxReceiverCommitTransaction.Enabled = checkBoxReceiverUseTransaction.Checked;
        }

        private void checkBoxMoveToDeadLetter_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxReadFromDeadLetter.Enabled = !checkBoxMoveToDeadLetter.Checked;
            checkBoxReadFromDeadLetter.Checked = false;
            checkBoxDeferMessage.Enabled = !checkBoxMoveToDeadLetter.Checked;
            checkBoxDeferMessage.Checked = false;
        }

        private void checkBoxReadFromDeadLetter_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMoveToDeadLetter.Enabled = !checkBoxReadFromDeadLetter.Checked;
            checkBoxMoveToDeadLetter.Checked = false;
            checkBoxDeferMessage.Enabled = !checkBoxReadFromDeadLetter.Checked;
            checkBoxDeferMessage.Checked = false;
        }

        private void checkBoxDeferMessage_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMoveToDeadLetter.Enabled = !checkBoxDeferMessage.Checked;
            checkBoxMoveToDeadLetter.Checked = false;
            checkBoxReadFromDeadLetter.Enabled = !checkBoxDeferMessage.Checked;
            checkBoxReadFromDeadLetter.Checked = false;
        }

        private void cboReceivedMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkBoxCompleteReceive.Enabled = cboReceivedMode.Text == PeekLock;
        }

        private void checkBoxSenderEnableStatistics_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxSenderEnableGraph.Enabled = checkBoxSenderEnableStatistics.Checked;
        }

        private void checkBoxReceiverEnableStatistics_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxReceiverEnableGraph.Enabled = checkBoxReceiverEnableStatistics.Checked;
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK &&
                    !string.IsNullOrEmpty(openFileDialog.FileName) &&
                    File.Exists(openFileDialog.FileName))
                {
                    using (var reader = new StreamReader(openFileDialog.FileName))
                    {
                        var text = reader.ReadToEnd();
                        if (!string.IsNullOrEmpty(text))
                        {
                            txtMessageText.Text = text;
                            if (mainForm != null)
                            {
                                mainForm.MessageText = text;
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

        private void txtLabel_TextChanged(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.Label = txtLabel.Text;
            }
        }

        /// <summary>
        /// Updates the statistics and graph on the control.
        /// </summary>
        /// <param name="elapsedMilliseconds">Elapsed time.</param>
        /// <param name="direction">The direction of the I/O operation: Send or Receive.</param>
        private void UpdateStatistics(long elapsedMilliseconds, DirectionType direction)
        {
            blockingCollection.Add(new Tuple<long, DirectionType>(elapsedMilliseconds, direction));
        }

        /// <summary>
        /// Updates the statistics and graph on the control.
        /// </summary>
        /// <param name="elapsedMilliseconds">Elapsed time.</param>
        /// <param name="direction">The direction of the I/O operation: Send or Receive.</param>
        private void InternalUpdateStatistics(long elapsedMilliseconds, DirectionType direction)
        {
            lock (this)
            {
                var elapsedSeconds = (double)elapsedMilliseconds / 1000;

                if (direction == DirectionType.Send)
                {
                    if (elapsedSeconds > senderMaximumTime)
                    {
                        senderMaximumTime = elapsedSeconds;
                    }
                    if (elapsedSeconds < senderMinimumTime)
                    {
                        senderMinimumTime = elapsedSeconds;
                    }
                    senderTotalTime += elapsedSeconds;
                    senderMessageNumber++;
                    senderAverageTime = senderMessageNumber > 0 ? senderTotalTime / senderMessageNumber : 0;
                    senderMessagesPerSecond = senderTotalTime > 0 ? senderMessageNumber * senderTaskCount / senderTotalTime : 0;

                    lblSenderLastTime.Text = string.Format(LabelFormat, elapsedSeconds);
                    lblSenderLastTime.Refresh();
                    lblSenderAverageTime.Text = string.Format(LabelFormat, senderAverageTime);
                    lblSenderAverageTime.Refresh();
                    lblSenderMaximumTime.Text = string.Format(LabelFormat, senderMaximumTime);
                    lblSenderMaximumTime.Refresh();
                    lblSenderMinimumTime.Text = string.Format(LabelFormat, senderMinimumTime);
                    lblSenderMinimumTime.Refresh();
                    lblSenderMessagesPerSecond.Text = string.Format(LabelFormat, senderMessagesPerSecond);
                    lblSenderMessagesPerSecond.Refresh();
                    lblSenderMessageNumber.Text = senderMessageNumber.ToString(CultureInfo.InvariantCulture);
                    lblSenderMessageNumber.Refresh();

                    if (checkBoxSenderEnableGraph.Checked)
                    {
                        chart.Series["SenderLatency"].Points.AddY(elapsedSeconds);
                        chart.Series["SenderThroughput"].Points.AddY(senderMessagesPerSecond);
                    }
                }
                else
                {
                    if (elapsedSeconds > receiverMaximumTime)
                    {
                        receiverMaximumTime = elapsedSeconds;
                    }
                    if (elapsedSeconds < receiverMinimumTime)
                    {
                        receiverMinimumTime = elapsedSeconds;
                    }
                    receiverTotalTime += elapsedSeconds;
                    receiverMessageNumber++;
                    receiverAverageTime = receiverMessageNumber > 0 ? receiverTotalTime / receiverMessageNumber : 0;
                    receiverMessagesPerSecond = receiverTotalTime > 0 ? receiverMessageNumber * receiverTaskCount / receiverTotalTime : 0;

                    lblReceiverLastTime.Text = string.Format(LabelFormat, elapsedSeconds);
                    lblReceiverLastTime.Refresh();
                    lblReceiverAverageTime.Text = string.Format(LabelFormat, receiverAverageTime);
                    lblReceiverAverageTime.Refresh();
                    lblReceiverMaximumTime.Text = string.Format(LabelFormat, receiverMaximumTime);
                    lblReceiverMaximumTime.Refresh();
                    lblReceiverMinimumTime.Text = string.Format(LabelFormat, receiverMinimumTime);
                    lblReceiverMinimumTime.Refresh();
                    lblReceiverMessagesPerSecond.Text = string.Format(LabelFormat, receiverMessagesPerSecond);
                    lblReceiverMessagesPerSecond.Refresh();
                    lblReceiverMessageNumber.Text = receiverMessageNumber.ToString(CultureInfo.InvariantCulture);
                    lblReceiverMessageNumber.Refresh();

                    if (checkBoxReceiverEnableGraph.Checked)
                    {
                        chart.Series["ReceiverLatency"].Points.AddY(elapsedSeconds);
                        chart.Series["ReceiverThroughput"].Points.AddY(receiverMessagesPerSecond);
                    }
                }
            }
        }

        private void txtMessageText_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMessageText.Text))
            {
                mainForm.MessageText = txtMessageText.Text;
            }
        }

        private void SetGraphLayout()
        {
            var text = string.Empty;
            chart.Series.Clear();
            if (!senderEnabledCheckBox.Checked &&
                !receiverEnabledCheckBox.Checked)
            {
                grouperSenderStatistics.Visible = false;
                grouperReceiverStatistics.Visible = false;
                chart.Visible = false;
                return;
            }

            if (senderEnabledCheckBox.Checked)
            {
                var series1 = new Series();
                var series3 = new Series();

                series1.BorderColor = Color.FromArgb(180, 26, 59, 105);
                series1.BorderWidth = 2;
                series1.ChartArea = "Default";
                series1.ChartType = SeriesChartType.FastLine;
                series1.Legend = "Default";
                series1.LegendText = "Sender Latency";
                series1.Name = "SenderLatency";

                series3.BorderWidth = 2;
                series3.ChartArea = "Default";
                series3.ChartType = SeriesChartType.FastLine;
                series3.Legend = "Default";
                series3.LegendText = "Sender Throughput";
                series3.Name = "SenderThroughput";

                chart.Series.Add(series1);
                chart.Series.Add(series3);
                chart.Visible = true;
                text = "Sender Performance Counters";
                grouperSenderStatistics.Visible = true;
            }
            else
            {
                grouperSenderStatistics.Visible = false;
                chart.Visible = true;
                chart.Size = new Size(tabPageGraph.Width - 160,
                                      tabPageGraph.Height - 22);
            }

            if (receiverEnabledCheckBox.Checked)
            {
                var series2 = new Series();
                var series4 = new Series();

                series2.BorderColor = Color.Red;
                series2.BorderWidth = 2;
                series2.ChartArea = "Default";
                series2.ChartType = SeriesChartType.FastLine;
                series2.Legend = "Default";
                series2.LegendText = "Receiver Latency";
                series2.Name = "ReceiverLatency";
                
                series4.BorderWidth = 2;
                series4.ChartArea = "Default";
                series4.ChartType = SeriesChartType.FastLine;
                series4.Legend = "Default";
                series4.LegendText = "Receiver Throughput";
                series4.Name = "ReceiverThroughput";

                chart.Series.Add(series2);
                chart.Series.Add(series4);
                chart.Visible = true;
                text = "Receiver Performance Counters";
                if (senderEnabledCheckBox.Checked)
                {
                    chart.Size = new Size(tabPageGraph.Width - 304,
                                          tabPageGraph.Height - 22);
                }
                grouperReceiverStatistics.Location = senderEnabledCheckBox.Checked ?
                                                   new Point(grouperSenderStatistics.Width + chart.Width + 32, 8) :
                                                   new Point(16, 8);
                grouperReceiverStatistics.Anchor = senderEnabledCheckBox.Checked
                                                     ? AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Right
                                                     : AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left;
                grouperReceiverStatistics.Visible = true;
            }
            else
            {
                grouperReceiverStatistics.Visible = false;
                chart.Visible = true;
                chart.Size = new Size(tabPageGraph.Width - 160,
                                      tabPageGraph.Height - 22);
            }

            if (senderEnabledCheckBox.Checked && receiverEnabledCheckBox.Checked)
            {
                text = "Sender & Receiver Performance Counters";
            }

            var title = new Title
            {
                Font = new Font("Microsoft Sans Serif", 8.25F,
                                FontStyle.Regular,
                                GraphicsUnit.Point,
                                0),
                Name = "Title",
                ShadowColor = Color.Transparent,
                ShadowOffset = 1,
                Text = text
            };

            chart.Titles.Clear();
            chart.Titles.Add(title);
            tabPageGraph.Refresh();
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
