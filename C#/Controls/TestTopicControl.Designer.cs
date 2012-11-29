namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    partial class TestTopicControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabMessagePage = new System.Windows.Forms.TabPage();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.grouperMessageText = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.txtMessageText = new System.Windows.Forms.TextBox();
            this.grouperMessageProperties = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.propertiesDataGridView = new System.Windows.Forms.DataGridView();
            this.mainTabSenderPage = new System.Windows.Forms.TabPage();
            this.senderEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.grouperSender = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.lblBody = new System.Windows.Forms.Label();
            this.cboBodyType = new System.Windows.Forms.ComboBox();
            this.lblContentType = new System.Windows.Forms.Label();
            this.txtContentType = new System.Windows.Forms.TextBox();
            this.txtScheduledEnqueueTimeUtc = new System.Windows.Forms.TextBox();
            this.lblScheduledEnqueueTimeUtc = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.checkBoxSenderEnableGraph = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderEnableStatistics = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableSenderLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxAddMessageNumber = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderVerboseLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderCommitTransaction = new System.Windows.Forms.CheckBox();
            this.checkBoxSenderUseTransaction = new System.Windows.Forms.CheckBox();
            this.checkBoxOneSessionPerTask = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdateMessageId = new System.Windows.Forms.CheckBox();
            this.txtTimeToLive = new System.Windows.Forms.TextBox();
            this.lblTimeToLive = new System.Windows.Forms.Label();
            this.lblReplyToSessionId = new System.Windows.Forms.Label();
            this.txtReplyToSessionId = new System.Windows.Forms.TextBox();
            this.lblReplyTo = new System.Windows.Forms.Label();
            this.txtReplyTo = new System.Windows.Forms.TextBox();
            this.txtCorrelationId = new System.Windows.Forms.TextBox();
            this.lblCorrelationId = new System.Windows.Forms.Label();
            this.lblSession = new System.Windows.Forms.Label();
            this.txtSessionId = new System.Windows.Forms.TextBox();
            this.lblSendTaskCount = new System.Windows.Forms.Label();
            this.txtSendTaskCount = new System.Windows.Forms.TextBox();
            this.lblLabel = new System.Windows.Forms.Label();
            this.txtLabel = new System.Windows.Forms.TextBox();
            this.txtMessageCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblMessageId = new System.Windows.Forms.Label();
            this.txtMessageId = new System.Windows.Forms.TextBox();
            this.mainTabReceiverPage = new System.Windows.Forms.TabPage();
            this.receiverEnabledCheckBox = new System.Windows.Forms.CheckBox();
            this.grouperReceiver = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.cboSubscriptions = new System.Windows.Forms.ComboBox();
            this.lblSubscription = new System.Windows.Forms.Label();
            this.txtPrefetchCount = new System.Windows.Forms.TextBox();
            this.lblPrefetchCount = new System.Windows.Forms.Label();
            this.txtReceiveTimeout = new System.Windows.Forms.TextBox();
            this.txtSessionTimeout = new System.Windows.Forms.TextBox();
            this.lblSessionTimeout = new System.Windows.Forms.Label();
            this.checkBoxDeferMessage = new System.Windows.Forms.CheckBox();
            this.txtFilterExpression = new System.Windows.Forms.TextBox();
            this.lblFilterExpr = new System.Windows.Forms.Label();
            this.checkBoxReceiverEnableGraph = new System.Windows.Forms.CheckBox();
            this.checkBoxCompleteReceive = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverEnableStatistics = new System.Windows.Forms.CheckBox();
            this.cboReceivedMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxReadFromDeadLetter = new System.Windows.Forms.CheckBox();
            this.checkBoxMoveToDeadLetter = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverVerboseLogging = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverCommitTransaction = new System.Windows.Forms.CheckBox();
            this.checkBoxReceiverUseTransaction = new System.Windows.Forms.CheckBox();
            this.lblReceiveTaskCount = new System.Windows.Forms.Label();
            this.txtReceiveTaskCount = new System.Windows.Forms.TextBox();
            this.lblServerWaitTime = new System.Windows.Forms.Label();
            this.checkBoxEnableReceiverLogging = new System.Windows.Forms.CheckBox();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.grouperReceiverStatistics = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverLastTime = new System.Windows.Forms.Label();
            this.lblReceiverLastCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverAverageTime = new System.Windows.Forms.Label();
            this.lblReceiverAverageCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverMinimumTime = new System.Windows.Forms.Label();
            this.lblReceiverMinimumCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverMaximumTime = new System.Windows.Forms.Label();
            this.lblReceiverMaximumCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverMessagesPerSecond = new System.Windows.Forms.Label();
            this.lblReceiverMessagesPerSecondCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lblReceiverMessageNumber = new System.Windows.Forms.Label();
            this.lblReceiverCallsSuccessedCaption = new System.Windows.Forms.Label();
            this.grouperSenderStatistics = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderAverageTime = new System.Windows.Forms.Label();
            this.lblSenderAverageCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderLastTime = new System.Windows.Forms.Label();
            this.lblSenderLastCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderMinimumTime = new System.Windows.Forms.Label();
            this.lblSenderMinimumCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderMaximumTime = new System.Windows.Forms.Label();
            this.lblSenderMaximumCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderMessagesPerSecond = new System.Windows.Forms.Label();
            this.lblSenderMessagesPerSecondCaption = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSenderMessageNumber = new System.Windows.Forms.Label();
            this.lblSenderCallsSuccessedCaption = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl.SuspendLayout();
            this.mainTabMessagePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grouperMessageText.SuspendLayout();
            this.grouperMessageProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).BeginInit();
            this.mainTabSenderPage.SuspendLayout();
            this.grouperSender.SuspendLayout();
            this.mainTabReceiverPage.SuspendLayout();
            this.grouperReceiver.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.grouperReceiverStatistics.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.grouperSenderStatistics.SuspendLayout();
            this.mainTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnAction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAction.Location = new System.Drawing.Point(648, 304);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(72, 24);
            this.btnAction.TabIndex = 1;
            this.btnAction.Text = "Start";
            this.btnAction.UseVisualStyleBackColor = false;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            this.btnAction.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnAction.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancel.Location = new System.Drawing.Point(728, 304);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(72, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.mainTabMessagePage);
            this.mainTabControl.Controls.Add(this.mainTabSenderPage);
            this.mainTabControl.Controls.Add(this.mainTabReceiverPage);
            this.mainTabControl.Controls.Add(this.tabPageGraph);
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.Location = new System.Drawing.Point(16, 16);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(784, 280);
            this.mainTabControl.TabIndex = 11;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // mainTabMessagePage
            // 
            this.mainTabMessagePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainTabMessagePage.Controls.Add(this.splitContainer);
            this.mainTabMessagePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTabMessagePage.Location = new System.Drawing.Point(4, 22);
            this.mainTabMessagePage.Name = "mainTabMessagePage";
            this.mainTabMessagePage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabMessagePage.Size = new System.Drawing.Size(776, 254);
            this.mainTabMessagePage.TabIndex = 0;
            this.mainTabMessagePage.Text = "Message";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(16, 8);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.grouperMessageText);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.grouperMessageProperties);
            this.splitContainer.Size = new System.Drawing.Size(744, 232);
            this.splitContainer.SplitterDistance = 364;
            this.splitContainer.SplitterWidth = 16;
            this.splitContainer.TabIndex = 2;
            // 
            // grouperMessageText
            // 
            this.grouperMessageText.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperMessageText.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperMessageText.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperMessageText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageText.BorderThickness = 1F;
            this.grouperMessageText.Controls.Add(this.txtMessageText);
            this.grouperMessageText.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouperMessageText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperMessageText.ForeColor = System.Drawing.Color.White;
            this.grouperMessageText.GroupImage = null;
            this.grouperMessageText.GroupTitle = "Message Text";
            this.grouperMessageText.Location = new System.Drawing.Point(0, 0);
            this.grouperMessageText.Name = "grouperMessageText";
            this.grouperMessageText.Padding = new System.Windows.Forms.Padding(20);
            this.grouperMessageText.PaintGroupBox = true;
            this.grouperMessageText.RoundCorners = 4;
            this.grouperMessageText.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperMessageText.ShadowControl = false;
            this.grouperMessageText.ShadowThickness = 1;
            this.grouperMessageText.Size = new System.Drawing.Size(364, 232);
            this.grouperMessageText.TabIndex = 13;
            // 
            // txtMessageText
            // 
            this.txtMessageText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageText.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessageText.Location = new System.Drawing.Point(16, 32);
            this.txtMessageText.Multiline = true;
            this.txtMessageText.Name = "txtMessageText";
            this.txtMessageText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMessageText.Size = new System.Drawing.Size(332, 184);
            this.txtMessageText.TabIndex = 11;
            this.txtMessageText.TextChanged += new System.EventHandler(this.txtMessageText_TextChanged);
            // 
            // grouperMessageProperties
            // 
            this.grouperMessageProperties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperMessageProperties.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperMessageProperties.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperMessageProperties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageProperties.BorderThickness = 1F;
            this.grouperMessageProperties.Controls.Add(this.propertiesDataGridView);
            this.grouperMessageProperties.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperMessageProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grouperMessageProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperMessageProperties.ForeColor = System.Drawing.Color.White;
            this.grouperMessageProperties.GroupImage = null;
            this.grouperMessageProperties.GroupTitle = "Message Properties";
            this.grouperMessageProperties.Location = new System.Drawing.Point(0, 0);
            this.grouperMessageProperties.Name = "grouperMessageProperties";
            this.grouperMessageProperties.Padding = new System.Windows.Forms.Padding(20);
            this.grouperMessageProperties.PaintGroupBox = true;
            this.grouperMessageProperties.RoundCorners = 4;
            this.grouperMessageProperties.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperMessageProperties.ShadowControl = false;
            this.grouperMessageProperties.ShadowThickness = 1;
            this.grouperMessageProperties.Size = new System.Drawing.Size(364, 232);
            this.grouperMessageProperties.TabIndex = 15;
            // 
            // propertiesDataGridView
            // 
            this.propertiesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.propertiesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.propertiesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.propertiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertiesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.propertiesDataGridView.Location = new System.Drawing.Point(16, 32);
            this.propertiesDataGridView.Name = "propertiesDataGridView";
            this.propertiesDataGridView.Size = new System.Drawing.Size(332, 184);
            this.propertiesDataGridView.TabIndex = 10;
            // 
            // mainTabSenderPage
            // 
            this.mainTabSenderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainTabSenderPage.Controls.Add(this.senderEnabledCheckBox);
            this.mainTabSenderPage.Controls.Add(this.grouperSender);
            this.mainTabSenderPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTabSenderPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabSenderPage.Name = "mainTabSenderPage";
            this.mainTabSenderPage.Padding = new System.Windows.Forms.Padding(3);
            this.mainTabSenderPage.Size = new System.Drawing.Size(776, 254);
            this.mainTabSenderPage.TabIndex = 1;
            this.mainTabSenderPage.Text = "Sender";
            // 
            // senderEnabledCheckBox
            // 
            this.senderEnabledCheckBox.AutoSize = true;
            this.senderEnabledCheckBox.Checked = true;
            this.senderEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.senderEnabledCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.senderEnabledCheckBox.Location = new System.Drawing.Point(696, 12);
            this.senderEnabledCheckBox.Name = "senderEnabledCheckBox";
            this.senderEnabledCheckBox.Size = new System.Drawing.Size(68, 17);
            this.senderEnabledCheckBox.TabIndex = 14;
            this.senderEnabledCheckBox.Text = "Enabled:";
            this.senderEnabledCheckBox.UseVisualStyleBackColor = true;
            this.senderEnabledCheckBox.CheckedChanged += new System.EventHandler(this.senderEnabledCheckBox_CheckedChanged);
            // 
            // grouperSender
            // 
            this.grouperSender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperSender.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperSender.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperSender.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperSender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperSender.BorderThickness = 1F;
            this.grouperSender.Controls.Add(this.lblBody);
            this.grouperSender.Controls.Add(this.cboBodyType);
            this.grouperSender.Controls.Add(this.lblContentType);
            this.grouperSender.Controls.Add(this.txtContentType);
            this.grouperSender.Controls.Add(this.txtScheduledEnqueueTimeUtc);
            this.grouperSender.Controls.Add(this.lblScheduledEnqueueTimeUtc);
            this.grouperSender.Controls.Add(this.txtTo);
            this.grouperSender.Controls.Add(this.lblTo);
            this.grouperSender.Controls.Add(this.checkBoxSenderEnableGraph);
            this.grouperSender.Controls.Add(this.checkBoxSenderEnableStatistics);
            this.grouperSender.Controls.Add(this.checkBoxEnableSenderLogging);
            this.grouperSender.Controls.Add(this.checkBoxAddMessageNumber);
            this.grouperSender.Controls.Add(this.checkBoxSenderVerboseLogging);
            this.grouperSender.Controls.Add(this.checkBoxSenderCommitTransaction);
            this.grouperSender.Controls.Add(this.checkBoxSenderUseTransaction);
            this.grouperSender.Controls.Add(this.checkBoxOneSessionPerTask);
            this.grouperSender.Controls.Add(this.checkBoxUpdateMessageId);
            this.grouperSender.Controls.Add(this.txtTimeToLive);
            this.grouperSender.Controls.Add(this.lblTimeToLive);
            this.grouperSender.Controls.Add(this.lblReplyToSessionId);
            this.grouperSender.Controls.Add(this.txtReplyToSessionId);
            this.grouperSender.Controls.Add(this.lblReplyTo);
            this.grouperSender.Controls.Add(this.txtReplyTo);
            this.grouperSender.Controls.Add(this.txtCorrelationId);
            this.grouperSender.Controls.Add(this.lblCorrelationId);
            this.grouperSender.Controls.Add(this.lblSession);
            this.grouperSender.Controls.Add(this.txtSessionId);
            this.grouperSender.Controls.Add(this.lblSendTaskCount);
            this.grouperSender.Controls.Add(this.txtSendTaskCount);
            this.grouperSender.Controls.Add(this.lblLabel);
            this.grouperSender.Controls.Add(this.txtLabel);
            this.grouperSender.Controls.Add(this.txtMessageCount);
            this.grouperSender.Controls.Add(this.lblCount);
            this.grouperSender.Controls.Add(this.lblMessageId);
            this.grouperSender.Controls.Add(this.txtMessageId);
            this.grouperSender.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperSender.ForeColor = System.Drawing.Color.White;
            this.grouperSender.GroupImage = null;
            this.grouperSender.GroupTitle = "Configuration";
            this.grouperSender.Location = new System.Drawing.Point(16, 24);
            this.grouperSender.Name = "grouperSender";
            this.grouperSender.Padding = new System.Windows.Forms.Padding(20);
            this.grouperSender.PaintGroupBox = true;
            this.grouperSender.RoundCorners = 4;
            this.grouperSender.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperSender.ShadowControl = false;
            this.grouperSender.ShadowThickness = 1;
            this.grouperSender.Size = new System.Drawing.Size(744, 216);
            this.grouperSender.TabIndex = 15;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBody.Location = new System.Drawing.Point(584, 140);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(61, 13);
            this.lblBody.TabIndex = 48;
            this.lblBody.Text = "Body Type:";
            // 
            // cboBodyType
            // 
            this.cboBodyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBodyType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBodyType.FormattingEnabled = true;
            this.cboBodyType.Items.AddRange(new object[] {
            "Stream",
            "String",
            "WCF"});
            this.cboBodyType.Location = new System.Drawing.Point(672, 136);
            this.cboBodyType.Name = "cboBodyType";
            this.cboBodyType.Size = new System.Drawing.Size(56, 21);
            this.cboBodyType.TabIndex = 71;
            // 
            // lblContentType
            // 
            this.lblContentType.AutoSize = true;
            this.lblContentType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblContentType.Location = new System.Drawing.Point(192, 108);
            this.lblContentType.Name = "lblContentType";
            this.lblContentType.Size = new System.Drawing.Size(71, 13);
            this.lblContentType.TabIndex = 70;
            this.lblContentType.Text = "ContentType:";
            // 
            // txtContentType
            // 
            this.txtContentType.Location = new System.Drawing.Point(264, 104);
            this.txtContentType.Name = "txtContentType";
            this.txtContentType.Size = new System.Drawing.Size(108, 20);
            this.txtContentType.TabIndex = 49;
            // 
            // txtScheduledEnqueueTimeUtc
            // 
            this.txtScheduledEnqueueTimeUtc.Location = new System.Drawing.Point(472, 104);
            this.txtScheduledEnqueueTimeUtc.Name = "txtScheduledEnqueueTimeUtc";
            this.txtScheduledEnqueueTimeUtc.Size = new System.Drawing.Size(108, 20);
            this.txtScheduledEnqueueTimeUtc.TabIndex = 50;
            // 
            // lblScheduledEnqueueTimeUtc
            // 
            this.lblScheduledEnqueueTimeUtc.AutoSize = true;
            this.lblScheduledEnqueueTimeUtc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblScheduledEnqueueTimeUtc.Location = new System.Drawing.Point(376, 108);
            this.lblScheduledEnqueueTimeUtc.Name = "lblScheduledEnqueueTimeUtc";
            this.lblScheduledEnqueueTimeUtc.Size = new System.Drawing.Size(69, 13);
            this.lblScheduledEnqueueTimeUtc.TabIndex = 58;
            this.lblScheduledEnqueueTimeUtc.Text = "Schedule (s):";
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(80, 72);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(108, 20);
            this.txtTo.TabIndex = 42;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTo.Location = new System.Drawing.Point(16, 76);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 13);
            this.lblTo.TabIndex = 69;
            this.lblTo.Text = "To:";
            // 
            // checkBoxSenderEnableGraph
            // 
            this.checkBoxSenderEnableGraph.AutoSize = true;
            this.checkBoxSenderEnableGraph.Enabled = false;
            this.checkBoxSenderEnableGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderEnableGraph.Location = new System.Drawing.Point(320, 172);
            this.checkBoxSenderEnableGraph.Name = "checkBoxSenderEnableGraph";
            this.checkBoxSenderEnableGraph.Size = new System.Drawing.Size(91, 17);
            this.checkBoxSenderEnableGraph.TabIndex = 61;
            this.checkBoxSenderEnableGraph.Text = "Enable Graph";
            this.checkBoxSenderEnableGraph.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenderEnableStatistics
            // 
            this.checkBoxSenderEnableStatistics.AutoSize = true;
            this.checkBoxSenderEnableStatistics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderEnableStatistics.Location = new System.Drawing.Point(320, 140);
            this.checkBoxSenderEnableStatistics.Name = "checkBoxSenderEnableStatistics";
            this.checkBoxSenderEnableStatistics.Size = new System.Drawing.Size(104, 17);
            this.checkBoxSenderEnableStatistics.TabIndex = 54;
            this.checkBoxSenderEnableStatistics.Text = "Enable Statistics";
            this.checkBoxSenderEnableStatistics.UseVisualStyleBackColor = true;
            this.checkBoxSenderEnableStatistics.CheckedChanged += new System.EventHandler(this.checkBoxSenderEnableStatistics_CheckedChanged);
            // 
            // checkBoxEnableSenderLogging
            // 
            this.checkBoxEnableSenderLogging.AutoSize = true;
            this.checkBoxEnableSenderLogging.Checked = true;
            this.checkBoxEnableSenderLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableSenderLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxEnableSenderLogging.Location = new System.Drawing.Point(176, 140);
            this.checkBoxEnableSenderLogging.Name = "checkBoxEnableSenderLogging";
            this.checkBoxEnableSenderLogging.Size = new System.Drawing.Size(100, 17);
            this.checkBoxEnableSenderLogging.TabIndex = 53;
            this.checkBoxEnableSenderLogging.Text = "Enable Logging";
            this.checkBoxEnableSenderLogging.UseVisualStyleBackColor = true;
            this.checkBoxEnableSenderLogging.CheckedChanged += new System.EventHandler(this.checkBoxEnableSenderLogging_CheckedChanged);
            // 
            // checkBoxAddMessageNumber
            // 
            this.checkBoxAddMessageNumber.AutoSize = true;
            this.checkBoxAddMessageNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxAddMessageNumber.Location = new System.Drawing.Point(584, 172);
            this.checkBoxAddMessageNumber.Name = "checkBoxAddMessageNumber";
            this.checkBoxAddMessageNumber.Size = new System.Drawing.Size(131, 17);
            this.checkBoxAddMessageNumber.TabIndex = 63;
            this.checkBoxAddMessageNumber.Text = "Add Message Number";
            this.checkBoxAddMessageNumber.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenderVerboseLogging
            // 
            this.checkBoxSenderVerboseLogging.AutoSize = true;
            this.checkBoxSenderVerboseLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderVerboseLogging.Location = new System.Drawing.Point(176, 172);
            this.checkBoxSenderVerboseLogging.Name = "checkBoxSenderVerboseLogging";
            this.checkBoxSenderVerboseLogging.Size = new System.Drawing.Size(101, 17);
            this.checkBoxSenderVerboseLogging.TabIndex = 59;
            this.checkBoxSenderVerboseLogging.Text = "Enable Verbose";
            this.checkBoxSenderVerboseLogging.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenderCommitTransaction
            // 
            this.checkBoxSenderCommitTransaction.AutoSize = true;
            this.checkBoxSenderCommitTransaction.Checked = true;
            this.checkBoxSenderCommitTransaction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSenderCommitTransaction.Enabled = false;
            this.checkBoxSenderCommitTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderCommitTransaction.Location = new System.Drawing.Point(16, 172);
            this.checkBoxSenderCommitTransaction.Name = "checkBoxSenderCommitTransaction";
            this.checkBoxSenderCommitTransaction.Size = new System.Drawing.Size(119, 17);
            this.checkBoxSenderCommitTransaction.TabIndex = 56;
            this.checkBoxSenderCommitTransaction.Text = "Commit Transaction";
            this.checkBoxSenderCommitTransaction.UseVisualStyleBackColor = true;
            // 
            // checkBoxSenderUseTransaction
            // 
            this.checkBoxSenderUseTransaction.AutoSize = true;
            this.checkBoxSenderUseTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxSenderUseTransaction.Location = new System.Drawing.Point(16, 140);
            this.checkBoxSenderUseTransaction.Name = "checkBoxSenderUseTransaction";
            this.checkBoxSenderUseTransaction.Size = new System.Drawing.Size(104, 17);
            this.checkBoxSenderUseTransaction.TabIndex = 52;
            this.checkBoxSenderUseTransaction.Text = "Use Transaction";
            this.checkBoxSenderUseTransaction.UseVisualStyleBackColor = true;
            this.checkBoxSenderUseTransaction.CheckedChanged += new System.EventHandler(this.checkBoxSenderUseTransaction_CheckedChanged);
            // 
            // checkBoxOneSessionPerTask
            // 
            this.checkBoxOneSessionPerTask.AutoSize = true;
            this.checkBoxOneSessionPerTask.Checked = true;
            this.checkBoxOneSessionPerTask.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOneSessionPerTask.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxOneSessionPerTask.Location = new System.Drawing.Point(456, 140);
            this.checkBoxOneSessionPerTask.Name = "checkBoxOneSessionPerTask";
            this.checkBoxOneSessionPerTask.Size = new System.Drawing.Size(115, 17);
            this.checkBoxOneSessionPerTask.TabIndex = 55;
            this.checkBoxOneSessionPerTask.Text = "One Session/Task";
            this.checkBoxOneSessionPerTask.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdateMessageId
            // 
            this.checkBoxUpdateMessageId.AutoSize = true;
            this.checkBoxUpdateMessageId.Checked = true;
            this.checkBoxUpdateMessageId.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUpdateMessageId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxUpdateMessageId.Location = new System.Drawing.Point(455, 172);
            this.checkBoxUpdateMessageId.Name = "checkBoxUpdateMessageId";
            this.checkBoxUpdateMessageId.Size = new System.Drawing.Size(116, 17);
            this.checkBoxUpdateMessageId.TabIndex = 62;
            this.checkBoxUpdateMessageId.Text = "Update MessageId";
            this.checkBoxUpdateMessageId.UseVisualStyleBackColor = true;
            // 
            // txtTimeToLive
            // 
            this.txtTimeToLive.Location = new System.Drawing.Point(672, 104);
            this.txtTimeToLive.Name = "txtTimeToLive";
            this.txtTimeToLive.Size = new System.Drawing.Size(56, 20);
            this.txtTimeToLive.TabIndex = 51;
            // 
            // lblTimeToLive
            // 
            this.lblTimeToLive.AutoSize = true;
            this.lblTimeToLive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTimeToLive.Location = new System.Drawing.Point(584, 108);
            this.lblTimeToLive.Name = "lblTimeToLive";
            this.lblTimeToLive.Size = new System.Drawing.Size(80, 13);
            this.lblTimeToLive.TabIndex = 68;
            this.lblTimeToLive.Text = "TimeToLive (s):";
            // 
            // lblReplyToSessionId
            // 
            this.lblReplyToSessionId.AutoSize = true;
            this.lblReplyToSessionId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReplyToSessionId.Location = new System.Drawing.Point(376, 76);
            this.lblReplyToSessionId.Name = "lblReplyToSessionId";
            this.lblReplyToSessionId.Size = new System.Drawing.Size(96, 13);
            this.lblReplyToSessionId.TabIndex = 67;
            this.lblReplyToSessionId.Text = "ReplyToSessionId:";
            // 
            // txtReplyToSessionId
            // 
            this.txtReplyToSessionId.Location = new System.Drawing.Point(472, 72);
            this.txtReplyToSessionId.Name = "txtReplyToSessionId";
            this.txtReplyToSessionId.Size = new System.Drawing.Size(108, 20);
            this.txtReplyToSessionId.TabIndex = 44;
            // 
            // lblReplyTo
            // 
            this.lblReplyTo.AutoSize = true;
            this.lblReplyTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReplyTo.Location = new System.Drawing.Point(192, 76);
            this.lblReplyTo.Name = "lblReplyTo";
            this.lblReplyTo.Size = new System.Drawing.Size(50, 13);
            this.lblReplyTo.TabIndex = 66;
            this.lblReplyTo.Text = "ReplyTo:";
            // 
            // txtReplyTo
            // 
            this.txtReplyTo.Location = new System.Drawing.Point(264, 72);
            this.txtReplyTo.Name = "txtReplyTo";
            this.txtReplyTo.Size = new System.Drawing.Size(108, 20);
            this.txtReplyTo.TabIndex = 43;
            // 
            // txtCorrelationId
            // 
            this.txtCorrelationId.Location = new System.Drawing.Point(472, 40);
            this.txtCorrelationId.Name = "txtCorrelationId";
            this.txtCorrelationId.Size = new System.Drawing.Size(108, 20);
            this.txtCorrelationId.TabIndex = 39;
            // 
            // lblCorrelationId
            // 
            this.lblCorrelationId.AutoSize = true;
            this.lblCorrelationId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCorrelationId.Location = new System.Drawing.Point(376, 44);
            this.lblCorrelationId.Name = "lblCorrelationId";
            this.lblCorrelationId.Size = new System.Drawing.Size(69, 13);
            this.lblCorrelationId.TabIndex = 65;
            this.lblCorrelationId.Text = "CorrelationId:";
            // 
            // lblSession
            // 
            this.lblSession.AutoSize = true;
            this.lblSession.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSession.Location = new System.Drawing.Point(192, 44);
            this.lblSession.Name = "lblSession";
            this.lblSession.Size = new System.Drawing.Size(56, 13);
            this.lblSession.TabIndex = 64;
            this.lblSession.Text = "SessionId:";
            // 
            // txtSessionId
            // 
            this.txtSessionId.Location = new System.Drawing.Point(264, 40);
            this.txtSessionId.Name = "txtSessionId";
            this.txtSessionId.Size = new System.Drawing.Size(108, 20);
            this.txtSessionId.TabIndex = 38;
            // 
            // lblSendTaskCount
            // 
            this.lblSendTaskCount.AutoSize = true;
            this.lblSendTaskCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSendTaskCount.Location = new System.Drawing.Point(584, 76);
            this.lblSendTaskCount.Name = "lblSendTaskCount";
            this.lblSendTaskCount.Size = new System.Drawing.Size(62, 13);
            this.lblSendTaskCount.TabIndex = 60;
            this.lblSendTaskCount.Text = "TaskCount:";
            // 
            // txtSendTaskCount
            // 
            this.txtSendTaskCount.Location = new System.Drawing.Point(672, 72);
            this.txtSendTaskCount.Name = "txtSendTaskCount";
            this.txtSendTaskCount.Size = new System.Drawing.Size(56, 20);
            this.txtSendTaskCount.TabIndex = 46;
            // 
            // lblLabel
            // 
            this.lblLabel.AutoSize = true;
            this.lblLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLabel.Location = new System.Drawing.Point(16, 108);
            this.lblLabel.Name = "lblLabel";
            this.lblLabel.Size = new System.Drawing.Size(36, 13);
            this.lblLabel.TabIndex = 57;
            this.lblLabel.Text = "Label:";
            // 
            // txtLabel
            // 
            this.txtLabel.Location = new System.Drawing.Point(80, 104);
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.Size = new System.Drawing.Size(108, 20);
            this.txtLabel.TabIndex = 47;
            this.txtLabel.TextChanged += new System.EventHandler(this.txtLabel_TextChanged);
            // 
            // txtMessageCount
            // 
            this.txtMessageCount.Location = new System.Drawing.Point(672, 40);
            this.txtMessageCount.Name = "txtMessageCount";
            this.txtMessageCount.Size = new System.Drawing.Size(56, 20);
            this.txtMessageCount.TabIndex = 40;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCount.Location = new System.Drawing.Point(584, 44);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(81, 13);
            this.lblCount.TabIndex = 45;
            this.lblCount.Text = "MessageCount:";
            // 
            // lblMessageId
            // 
            this.lblMessageId.AutoSize = true;
            this.lblMessageId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessageId.Location = new System.Drawing.Point(16, 44);
            this.lblMessageId.Name = "lblMessageId";
            this.lblMessageId.Size = new System.Drawing.Size(62, 13);
            this.lblMessageId.TabIndex = 41;
            this.lblMessageId.Text = "MessageId:";
            // 
            // txtMessageId
            // 
            this.txtMessageId.Location = new System.Drawing.Point(80, 40);
            this.txtMessageId.Name = "txtMessageId";
            this.txtMessageId.Size = new System.Drawing.Size(108, 20);
            this.txtMessageId.TabIndex = 37;
            // 
            // mainTabReceiverPage
            // 
            this.mainTabReceiverPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainTabReceiverPage.Controls.Add(this.receiverEnabledCheckBox);
            this.mainTabReceiverPage.Controls.Add(this.grouperReceiver);
            this.mainTabReceiverPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTabReceiverPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabReceiverPage.Name = "mainTabReceiverPage";
            this.mainTabReceiverPage.Size = new System.Drawing.Size(776, 254);
            this.mainTabReceiverPage.TabIndex = 2;
            this.mainTabReceiverPage.Text = "Receiver";
            // 
            // receiverEnabledCheckBox
            // 
            this.receiverEnabledCheckBox.AutoSize = true;
            this.receiverEnabledCheckBox.Checked = true;
            this.receiverEnabledCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.receiverEnabledCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.receiverEnabledCheckBox.Location = new System.Drawing.Point(696, 12);
            this.receiverEnabledCheckBox.Name = "receiverEnabledCheckBox";
            this.receiverEnabledCheckBox.Size = new System.Drawing.Size(68, 17);
            this.receiverEnabledCheckBox.TabIndex = 14;
            this.receiverEnabledCheckBox.Text = "Enabled:";
            this.receiverEnabledCheckBox.UseVisualStyleBackColor = true;
            this.receiverEnabledCheckBox.CheckedChanged += new System.EventHandler(this.receiverEnabledCheckBox_CheckedChanged);
            // 
            // grouperReceiver
            // 
            this.grouperReceiver.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperReceiver.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperReceiver.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperReceiver.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperReceiver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReceiver.BorderThickness = 1F;
            this.grouperReceiver.Controls.Add(this.cboSubscriptions);
            this.grouperReceiver.Controls.Add(this.lblSubscription);
            this.grouperReceiver.Controls.Add(this.txtPrefetchCount);
            this.grouperReceiver.Controls.Add(this.lblPrefetchCount);
            this.grouperReceiver.Controls.Add(this.txtReceiveTimeout);
            this.grouperReceiver.Controls.Add(this.txtSessionTimeout);
            this.grouperReceiver.Controls.Add(this.lblSessionTimeout);
            this.grouperReceiver.Controls.Add(this.checkBoxDeferMessage);
            this.grouperReceiver.Controls.Add(this.txtFilterExpression);
            this.grouperReceiver.Controls.Add(this.lblFilterExpr);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverEnableGraph);
            this.grouperReceiver.Controls.Add(this.checkBoxCompleteReceive);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverEnableStatistics);
            this.grouperReceiver.Controls.Add(this.cboReceivedMode);
            this.grouperReceiver.Controls.Add(this.label1);
            this.grouperReceiver.Controls.Add(this.checkBoxReadFromDeadLetter);
            this.grouperReceiver.Controls.Add(this.checkBoxMoveToDeadLetter);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverVerboseLogging);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverCommitTransaction);
            this.grouperReceiver.Controls.Add(this.checkBoxReceiverUseTransaction);
            this.grouperReceiver.Controls.Add(this.lblReceiveTaskCount);
            this.grouperReceiver.Controls.Add(this.txtReceiveTaskCount);
            this.grouperReceiver.Controls.Add(this.lblServerWaitTime);
            this.grouperReceiver.Controls.Add(this.checkBoxEnableReceiverLogging);
            this.grouperReceiver.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperReceiver.ForeColor = System.Drawing.Color.White;
            this.grouperReceiver.GroupImage = null;
            this.grouperReceiver.GroupTitle = "Configuration";
            this.grouperReceiver.Location = new System.Drawing.Point(16, 24);
            this.grouperReceiver.Name = "grouperReceiver";
            this.grouperReceiver.Padding = new System.Windows.Forms.Padding(20);
            this.grouperReceiver.PaintGroupBox = true;
            this.grouperReceiver.RoundCorners = 4;
            this.grouperReceiver.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperReceiver.ShadowControl = false;
            this.grouperReceiver.ShadowThickness = 1;
            this.grouperReceiver.Size = new System.Drawing.Size(744, 216);
            this.grouperReceiver.TabIndex = 15;
            // 
            // cboSubscriptions
            // 
            this.cboSubscriptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSubscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSubscriptions.FormattingEnabled = true;
            this.cboSubscriptions.Location = new System.Drawing.Point(80, 104);
            this.cboSubscriptions.Name = "cboSubscriptions";
            this.cboSubscriptions.Size = new System.Drawing.Size(384, 21);
            this.cboSubscriptions.TabIndex = 45;
            // 
            // lblSubscription
            // 
            this.lblSubscription.AutoSize = true;
            this.lblSubscription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubscription.Location = new System.Drawing.Point(16, 108);
            this.lblSubscription.Name = "lblSubscription";
            this.lblSubscription.Size = new System.Drawing.Size(68, 13);
            this.lblSubscription.TabIndex = 44;
            this.lblSubscription.Text = "Subscription:";
            // 
            // txtPrefetchCount
            // 
            this.txtPrefetchCount.Location = new System.Drawing.Point(592, 72);
            this.txtPrefetchCount.Name = "txtPrefetchCount";
            this.txtPrefetchCount.Size = new System.Drawing.Size(136, 20);
            this.txtPrefetchCount.TabIndex = 68;
            this.txtPrefetchCount.Text = "0";
            // 
            // lblPrefetchCount
            // 
            this.lblPrefetchCount.AutoSize = true;
            this.lblPrefetchCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrefetchCount.Location = new System.Drawing.Point(496, 76);
            this.lblPrefetchCount.Name = "lblPrefetchCount";
            this.lblPrefetchCount.Size = new System.Drawing.Size(81, 13);
            this.lblPrefetchCount.TabIndex = 69;
            this.lblPrefetchCount.Text = "Prefetch Count:";
            // 
            // txtReceiveTimeout
            // 
            this.txtReceiveTimeout.Location = new System.Drawing.Point(328, 40);
            this.txtReceiveTimeout.Name = "txtReceiveTimeout";
            this.txtReceiveTimeout.Size = new System.Drawing.Size(136, 20);
            this.txtReceiveTimeout.TabIndex = 49;
            this.txtReceiveTimeout.Text = "1";
            // 
            // txtSessionTimeout
            // 
            this.txtSessionTimeout.Location = new System.Drawing.Point(592, 40);
            this.txtSessionTimeout.Name = "txtSessionTimeout";
            this.txtSessionTimeout.Size = new System.Drawing.Size(136, 20);
            this.txtSessionTimeout.TabIndex = 66;
            this.txtSessionTimeout.Text = "5";
            // 
            // lblSessionTimeout
            // 
            this.lblSessionTimeout.AutoSize = true;
            this.lblSessionTimeout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSessionTimeout.Location = new System.Drawing.Point(488, 44);
            this.lblSessionTimeout.Name = "lblSessionTimeout";
            this.lblSessionTimeout.Size = new System.Drawing.Size(102, 13);
            this.lblSessionTimeout.TabIndex = 67;
            this.lblSessionTimeout.Text = "Session Timeout (s):";
            // 
            // checkBoxDeferMessage
            // 
            this.checkBoxDeferMessage.AutoSize = true;
            this.checkBoxDeferMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxDeferMessage.Location = new System.Drawing.Point(624, 140);
            this.checkBoxDeferMessage.Name = "checkBoxDeferMessage";
            this.checkBoxDeferMessage.Size = new System.Drawing.Size(98, 17);
            this.checkBoxDeferMessage.TabIndex = 62;
            this.checkBoxDeferMessage.Text = "Defer Message";
            this.checkBoxDeferMessage.UseVisualStyleBackColor = true;
            this.checkBoxDeferMessage.CheckedChanged += new System.EventHandler(this.checkBoxDeferMessage_CheckedChanged);
            // 
            // txtFilterExpression
            // 
            this.txtFilterExpression.Location = new System.Drawing.Point(80, 72);
            this.txtFilterExpression.Name = "txtFilterExpression";
            this.txtFilterExpression.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFilterExpression.Size = new System.Drawing.Size(384, 20);
            this.txtFilterExpression.TabIndex = 50;
            this.txtFilterExpression.Text = "1=1";
            // 
            // lblFilterExpr
            // 
            this.lblFilterExpr.AutoSize = true;
            this.lblFilterExpr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFilterExpr.Location = new System.Drawing.Point(16, 76);
            this.lblFilterExpr.Name = "lblFilterExpr";
            this.lblFilterExpr.Size = new System.Drawing.Size(32, 13);
            this.lblFilterExpr.TabIndex = 65;
            this.lblFilterExpr.Text = "Filter:";
            // 
            // checkBoxReceiverEnableGraph
            // 
            this.checkBoxReceiverEnableGraph.AutoSize = true;
            this.checkBoxReceiverEnableGraph.Enabled = false;
            this.checkBoxReceiverEnableGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverEnableGraph.Location = new System.Drawing.Point(320, 172);
            this.checkBoxReceiverEnableGraph.Name = "checkBoxReceiverEnableGraph";
            this.checkBoxReceiverEnableGraph.Size = new System.Drawing.Size(91, 17);
            this.checkBoxReceiverEnableGraph.TabIndex = 58;
            this.checkBoxReceiverEnableGraph.Text = "Enable Graph";
            this.checkBoxReceiverEnableGraph.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompleteReceive
            // 
            this.checkBoxCompleteReceive.AutoSize = true;
            this.checkBoxCompleteReceive.Checked = true;
            this.checkBoxCompleteReceive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCompleteReceive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxCompleteReceive.Location = new System.Drawing.Point(624, 172);
            this.checkBoxCompleteReceive.Name = "checkBoxCompleteReceive";
            this.checkBoxCompleteReceive.Size = new System.Drawing.Size(113, 17);
            this.checkBoxCompleteReceive.TabIndex = 63;
            this.checkBoxCompleteReceive.Text = "Complete Receive";
            this.checkBoxCompleteReceive.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceiverEnableStatistics
            // 
            this.checkBoxReceiverEnableStatistics.AutoSize = true;
            this.checkBoxReceiverEnableStatistics.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverEnableStatistics.Location = new System.Drawing.Point(320, 140);
            this.checkBoxReceiverEnableStatistics.Name = "checkBoxReceiverEnableStatistics";
            this.checkBoxReceiverEnableStatistics.Size = new System.Drawing.Size(104, 17);
            this.checkBoxReceiverEnableStatistics.TabIndex = 57;
            this.checkBoxReceiverEnableStatistics.Text = "Enable Statistics";
            this.checkBoxReceiverEnableStatistics.UseVisualStyleBackColor = true;
            this.checkBoxReceiverEnableStatistics.CheckedChanged += new System.EventHandler(this.checkBoxReceiverEnableStatistics_CheckedChanged);
            // 
            // cboReceivedMode
            // 
            this.cboReceivedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceivedMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboReceivedMode.FormattingEnabled = true;
            this.cboReceivedMode.Items.AddRange(new object[] {
            "PeekLock",
            "ReceiveAndDelete"});
            this.cboReceivedMode.Location = new System.Drawing.Point(592, 104);
            this.cboReceivedMode.Name = "cboReceivedMode";
            this.cboReceivedMode.Size = new System.Drawing.Size(136, 21);
            this.cboReceivedMode.TabIndex = 51;
            this.cboReceivedMode.SelectedIndexChanged += new System.EventHandler(this.cboReceivedMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(512, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 64;
            this.label1.Text = "Receive Mode:";
            // 
            // checkBoxReadFromDeadLetter
            // 
            this.checkBoxReadFromDeadLetter.AutoSize = true;
            this.checkBoxReadFromDeadLetter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReadFromDeadLetter.Location = new System.Drawing.Point(448, 172);
            this.checkBoxReadFromDeadLetter.Name = "checkBoxReadFromDeadLetter";
            this.checkBoxReadFromDeadLetter.Size = new System.Drawing.Size(169, 17);
            this.checkBoxReadFromDeadLetter.TabIndex = 60;
            this.checkBoxReadFromDeadLetter.Text = "Read From DeadLetter Queue";
            this.checkBoxReadFromDeadLetter.UseVisualStyleBackColor = true;
            this.checkBoxReadFromDeadLetter.CheckedChanged += new System.EventHandler(this.checkBoxReadFromDeadLetter_CheckedChanged);
            // 
            // checkBoxMoveToDeadLetter
            // 
            this.checkBoxMoveToDeadLetter.AutoSize = true;
            this.checkBoxMoveToDeadLetter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxMoveToDeadLetter.Location = new System.Drawing.Point(448, 140);
            this.checkBoxMoveToDeadLetter.Name = "checkBoxMoveToDeadLetter";
            this.checkBoxMoveToDeadLetter.Size = new System.Drawing.Size(160, 17);
            this.checkBoxMoveToDeadLetter.TabIndex = 59;
            this.checkBoxMoveToDeadLetter.Text = "Move To DeadLetter Queue";
            this.checkBoxMoveToDeadLetter.UseVisualStyleBackColor = true;
            this.checkBoxMoveToDeadLetter.CheckedChanged += new System.EventHandler(this.checkBoxMoveToDeadLetter_CheckedChanged);
            // 
            // checkBoxReceiverVerboseLogging
            // 
            this.checkBoxReceiverVerboseLogging.AutoSize = true;
            this.checkBoxReceiverVerboseLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverVerboseLogging.Location = new System.Drawing.Point(176, 172);
            this.checkBoxReceiverVerboseLogging.Name = "checkBoxReceiverVerboseLogging";
            this.checkBoxReceiverVerboseLogging.Size = new System.Drawing.Size(101, 17);
            this.checkBoxReceiverVerboseLogging.TabIndex = 56;
            this.checkBoxReceiverVerboseLogging.Text = "Enable Verbose";
            this.checkBoxReceiverVerboseLogging.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceiverCommitTransaction
            // 
            this.checkBoxReceiverCommitTransaction.AutoSize = true;
            this.checkBoxReceiverCommitTransaction.Checked = true;
            this.checkBoxReceiverCommitTransaction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxReceiverCommitTransaction.Enabled = false;
            this.checkBoxReceiverCommitTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverCommitTransaction.Location = new System.Drawing.Point(16, 172);
            this.checkBoxReceiverCommitTransaction.Name = "checkBoxReceiverCommitTransaction";
            this.checkBoxReceiverCommitTransaction.Size = new System.Drawing.Size(119, 17);
            this.checkBoxReceiverCommitTransaction.TabIndex = 53;
            this.checkBoxReceiverCommitTransaction.Text = "Commit Transaction";
            this.checkBoxReceiverCommitTransaction.UseVisualStyleBackColor = true;
            // 
            // checkBoxReceiverUseTransaction
            // 
            this.checkBoxReceiverUseTransaction.AutoSize = true;
            this.checkBoxReceiverUseTransaction.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxReceiverUseTransaction.Location = new System.Drawing.Point(16, 140);
            this.checkBoxReceiverUseTransaction.Name = "checkBoxReceiverUseTransaction";
            this.checkBoxReceiverUseTransaction.Size = new System.Drawing.Size(104, 17);
            this.checkBoxReceiverUseTransaction.TabIndex = 52;
            this.checkBoxReceiverUseTransaction.Text = "Use Transaction";
            this.checkBoxReceiverUseTransaction.UseVisualStyleBackColor = true;
            this.checkBoxReceiverUseTransaction.CheckedChanged += new System.EventHandler(this.checkBoxReceiverUseTransaction_CheckedChanged);
            // 
            // lblReceiveTaskCount
            // 
            this.lblReceiveTaskCount.AutoSize = true;
            this.lblReceiveTaskCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblReceiveTaskCount.Location = new System.Drawing.Point(16, 44);
            this.lblReceiveTaskCount.Name = "lblReceiveTaskCount";
            this.lblReceiveTaskCount.Size = new System.Drawing.Size(62, 13);
            this.lblReceiveTaskCount.TabIndex = 61;
            this.lblReceiveTaskCount.Text = "TaskCount:";
            // 
            // txtReceiveTaskCount
            // 
            this.txtReceiveTaskCount.Location = new System.Drawing.Point(80, 40);
            this.txtReceiveTaskCount.Name = "txtReceiveTaskCount";
            this.txtReceiveTaskCount.Size = new System.Drawing.Size(136, 20);
            this.txtReceiveTaskCount.TabIndex = 48;
            // 
            // lblServerWaitTime
            // 
            this.lblServerWaitTime.AutoSize = true;
            this.lblServerWaitTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblServerWaitTime.Location = new System.Drawing.Point(224, 44);
            this.lblServerWaitTime.Name = "lblServerWaitTime";
            this.lblServerWaitTime.Size = new System.Drawing.Size(105, 13);
            this.lblServerWaitTime.TabIndex = 55;
            this.lblServerWaitTime.Text = "Receive Timeout (s):";
            // 
            // checkBoxEnableReceiverLogging
            // 
            this.checkBoxEnableReceiverLogging.AutoSize = true;
            this.checkBoxEnableReceiverLogging.Checked = true;
            this.checkBoxEnableReceiverLogging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEnableReceiverLogging.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxEnableReceiverLogging.Location = new System.Drawing.Point(176, 140);
            this.checkBoxEnableReceiverLogging.Name = "checkBoxEnableReceiverLogging";
            this.checkBoxEnableReceiverLogging.Size = new System.Drawing.Size(100, 17);
            this.checkBoxEnableReceiverLogging.TabIndex = 54;
            this.checkBoxEnableReceiverLogging.Text = "Enable Logging";
            this.checkBoxEnableReceiverLogging.UseVisualStyleBackColor = true;
            this.checkBoxEnableReceiverLogging.CheckedChanged += new System.EventHandler(this.checkBoxEnableReceiverLogging_CheckedChanged);
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.tabPageGraph.Controls.Add(this.grouperReceiverStatistics);
            this.tabPageGraph.Controls.Add(this.grouperSenderStatistics);
            this.tabPageGraph.Controls.Add(this.chart);
            this.tabPageGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(776, 254);
            this.tabPageGraph.TabIndex = 3;
            this.tabPageGraph.Text = "Graph";
            // 
            // grouperReceiverStatistics
            // 
            this.grouperReceiverStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperReceiverStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperReceiverStatistics.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperReceiverStatistics.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperReceiverStatistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReceiverStatistics.BorderThickness = 1F;
            this.grouperReceiverStatistics.Controls.Add(this.tableLayoutPanel1);
            this.grouperReceiverStatistics.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperReceiverStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperReceiverStatistics.ForeColor = System.Drawing.Color.White;
            this.grouperReceiverStatistics.GroupImage = null;
            this.grouperReceiverStatistics.GroupTitle = "Receiver";
            this.grouperReceiverStatistics.Location = new System.Drawing.Point(632, 8);
            this.grouperReceiverStatistics.Name = "grouperReceiverStatistics";
            this.grouperReceiverStatistics.Padding = new System.Windows.Forms.Padding(20);
            this.grouperReceiverStatistics.PaintGroupBox = true;
            this.grouperReceiverStatistics.RoundCorners = 4;
            this.grouperReceiverStatistics.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperReceiverStatistics.ShadowControl = false;
            this.grouperReceiverStatistics.ShadowThickness = 1;
            this.grouperReceiverStatistics.Size = new System.Drawing.Size(128, 236);
            this.grouperReceiverStatistics.TabIndex = 131;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel17, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel16, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel14, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 5);
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(96, 200);
            this.tableLayoutPanel1.TabIndex = 122;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Controls.Add(this.lblReceiverLastTime, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.lblReceiverLastCaption, 0, 0);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel17.TabIndex = 0;
            // 
            // lblReceiverLastTime
            // 
            this.lblReceiverLastTime.BackColor = System.Drawing.Color.White;
            this.lblReceiverLastTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverLastTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverLastTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverLastTime.Location = new System.Drawing.Point(3, 13);
            this.lblReceiverLastTime.Name = "lblReceiverLastTime";
            this.lblReceiverLastTime.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverLastTime.TabIndex = 113;
            this.lblReceiverLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverLastCaption
            // 
            this.lblReceiverLastCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverLastCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverLastCaption.Location = new System.Drawing.Point(3, 0);
            this.lblReceiverLastCaption.Name = "lblReceiverLastCaption";
            this.lblReceiverLastCaption.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverLastCaption.TabIndex = 112;
            this.lblReceiverLastCaption.Text = "Last Time";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel16.ColumnCount = 1;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Controls.Add(this.lblReceiverAverageTime, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.lblReceiverAverageCaption, 0, 0);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel16.TabIndex = 1;
            // 
            // lblReceiverAverageTime
            // 
            this.lblReceiverAverageTime.BackColor = System.Drawing.Color.White;
            this.lblReceiverAverageTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverAverageTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverAverageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverAverageTime.Location = new System.Drawing.Point(3, 13);
            this.lblReceiverAverageTime.Name = "lblReceiverAverageTime";
            this.lblReceiverAverageTime.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverAverageTime.TabIndex = 116;
            this.lblReceiverAverageTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverAverageCaption
            // 
            this.lblReceiverAverageCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverAverageCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverAverageCaption.Location = new System.Drawing.Point(3, 0);
            this.lblReceiverAverageCaption.Name = "lblReceiverAverageCaption";
            this.lblReceiverAverageCaption.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverAverageCaption.TabIndex = 115;
            this.lblReceiverAverageCaption.Text = "Average Time";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Controls.Add(this.lblReceiverMinimumTime, 0, 1);
            this.tableLayoutPanel15.Controls.Add(this.lblReceiverMinimumCaption, 0, 0);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel15.TabIndex = 2;
            // 
            // lblReceiverMinimumTime
            // 
            this.lblReceiverMinimumTime.BackColor = System.Drawing.Color.White;
            this.lblReceiverMinimumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverMinimumTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverMinimumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMinimumTime.Location = new System.Drawing.Point(3, 13);
            this.lblReceiverMinimumTime.Name = "lblReceiverMinimumTime";
            this.lblReceiverMinimumTime.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverMinimumTime.TabIndex = 118;
            this.lblReceiverMinimumTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverMinimumCaption
            // 
            this.lblReceiverMinimumCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverMinimumCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMinimumCaption.Location = new System.Drawing.Point(3, 0);
            this.lblReceiverMinimumCaption.Name = "lblReceiverMinimumCaption";
            this.lblReceiverMinimumCaption.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverMinimumCaption.TabIndex = 117;
            this.lblReceiverMinimumCaption.Text = "Minimum Time";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Controls.Add(this.lblReceiverMaximumTime, 0, 1);
            this.tableLayoutPanel14.Controls.Add(this.lblReceiverMaximumCaption, 0, 0);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel14.TabIndex = 3;
            // 
            // lblReceiverMaximumTime
            // 
            this.lblReceiverMaximumTime.BackColor = System.Drawing.Color.White;
            this.lblReceiverMaximumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverMaximumTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverMaximumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMaximumTime.Location = new System.Drawing.Point(3, 13);
            this.lblReceiverMaximumTime.Name = "lblReceiverMaximumTime";
            this.lblReceiverMaximumTime.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverMaximumTime.TabIndex = 126;
            this.lblReceiverMaximumTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverMaximumCaption
            // 
            this.lblReceiverMaximumCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverMaximumCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMaximumCaption.Location = new System.Drawing.Point(3, 0);
            this.lblReceiverMaximumCaption.Name = "lblReceiverMaximumCaption";
            this.lblReceiverMaximumCaption.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverMaximumCaption.TabIndex = 125;
            this.lblReceiverMaximumCaption.Text = "Maximum Time";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Controls.Add(this.lblReceiverMessagesPerSecond, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.lblReceiverMessagesPerSecondCaption, 0, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel12.TabIndex = 6;
            // 
            // lblReceiverMessagesPerSecond
            // 
            this.lblReceiverMessagesPerSecond.BackColor = System.Drawing.Color.White;
            this.lblReceiverMessagesPerSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverMessagesPerSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverMessagesPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMessagesPerSecond.Location = new System.Drawing.Point(3, 13);
            this.lblReceiverMessagesPerSecond.Name = "lblReceiverMessagesPerSecond";
            this.lblReceiverMessagesPerSecond.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverMessagesPerSecond.TabIndex = 141;
            this.lblReceiverMessagesPerSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverMessagesPerSecondCaption
            // 
            this.lblReceiverMessagesPerSecondCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverMessagesPerSecondCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMessagesPerSecondCaption.Location = new System.Drawing.Point(3, 0);
            this.lblReceiverMessagesPerSecondCaption.Name = "lblReceiverMessagesPerSecondCaption";
            this.lblReceiverMessagesPerSecondCaption.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverMessagesPerSecondCaption.TabIndex = 140;
            this.lblReceiverMessagesPerSecondCaption.Text = "Messages/Sec";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Controls.Add(this.lblReceiverMessageNumber, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblReceiverCallsSuccessedCaption, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(90, 29);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // lblReceiverMessageNumber
            // 
            this.lblReceiverMessageNumber.BackColor = System.Drawing.Color.White;
            this.lblReceiverMessageNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiverMessageNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReceiverMessageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverMessageNumber.Location = new System.Drawing.Point(3, 14);
            this.lblReceiverMessageNumber.Name = "lblReceiverMessageNumber";
            this.lblReceiverMessageNumber.Size = new System.Drawing.Size(84, 13);
            this.lblReceiverMessageNumber.TabIndex = 125;
            this.lblReceiverMessageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblReceiverCallsSuccessedCaption
            // 
            this.lblReceiverCallsSuccessedCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblReceiverCallsSuccessedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverCallsSuccessedCaption.Location = new System.Drawing.Point(3, 0);
            this.lblReceiverCallsSuccessedCaption.Name = "lblReceiverCallsSuccessedCaption";
            this.lblReceiverCallsSuccessedCaption.Size = new System.Drawing.Size(84, 14);
            this.lblReceiverCallsSuccessedCaption.TabIndex = 124;
            this.lblReceiverCallsSuccessedCaption.Text = "Messages Total";
            // 
            // grouperSenderStatistics
            // 
            this.grouperSenderStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.grouperSenderStatistics.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperSenderStatistics.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperSenderStatistics.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperSenderStatistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperSenderStatistics.BorderThickness = 1F;
            this.grouperSenderStatistics.Controls.Add(this.mainTableLayoutPanel);
            this.grouperSenderStatistics.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperSenderStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperSenderStatistics.ForeColor = System.Drawing.Color.White;
            this.grouperSenderStatistics.GroupImage = null;
            this.grouperSenderStatistics.GroupTitle = "Sender";
            this.grouperSenderStatistics.Location = new System.Drawing.Point(16, 8);
            this.grouperSenderStatistics.Name = "grouperSenderStatistics";
            this.grouperSenderStatistics.Padding = new System.Windows.Forms.Padding(20);
            this.grouperSenderStatistics.PaintGroupBox = true;
            this.grouperSenderStatistics.RoundCorners = 4;
            this.grouperSenderStatistics.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperSenderStatistics.ShadowControl = false;
            this.grouperSenderStatistics.ShadowThickness = 1;
            this.grouperSenderStatistics.Size = new System.Drawing.Size(128, 236);
            this.grouperSenderStatistics.TabIndex = 130;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel8, 0, 4);
            this.mainTableLayoutPanel.Controls.Add(this.tableLayoutPanel10, 0, 5);
            this.mainTableLayoutPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(16, 28);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 6;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(96, 200);
            this.mainTableLayoutPanel.TabIndex = 121;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Controls.Add(this.lblSenderAverageTime, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lblSenderAverageCaption, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // lblSenderAverageTime
            // 
            this.lblSenderAverageTime.BackColor = System.Drawing.Color.White;
            this.lblSenderAverageTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderAverageTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderAverageTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAverageTime.Location = new System.Drawing.Point(3, 13);
            this.lblSenderAverageTime.Name = "lblSenderAverageTime";
            this.lblSenderAverageTime.Size = new System.Drawing.Size(84, 13);
            this.lblSenderAverageTime.TabIndex = 117;
            this.lblSenderAverageTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderAverageCaption
            // 
            this.lblSenderAverageCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderAverageCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderAverageCaption.Location = new System.Drawing.Point(3, 0);
            this.lblSenderAverageCaption.Name = "lblSenderAverageCaption";
            this.lblSenderAverageCaption.Size = new System.Drawing.Size(84, 13);
            this.lblSenderAverageCaption.TabIndex = 116;
            this.lblSenderAverageCaption.Text = "Average Time";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.lblSenderLastTime, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblSenderLastCaption, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lblSenderLastTime
            // 
            this.lblSenderLastTime.BackColor = System.Drawing.Color.White;
            this.lblSenderLastTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderLastTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderLastTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderLastTime.Location = new System.Drawing.Point(3, 13);
            this.lblSenderLastTime.Name = "lblSenderLastTime";
            this.lblSenderLastTime.Size = new System.Drawing.Size(84, 13);
            this.lblSenderLastTime.TabIndex = 113;
            this.lblSenderLastTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderLastCaption
            // 
            this.lblSenderLastCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderLastCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderLastCaption.Location = new System.Drawing.Point(3, 0);
            this.lblSenderLastCaption.Name = "lblSenderLastCaption";
            this.lblSenderLastCaption.Size = new System.Drawing.Size(84, 13);
            this.lblSenderLastCaption.TabIndex = 112;
            this.lblSenderLastCaption.Text = "Last Time";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.lblSenderMinimumTime, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblSenderMinimumCaption, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // lblSenderMinimumTime
            // 
            this.lblSenderMinimumTime.BackColor = System.Drawing.Color.White;
            this.lblSenderMinimumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderMinimumTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderMinimumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMinimumTime.Location = new System.Drawing.Point(3, 13);
            this.lblSenderMinimumTime.Name = "lblSenderMinimumTime";
            this.lblSenderMinimumTime.Size = new System.Drawing.Size(84, 13);
            this.lblSenderMinimumTime.TabIndex = 118;
            this.lblSenderMinimumTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderMinimumCaption
            // 
            this.lblSenderMinimumCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderMinimumCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMinimumCaption.Location = new System.Drawing.Point(3, 0);
            this.lblSenderMinimumCaption.Name = "lblSenderMinimumCaption";
            this.lblSenderMinimumCaption.Size = new System.Drawing.Size(84, 13);
            this.lblSenderMinimumCaption.TabIndex = 117;
            this.lblSenderMinimumCaption.Text = "Minimum Time";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Controls.Add(this.lblSenderMaximumTime, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblSenderMaximumCaption, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 102);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel5.TabIndex = 10;
            // 
            // lblSenderMaximumTime
            // 
            this.lblSenderMaximumTime.BackColor = System.Drawing.Color.White;
            this.lblSenderMaximumTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderMaximumTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderMaximumTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMaximumTime.Location = new System.Drawing.Point(3, 13);
            this.lblSenderMaximumTime.Name = "lblSenderMaximumTime";
            this.lblSenderMaximumTime.Size = new System.Drawing.Size(84, 13);
            this.lblSenderMaximumTime.TabIndex = 126;
            this.lblSenderMaximumTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderMaximumCaption
            // 
            this.lblSenderMaximumCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderMaximumCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMaximumCaption.Location = new System.Drawing.Point(3, 0);
            this.lblSenderMaximumCaption.Name = "lblSenderMaximumCaption";
            this.lblSenderMaximumCaption.Size = new System.Drawing.Size(84, 13);
            this.lblSenderMaximumCaption.TabIndex = 125;
            this.lblSenderMaximumCaption.Text = "Maximum Time";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.lblSenderMessagesPerSecond, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.lblSenderMessagesPerSecondCaption, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(90, 27);
            this.tableLayoutPanel8.TabIndex = 11;
            // 
            // lblSenderMessagesPerSecond
            // 
            this.lblSenderMessagesPerSecond.BackColor = System.Drawing.Color.White;
            this.lblSenderMessagesPerSecond.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderMessagesPerSecond.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderMessagesPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMessagesPerSecond.Location = new System.Drawing.Point(3, 13);
            this.lblSenderMessagesPerSecond.Name = "lblSenderMessagesPerSecond";
            this.lblSenderMessagesPerSecond.Size = new System.Drawing.Size(84, 13);
            this.lblSenderMessagesPerSecond.TabIndex = 141;
            this.lblSenderMessagesPerSecond.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderMessagesPerSecondCaption
            // 
            this.lblSenderMessagesPerSecondCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderMessagesPerSecondCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMessagesPerSecondCaption.Location = new System.Drawing.Point(3, 0);
            this.lblSenderMessagesPerSecondCaption.Name = "lblSenderMessagesPerSecondCaption";
            this.lblSenderMessagesPerSecondCaption.Size = new System.Drawing.Size(84, 13);
            this.lblSenderMessagesPerSecondCaption.TabIndex = 140;
            this.lblSenderMessagesPerSecondCaption.Text = "Messages/Sec";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.lblSenderMessageNumber, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.lblSenderCallsSuccessedCaption, 0, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 168);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(90, 29);
            this.tableLayoutPanel10.TabIndex = 8;
            // 
            // lblSenderMessageNumber
            // 
            this.lblSenderMessageNumber.BackColor = System.Drawing.Color.White;
            this.lblSenderMessageNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSenderMessageNumber.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSenderMessageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderMessageNumber.Location = new System.Drawing.Point(3, 14);
            this.lblSenderMessageNumber.Name = "lblSenderMessageNumber";
            this.lblSenderMessageNumber.Size = new System.Drawing.Size(84, 13);
            this.lblSenderMessageNumber.TabIndex = 125;
            this.lblSenderMessageNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSenderCallsSuccessedCaption
            // 
            this.lblSenderCallsSuccessedCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSenderCallsSuccessedCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenderCallsSuccessedCaption.Location = new System.Drawing.Point(3, 0);
            this.lblSenderCallsSuccessedCaption.Name = "lblSenderCallsSuccessedCaption";
            this.lblSenderCallsSuccessedCaption.Size = new System.Drawing.Size(84, 14);
            this.lblSenderCallsSuccessedCaption.TabIndex = 124;
            this.lblSenderCallsSuccessedCaption.Text = "Messages Total";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.chart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.chart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart.BorderSkin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.chart.BorderSkin.BorderWidth = 0;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.chart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.FrameTitle1;
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.IsRightAngleAxes = false;
            chartArea1.Area3DStyle.Perspective = 10;
            chartArea1.Area3DStyle.Rotation = 10;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)(((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont)
                        | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.ScrollBar.Size = 10D;
            chartArea1.AxisX.Title = "Messages";
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.AxisY.ScrollBar.LineColor = System.Drawing.Color.Black;
            chartArea1.AxisY.ScrollBar.Size = 10D;
            chartArea1.AxisY.Title = "Time - Msg/Sec";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY2.Title = "Messages/Sec";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.Name = "Default";
            chartArea1.ShadowColor = System.Drawing.Color.White;
            this.chart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F);
            legend1.IsTextAutoFit = false;
            legend1.MaximumAutoSize = 40F;
            legend1.Name = "Default";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(152, 15);
            this.chart.Name = "chart";
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Default";
            series1.LegendText = "Sender Latency";
            series1.Name = "SenderLatency";
            series2.BorderColor = System.Drawing.Color.Red;
            series2.BorderWidth = 2;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Default";
            series2.LegendText = "Receiver Latency";
            series2.Name = "ReceiverLatency";
            series3.BorderWidth = 2;
            series3.ChartArea = "Default";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Default";
            series3.LegendText = "Sender Throughput";
            series3.Name = "SenderThroughput";
            series4.BorderWidth = 2;
            series4.ChartArea = "Default";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Default";
            series4.LegendText = "Receiver Throughput";
            series4.Name = "ReceiverThroughput";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(472, 232);
            this.chart.TabIndex = 129;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.ShadowColor = System.Drawing.Color.Transparent;
            title1.ShadowOffset = 1;
            title1.Text = "Sender & Receiver Performance Counters";
            this.chart.Titles.Add(title1);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenFile.Location = new System.Drawing.Point(568, 304);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(72, 24);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            this.btnOpenFile.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.btnOpenFile.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // TestTopicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Name = "TestTopicControl";
            this.Size = new System.Drawing.Size(816, 344);
            this.mainTabControl.ResumeLayout(false);
            this.mainTabMessagePage.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.grouperMessageText.ResumeLayout(false);
            this.grouperMessageText.PerformLayout();
            this.grouperMessageProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesDataGridView)).EndInit();
            this.mainTabSenderPage.ResumeLayout(false);
            this.mainTabSenderPage.PerformLayout();
            this.grouperSender.ResumeLayout(false);
            this.grouperSender.PerformLayout();
            this.mainTabReceiverPage.ResumeLayout(false);
            this.mainTabReceiverPage.PerformLayout();
            this.grouperReceiver.ResumeLayout(false);
            this.grouperReceiver.PerformLayout();
            this.tabPageGraph.ResumeLayout(false);
            this.grouperReceiverStatistics.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.grouperSenderStatistics.ResumeLayout(false);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage mainTabMessagePage;
        private System.Windows.Forms.TabPage mainTabSenderPage;
        private System.Windows.Forms.TabPage mainTabReceiverPage;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TabControl mainTabControl;
        internal System.Windows.Forms.DataVisualization.Charting.Chart chart;
        internal System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Grouper grouperMessageText;
        private System.Windows.Forms.TextBox txtMessageText;
        private Grouper grouperMessageProperties;
        private System.Windows.Forms.DataGridView propertiesDataGridView;
        private System.Windows.Forms.CheckBox senderEnabledCheckBox;
        private Grouper grouperSender;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.ComboBox cboBodyType;
        private System.Windows.Forms.Label lblContentType;
        private System.Windows.Forms.TextBox txtContentType;
        private System.Windows.Forms.TextBox txtScheduledEnqueueTimeUtc;
        private System.Windows.Forms.Label lblScheduledEnqueueTimeUtc;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckBox checkBoxSenderEnableGraph;
        private System.Windows.Forms.CheckBox checkBoxSenderEnableStatistics;
        private System.Windows.Forms.CheckBox checkBoxEnableSenderLogging;
        private System.Windows.Forms.CheckBox checkBoxAddMessageNumber;
        private System.Windows.Forms.CheckBox checkBoxSenderVerboseLogging;
        private System.Windows.Forms.CheckBox checkBoxSenderCommitTransaction;
        private System.Windows.Forms.CheckBox checkBoxSenderUseTransaction;
        private System.Windows.Forms.CheckBox checkBoxOneSessionPerTask;
        private System.Windows.Forms.CheckBox checkBoxUpdateMessageId;
        private System.Windows.Forms.TextBox txtTimeToLive;
        private System.Windows.Forms.Label lblTimeToLive;
        private System.Windows.Forms.Label lblReplyToSessionId;
        private System.Windows.Forms.TextBox txtReplyToSessionId;
        private System.Windows.Forms.Label lblReplyTo;
        private System.Windows.Forms.TextBox txtReplyTo;
        private System.Windows.Forms.TextBox txtCorrelationId;
        private System.Windows.Forms.Label lblCorrelationId;
        private System.Windows.Forms.Label lblSession;
        private System.Windows.Forms.TextBox txtSessionId;
        private System.Windows.Forms.Label lblSendTaskCount;
        private System.Windows.Forms.TextBox txtSendTaskCount;
        private System.Windows.Forms.Label lblLabel;
        private System.Windows.Forms.TextBox txtLabel;
        private System.Windows.Forms.TextBox txtMessageCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblMessageId;
        private System.Windows.Forms.TextBox txtMessageId;
        private System.Windows.Forms.ComboBox cboSubscriptions;
        private System.Windows.Forms.Label lblSubscription;
        internal System.Windows.Forms.CheckBox receiverEnabledCheckBox;
        private Grouper grouperReceiver;
        private System.Windows.Forms.TextBox txtPrefetchCount;
        private System.Windows.Forms.Label lblPrefetchCount;
        private System.Windows.Forms.TextBox txtReceiveTimeout;
        private System.Windows.Forms.TextBox txtSessionTimeout;
        private System.Windows.Forms.Label lblSessionTimeout;
        private System.Windows.Forms.CheckBox checkBoxDeferMessage;
        private System.Windows.Forms.TextBox txtFilterExpression;
        private System.Windows.Forms.Label lblFilterExpr;
        private System.Windows.Forms.CheckBox checkBoxReceiverEnableGraph;
        private System.Windows.Forms.CheckBox checkBoxCompleteReceive;
        private System.Windows.Forms.CheckBox checkBoxReceiverEnableStatistics;
        private System.Windows.Forms.ComboBox cboReceivedMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxReadFromDeadLetter;
        private System.Windows.Forms.CheckBox checkBoxMoveToDeadLetter;
        private System.Windows.Forms.CheckBox checkBoxReceiverVerboseLogging;
        private System.Windows.Forms.CheckBox checkBoxReceiverCommitTransaction;
        private System.Windows.Forms.CheckBox checkBoxReceiverUseTransaction;
        private System.Windows.Forms.Label lblReceiveTaskCount;
        private System.Windows.Forms.TextBox txtReceiveTaskCount;
        private System.Windows.Forms.Label lblServerWaitTime;
        private System.Windows.Forms.CheckBox checkBoxEnableReceiverLogging;
        private Grouper grouperReceiverStatistics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label lblReceiverLastTime;
        private System.Windows.Forms.Label lblReceiverLastCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.Label lblReceiverAverageTime;
        private System.Windows.Forms.Label lblReceiverAverageCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label lblReceiverMinimumTime;
        private System.Windows.Forms.Label lblReceiverMinimumCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label lblReceiverMaximumTime;
        private System.Windows.Forms.Label lblReceiverMaximumCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.Label lblReceiverMessagesPerSecond;
        private System.Windows.Forms.Label lblReceiverMessagesPerSecondCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label lblReceiverMessageNumber;
        private System.Windows.Forms.Label lblReceiverCallsSuccessedCaption;
        private Grouper grouperSenderStatistics;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label lblSenderAverageTime;
        private System.Windows.Forms.Label lblSenderAverageCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblSenderLastTime;
        private System.Windows.Forms.Label lblSenderLastCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblSenderMinimumTime;
        private System.Windows.Forms.Label lblSenderMinimumCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lblSenderMaximumTime;
        private System.Windows.Forms.Label lblSenderMaximumCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Label lblSenderMessagesPerSecond;
        private System.Windows.Forms.Label lblSenderMessagesPerSecondCaption;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label lblSenderMessageNumber;
        private System.Windows.Forms.Label lblSenderCallsSuccessedCaption;
    }
}
