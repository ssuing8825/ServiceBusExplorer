﻿namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    partial class TestSubscriptionControl
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.mainTabReceiverPage = new System.Windows.Forms.TabPage();
            this.grouperReceiver = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
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
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.mainTabControl.SuspendLayout();
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
            this.btnAction.TabIndex = 0;
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
            this.btnCancel.TabIndex = 1;
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
            this.mainTabControl.Controls.Add(this.mainTabReceiverPage);
            this.mainTabControl.Controls.Add(this.tabPageGraph);
            this.mainTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.Location = new System.Drawing.Point(16, 16);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(784, 280);
            this.mainTabControl.TabIndex = 9;
            this.mainTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.mainTabControl_DrawItem);
            // 
            // mainTabReceiverPage
            // 
            this.mainTabReceiverPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.mainTabReceiverPage.Controls.Add(this.grouperReceiver);
            this.mainTabReceiverPage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTabReceiverPage.Location = new System.Drawing.Point(4, 22);
            this.mainTabReceiverPage.Name = "mainTabReceiverPage";
            this.mainTabReceiverPage.Size = new System.Drawing.Size(776, 254);
            this.mainTabReceiverPage.TabIndex = 2;
            this.mainTabReceiverPage.Text = "Receiver";
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
            this.grouperReceiver.TabIndex = 16;
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
            this.tabPageGraph.Controls.Add(this.chart);
            this.tabPageGraph.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(776, 254);
            this.tabPageGraph.TabIndex = 5;
            this.tabPageGraph.Text = "Graph";
            // 
            // grouperReceiverStatistics
            // 
            this.grouperReceiverStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
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
            this.grouperReceiverStatistics.Location = new System.Drawing.Point(16, 8);
            this.grouperReceiverStatistics.Name = "grouperReceiverStatistics";
            this.grouperReceiverStatistics.Padding = new System.Windows.Forms.Padding(20);
            this.grouperReceiverStatistics.PaintGroupBox = true;
            this.grouperReceiverStatistics.RoundCorners = 4;
            this.grouperReceiverStatistics.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperReceiverStatistics.ShadowControl = false;
            this.grouperReceiverStatistics.ShadowThickness = 1;
            this.grouperReceiverStatistics.Size = new System.Drawing.Size(128, 236);
            this.grouperReceiverStatistics.TabIndex = 132;
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
            series1.BorderColor = System.Drawing.Color.Red;
            series1.BorderWidth = 2;
            series1.ChartArea = "Default";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Default";
            series1.LegendText = "Receiver Latency";
            series1.Name = "ReceiverLatency";
            series2.BorderWidth = 2;
            series2.ChartArea = "Default";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Default";
            series2.LegendText = "Receiver Throughput";
            series2.Name = "ReceiverThroughput";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(616, 232);
            this.chart.TabIndex = 129;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.ShadowColor = System.Drawing.Color.Transparent;
            title1.ShadowOffset = 1;
            title1.Text = "Receiver Performance Counters";
            this.chart.Titles.Add(title1);
            // 
            // TestSubscriptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Name = "TestSubscriptionControl";
            this.Size = new System.Drawing.Size(816, 344);
            this.mainTabControl.ResumeLayout(false);
            this.mainTabReceiverPage.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage mainTabReceiverPage;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.TabControl mainTabControl;
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
    }
}
