namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    partial class HandleQueueControl
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
            this.btnAction = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.grouperQueueSettings = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.grouperQueueProperties = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.lblSizeInBytes = new System.Windows.Forms.Label();
            this.txtSizeInBytes = new System.Windows.Forms.TextBox();
            this.lblMessageCount = new System.Windows.Forms.Label();
            this.lblMaxDeliveryCount = new System.Windows.Forms.Label();
            this.txtMessageCount = new System.Windows.Forms.TextBox();
            this.txtMaxDeliveryCount = new System.Windows.Forms.TextBox();
            this.lblMaxQueueSizeInMegabytes = new System.Windows.Forms.Label();
            this.txtMaxQueueSizeInMegabytes = new System.Windows.Forms.TextBox();
            this.grouperLockDuration = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.lblLockDurationMilliseconds = new System.Windows.Forms.Label();
            this.txtLockDurationMilliseconds = new System.Windows.Forms.TextBox();
            this.lblLockDurationSeconds = new System.Windows.Forms.Label();
            this.txtLockDurationSeconds = new System.Windows.Forms.TextBox();
            this.lblLockDurationMinutes = new System.Windows.Forms.Label();
            this.txtLockDurationMinutes = new System.Windows.Forms.TextBox();
            this.lblLockDurationHours = new System.Windows.Forms.Label();
            this.lblLockDurationDays = new System.Windows.Forms.Label();
            this.txtLockDurationHours = new System.Windows.Forms.TextBox();
            this.txtLockDurationDays = new System.Windows.Forms.TextBox();
            this.groupergrouperDefaultMessageTimeToLive = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.lblDefaultMessageTimeToLiveMilliseconds = new System.Windows.Forms.Label();
            this.txtDefaultMessageTimeToLiveMilliseconds = new System.Windows.Forms.TextBox();
            this.lblDefaultMessageTimeToLiveSeconds = new System.Windows.Forms.Label();
            this.txtDefaultMessageTimeToLiveSeconds = new System.Windows.Forms.TextBox();
            this.lblDefaultMessageTimeToLiveMinutes = new System.Windows.Forms.Label();
            this.txtDefaultMessageTimeToLiveMinutes = new System.Windows.Forms.TextBox();
            this.lbllblDefaultMessageTimeToLiveHours = new System.Windows.Forms.Label();
            this.lblDefaultMessageTimeToLiveDays = new System.Windows.Forms.Label();
            this.txtDefaultMessageTimeToLiveHours = new System.Windows.Forms.TextBox();
            this.txtDefaultMessageTimeToLiveDays = new System.Windows.Forms.TextBox();
            this.grouperDuplicateDetectionHistoryTimeWindow = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.lblDuplicateDetectionHistoryTimeWindowMilliseconds = new System.Windows.Forms.Label();
            this.txtDuplicateDetectionHistoryTimeWindowMilliseconds = new System.Windows.Forms.TextBox();
            this.lblDuplicateDetectionHistoryTimeWindowSeconds = new System.Windows.Forms.Label();
            this.txtDuplicateDetectionHistoryTimeWindowSeconds = new System.Windows.Forms.TextBox();
            this.lblDuplicateDetectionHistoryTimeWindowMinutes = new System.Windows.Forms.Label();
            this.txtDuplicateDetectionHistoryTimeWindowMinutes = new System.Windows.Forms.TextBox();
            this.lblDuplicateDetectionHistoryTimeWindowHours = new System.Windows.Forms.Label();
            this.lblDuplicateDetectionHistoryTimeWindowDays = new System.Windows.Forms.Label();
            this.txtDuplicateDetectionHistoryTimeWindowHours = new System.Windows.Forms.TextBox();
            this.txtDuplicateDetectionHistoryTimeWindowDays = new System.Windows.Forms.TextBox();
            this.grouperPath = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.lblRelativeURI = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grouperQueueSettings.SuspendLayout();
            this.grouperQueueProperties.SuspendLayout();
            this.grouperLockDuration.SuspendLayout();
            this.groupergrouperDefaultMessageTimeToLive.SuspendLayout();
            this.grouperDuplicateDetectionHistoryTimeWindow.SuspendLayout();
            this.grouperPath.SuspendLayout();
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
            this.btnAction.Text = "Action";
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
            // grouperQueueSettings
            // 
            this.grouperQueueSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperQueueSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperQueueSettings.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperQueueSettings.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperQueueSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperQueueSettings.BorderThickness = 1F;
            this.grouperQueueSettings.Controls.Add(this.checkedListBox);
            this.grouperQueueSettings.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperQueueSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperQueueSettings.ForeColor = System.Drawing.Color.White;
            this.grouperQueueSettings.GroupImage = null;
            this.grouperQueueSettings.GroupTitle = "Queue Settings";
            this.grouperQueueSettings.Location = new System.Drawing.Point(416, 184);
            this.grouperQueueSettings.Name = "grouperQueueSettings";
            this.grouperQueueSettings.Padding = new System.Windows.Forms.Padding(20);
            this.grouperQueueSettings.PaintGroupBox = true;
            this.grouperQueueSettings.RoundCorners = 4;
            this.grouperQueueSettings.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperQueueSettings.ShadowControl = false;
            this.grouperQueueSettings.ShadowThickness = 1;
            this.grouperQueueSettings.Size = new System.Drawing.Size(384, 112);
            this.grouperQueueSettings.TabIndex = 16;
            // 
            // checkedListBox
            // 
            this.checkedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox.CheckOnClick = true;
            this.checkedListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Enable Batched Operations",
            "Enable Dead Lettering On Message Expiration",
            "Requires Duplicate Detection",
            "Requires Session"});
            this.checkedListBox.Location = new System.Drawing.Point(16, 32);
            this.checkedListBox.Margin = new System.Windows.Forms.Padding(8);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(352, 64);
            this.checkedListBox.TabIndex = 0;
            this.checkedListBox.ThreeDCheckBoxes = true;
            // 
            // grouperQueueProperties
            // 
            this.grouperQueueProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grouperQueueProperties.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperQueueProperties.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperQueueProperties.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperQueueProperties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperQueueProperties.BorderThickness = 1F;
            this.grouperQueueProperties.Controls.Add(this.lblSizeInBytes);
            this.grouperQueueProperties.Controls.Add(this.txtSizeInBytes);
            this.grouperQueueProperties.Controls.Add(this.lblMessageCount);
            this.grouperQueueProperties.Controls.Add(this.lblMaxDeliveryCount);
            this.grouperQueueProperties.Controls.Add(this.txtMessageCount);
            this.grouperQueueProperties.Controls.Add(this.txtMaxDeliveryCount);
            this.grouperQueueProperties.Controls.Add(this.lblMaxQueueSizeInMegabytes);
            this.grouperQueueProperties.Controls.Add(this.txtMaxQueueSizeInMegabytes);
            this.grouperQueueProperties.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperQueueProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperQueueProperties.ForeColor = System.Drawing.Color.White;
            this.grouperQueueProperties.GroupImage = null;
            this.grouperQueueProperties.GroupTitle = "Queue Properties";
            this.grouperQueueProperties.Location = new System.Drawing.Point(16, 184);
            this.grouperQueueProperties.Name = "grouperQueueProperties";
            this.grouperQueueProperties.Padding = new System.Windows.Forms.Padding(20);
            this.grouperQueueProperties.PaintGroupBox = true;
            this.grouperQueueProperties.RoundCorners = 4;
            this.grouperQueueProperties.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperQueueProperties.ShadowControl = false;
            this.grouperQueueProperties.ShadowThickness = 1;
            this.grouperQueueProperties.Size = new System.Drawing.Size(384, 112);
            this.grouperQueueProperties.TabIndex = 15;
            // 
            // lblSizeInBytes
            // 
            this.lblSizeInBytes.AutoSize = true;
            this.lblSizeInBytes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSizeInBytes.Location = new System.Drawing.Point(208, 76);
            this.lblSizeInBytes.Name = "lblSizeInBytes";
            this.lblSizeInBytes.Size = new System.Drawing.Size(71, 13);
            this.lblSizeInBytes.TabIndex = 30;
            this.lblSizeInBytes.Text = "Size In Bytes:";
            // 
            // txtSizeInBytes
            // 
            this.txtSizeInBytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSizeInBytes.BackColor = System.Drawing.SystemColors.Window;
            this.txtSizeInBytes.Location = new System.Drawing.Point(304, 72);
            this.txtSizeInBytes.Name = "txtSizeInBytes";
            this.txtSizeInBytes.ReadOnly = true;
            this.txtSizeInBytes.Size = new System.Drawing.Size(64, 20);
            this.txtSizeInBytes.TabIndex = 3;
            // 
            // lblMessageCount
            // 
            this.lblMessageCount.AutoSize = true;
            this.lblMessageCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMessageCount.Location = new System.Drawing.Point(16, 76);
            this.lblMessageCount.Name = "lblMessageCount";
            this.lblMessageCount.Size = new System.Drawing.Size(84, 13);
            this.lblMessageCount.TabIndex = 28;
            this.lblMessageCount.Text = "Message Count:";
            // 
            // lblMaxDeliveryCount
            // 
            this.lblMaxDeliveryCount.AutoSize = true;
            this.lblMaxDeliveryCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxDeliveryCount.Location = new System.Drawing.Point(16, 44);
            this.lblMaxDeliveryCount.Name = "lblMaxDeliveryCount";
            this.lblMaxDeliveryCount.Size = new System.Drawing.Size(102, 13);
            this.lblMaxDeliveryCount.TabIndex = 26;
            this.lblMaxDeliveryCount.Text = "Max Delivery Count:";
            // 
            // txtMessageCount
            // 
            this.txtMessageCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessageCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtMessageCount.Location = new System.Drawing.Point(128, 72);
            this.txtMessageCount.Name = "txtMessageCount";
            this.txtMessageCount.ReadOnly = true;
            this.txtMessageCount.Size = new System.Drawing.Size(64, 20);
            this.txtMessageCount.TabIndex = 2;
            // 
            // txtMaxDeliveryCount
            // 
            this.txtMaxDeliveryCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxDeliveryCount.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaxDeliveryCount.Location = new System.Drawing.Point(128, 40);
            this.txtMaxDeliveryCount.Name = "txtMaxDeliveryCount";
            this.txtMaxDeliveryCount.Size = new System.Drawing.Size(64, 20);
            this.txtMaxDeliveryCount.TabIndex = 0;
            // 
            // lblMaxQueueSizeInMegabytes
            // 
            this.lblMaxQueueSizeInMegabytes.AutoSize = true;
            this.lblMaxQueueSizeInMegabytes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMaxQueueSizeInMegabytes.Location = new System.Drawing.Point(208, 44);
            this.lblMaxQueueSizeInMegabytes.Name = "lblMaxQueueSizeInMegabytes";
            this.lblMaxQueueSizeInMegabytes.Size = new System.Drawing.Size(89, 13);
            this.lblMaxQueueSizeInMegabytes.TabIndex = 24;
            this.lblMaxQueueSizeInMegabytes.Text = "Max Size In MBs:";
            // 
            // txtMaxQueueSizeInMegabytes
            // 
            this.txtMaxQueueSizeInMegabytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxQueueSizeInMegabytes.BackColor = System.Drawing.SystemColors.Window;
            this.txtMaxQueueSizeInMegabytes.Location = new System.Drawing.Point(304, 40);
            this.txtMaxQueueSizeInMegabytes.Name = "txtMaxQueueSizeInMegabytes";
            this.txtMaxQueueSizeInMegabytes.Size = new System.Drawing.Size(64, 20);
            this.txtMaxQueueSizeInMegabytes.TabIndex = 1;
            // 
            // grouperLockDuration
            // 
            this.grouperLockDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperLockDuration.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperLockDuration.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperLockDuration.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperLockDuration.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperLockDuration.BorderThickness = 1F;
            this.grouperLockDuration.Controls.Add(this.lblLockDurationMilliseconds);
            this.grouperLockDuration.Controls.Add(this.txtLockDurationMilliseconds);
            this.grouperLockDuration.Controls.Add(this.lblLockDurationSeconds);
            this.grouperLockDuration.Controls.Add(this.txtLockDurationSeconds);
            this.grouperLockDuration.Controls.Add(this.lblLockDurationMinutes);
            this.grouperLockDuration.Controls.Add(this.txtLockDurationMinutes);
            this.grouperLockDuration.Controls.Add(this.lblLockDurationHours);
            this.grouperLockDuration.Controls.Add(this.lblLockDurationDays);
            this.grouperLockDuration.Controls.Add(this.txtLockDurationHours);
            this.grouperLockDuration.Controls.Add(this.txtLockDurationDays);
            this.grouperLockDuration.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperLockDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperLockDuration.ForeColor = System.Drawing.Color.White;
            this.grouperLockDuration.GroupImage = null;
            this.grouperLockDuration.GroupTitle = "Lock Duration";
            this.grouperLockDuration.Location = new System.Drawing.Point(416, 96);
            this.grouperLockDuration.Name = "grouperLockDuration";
            this.grouperLockDuration.Padding = new System.Windows.Forms.Padding(20);
            this.grouperLockDuration.PaintGroupBox = true;
            this.grouperLockDuration.RoundCorners = 4;
            this.grouperLockDuration.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperLockDuration.ShadowControl = false;
            this.grouperLockDuration.ShadowThickness = 1;
            this.grouperLockDuration.Size = new System.Drawing.Size(384, 80);
            this.grouperLockDuration.TabIndex = 14;
            // 
            // lblLockDurationMilliseconds
            // 
            this.lblLockDurationMilliseconds.AutoSize = true;
            this.lblLockDurationMilliseconds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLockDurationMilliseconds.Location = new System.Drawing.Point(304, 28);
            this.lblLockDurationMilliseconds.Name = "lblLockDurationMilliseconds";
            this.lblLockDurationMilliseconds.Size = new System.Drawing.Size(67, 13);
            this.lblLockDurationMilliseconds.TabIndex = 25;
            this.lblLockDurationMilliseconds.Text = "Milliseconds:";
            // 
            // txtLockDurationMilliseconds
            // 
            this.txtLockDurationMilliseconds.BackColor = System.Drawing.SystemColors.Window;
            this.txtLockDurationMilliseconds.Location = new System.Drawing.Point(304, 44);
            this.txtLockDurationMilliseconds.Name = "txtLockDurationMilliseconds";
            this.txtLockDurationMilliseconds.Size = new System.Drawing.Size(64, 20);
            this.txtLockDurationMilliseconds.TabIndex = 4;
            // 
            // lblLockDurationSeconds
            // 
            this.lblLockDurationSeconds.AutoSize = true;
            this.lblLockDurationSeconds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLockDurationSeconds.Location = new System.Drawing.Point(232, 28);
            this.lblLockDurationSeconds.Name = "lblLockDurationSeconds";
            this.lblLockDurationSeconds.Size = new System.Drawing.Size(52, 13);
            this.lblLockDurationSeconds.TabIndex = 24;
            this.lblLockDurationSeconds.Text = "Seconds:";
            // 
            // txtLockDurationSeconds
            // 
            this.txtLockDurationSeconds.BackColor = System.Drawing.SystemColors.Window;
            this.txtLockDurationSeconds.Location = new System.Drawing.Point(232, 44);
            this.txtLockDurationSeconds.Name = "txtLockDurationSeconds";
            this.txtLockDurationSeconds.Size = new System.Drawing.Size(64, 20);
            this.txtLockDurationSeconds.TabIndex = 3;
            // 
            // lblLockDurationMinutes
            // 
            this.lblLockDurationMinutes.AutoSize = true;
            this.lblLockDurationMinutes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLockDurationMinutes.Location = new System.Drawing.Point(160, 28);
            this.lblLockDurationMinutes.Name = "lblLockDurationMinutes";
            this.lblLockDurationMinutes.Size = new System.Drawing.Size(47, 13);
            this.lblLockDurationMinutes.TabIndex = 23;
            this.lblLockDurationMinutes.Text = "Minutes:";
            // 
            // txtLockDurationMinutes
            // 
            this.txtLockDurationMinutes.BackColor = System.Drawing.SystemColors.Window;
            this.txtLockDurationMinutes.Location = new System.Drawing.Point(160, 44);
            this.txtLockDurationMinutes.Name = "txtLockDurationMinutes";
            this.txtLockDurationMinutes.Size = new System.Drawing.Size(64, 20);
            this.txtLockDurationMinutes.TabIndex = 2;
            // 
            // lblLockDurationHours
            // 
            this.lblLockDurationHours.AutoSize = true;
            this.lblLockDurationHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLockDurationHours.Location = new System.Drawing.Point(88, 28);
            this.lblLockDurationHours.Name = "lblLockDurationHours";
            this.lblLockDurationHours.Size = new System.Drawing.Size(38, 13);
            this.lblLockDurationHours.TabIndex = 22;
            this.lblLockDurationHours.Text = "Hours:";
            // 
            // lblLockDurationDays
            // 
            this.lblLockDurationDays.AutoSize = true;
            this.lblLockDurationDays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLockDurationDays.Location = new System.Drawing.Point(16, 28);
            this.lblLockDurationDays.Name = "lblLockDurationDays";
            this.lblLockDurationDays.Size = new System.Drawing.Size(34, 13);
            this.lblLockDurationDays.TabIndex = 21;
            this.lblLockDurationDays.Text = "Days:";
            // 
            // txtLockDurationHours
            // 
            this.txtLockDurationHours.BackColor = System.Drawing.SystemColors.Window;
            this.txtLockDurationHours.Location = new System.Drawing.Point(88, 44);
            this.txtLockDurationHours.Name = "txtLockDurationHours";
            this.txtLockDurationHours.Size = new System.Drawing.Size(64, 20);
            this.txtLockDurationHours.TabIndex = 1;
            // 
            // txtLockDurationDays
            // 
            this.txtLockDurationDays.BackColor = System.Drawing.SystemColors.Window;
            this.txtLockDurationDays.Location = new System.Drawing.Point(16, 44);
            this.txtLockDurationDays.Name = "txtLockDurationDays";
            this.txtLockDurationDays.Size = new System.Drawing.Size(64, 20);
            this.txtLockDurationDays.TabIndex = 0;
            // 
            // groupergrouperDefaultMessageTimeToLive
            // 
            this.groupergrouperDefaultMessageTimeToLive.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.groupergrouperDefaultMessageTimeToLive.BackgroundGradientColor = System.Drawing.Color.White;
            this.groupergrouperDefaultMessageTimeToLive.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.groupergrouperDefaultMessageTimeToLive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.groupergrouperDefaultMessageTimeToLive.BorderThickness = 1F;
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.lblDefaultMessageTimeToLiveMilliseconds);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.txtDefaultMessageTimeToLiveMilliseconds);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.lblDefaultMessageTimeToLiveSeconds);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.txtDefaultMessageTimeToLiveSeconds);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.lblDefaultMessageTimeToLiveMinutes);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.txtDefaultMessageTimeToLiveMinutes);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.lbllblDefaultMessageTimeToLiveHours);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.lblDefaultMessageTimeToLiveDays);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.txtDefaultMessageTimeToLiveHours);
            this.groupergrouperDefaultMessageTimeToLive.Controls.Add(this.txtDefaultMessageTimeToLiveDays);
            this.groupergrouperDefaultMessageTimeToLive.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.groupergrouperDefaultMessageTimeToLive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupergrouperDefaultMessageTimeToLive.ForeColor = System.Drawing.Color.White;
            this.groupergrouperDefaultMessageTimeToLive.GroupImage = null;
            this.groupergrouperDefaultMessageTimeToLive.GroupTitle = "Default Message Time To Live";
            this.groupergrouperDefaultMessageTimeToLive.Location = new System.Drawing.Point(16, 96);
            this.groupergrouperDefaultMessageTimeToLive.Name = "groupergrouperDefaultMessageTimeToLive";
            this.groupergrouperDefaultMessageTimeToLive.Padding = new System.Windows.Forms.Padding(20);
            this.groupergrouperDefaultMessageTimeToLive.PaintGroupBox = true;
            this.groupergrouperDefaultMessageTimeToLive.RoundCorners = 4;
            this.groupergrouperDefaultMessageTimeToLive.ShadowColor = System.Drawing.Color.DarkGray;
            this.groupergrouperDefaultMessageTimeToLive.ShadowControl = false;
            this.groupergrouperDefaultMessageTimeToLive.ShadowThickness = 1;
            this.groupergrouperDefaultMessageTimeToLive.Size = new System.Drawing.Size(384, 80);
            this.groupergrouperDefaultMessageTimeToLive.TabIndex = 13;
            // 
            // lblDefaultMessageTimeToLiveMilliseconds
            // 
            this.lblDefaultMessageTimeToLiveMilliseconds.AutoSize = true;
            this.lblDefaultMessageTimeToLiveMilliseconds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDefaultMessageTimeToLiveMilliseconds.Location = new System.Drawing.Point(304, 28);
            this.lblDefaultMessageTimeToLiveMilliseconds.Name = "lblDefaultMessageTimeToLiveMilliseconds";
            this.lblDefaultMessageTimeToLiveMilliseconds.Size = new System.Drawing.Size(67, 13);
            this.lblDefaultMessageTimeToLiveMilliseconds.TabIndex = 25;
            this.lblDefaultMessageTimeToLiveMilliseconds.Text = "Milliseconds:";
            // 
            // txtDefaultMessageTimeToLiveMilliseconds
            // 
            this.txtDefaultMessageTimeToLiveMilliseconds.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefaultMessageTimeToLiveMilliseconds.Location = new System.Drawing.Point(304, 44);
            this.txtDefaultMessageTimeToLiveMilliseconds.Name = "txtDefaultMessageTimeToLiveMilliseconds";
            this.txtDefaultMessageTimeToLiveMilliseconds.Size = new System.Drawing.Size(64, 20);
            this.txtDefaultMessageTimeToLiveMilliseconds.TabIndex = 4;
            // 
            // lblDefaultMessageTimeToLiveSeconds
            // 
            this.lblDefaultMessageTimeToLiveSeconds.AutoSize = true;
            this.lblDefaultMessageTimeToLiveSeconds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDefaultMessageTimeToLiveSeconds.Location = new System.Drawing.Point(232, 28);
            this.lblDefaultMessageTimeToLiveSeconds.Name = "lblDefaultMessageTimeToLiveSeconds";
            this.lblDefaultMessageTimeToLiveSeconds.Size = new System.Drawing.Size(52, 13);
            this.lblDefaultMessageTimeToLiveSeconds.TabIndex = 24;
            this.lblDefaultMessageTimeToLiveSeconds.Text = "Seconds:";
            // 
            // txtDefaultMessageTimeToLiveSeconds
            // 
            this.txtDefaultMessageTimeToLiveSeconds.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefaultMessageTimeToLiveSeconds.Location = new System.Drawing.Point(232, 44);
            this.txtDefaultMessageTimeToLiveSeconds.Name = "txtDefaultMessageTimeToLiveSeconds";
            this.txtDefaultMessageTimeToLiveSeconds.Size = new System.Drawing.Size(64, 20);
            this.txtDefaultMessageTimeToLiveSeconds.TabIndex = 3;
            // 
            // lblDefaultMessageTimeToLiveMinutes
            // 
            this.lblDefaultMessageTimeToLiveMinutes.AutoSize = true;
            this.lblDefaultMessageTimeToLiveMinutes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDefaultMessageTimeToLiveMinutes.Location = new System.Drawing.Point(160, 28);
            this.lblDefaultMessageTimeToLiveMinutes.Name = "lblDefaultMessageTimeToLiveMinutes";
            this.lblDefaultMessageTimeToLiveMinutes.Size = new System.Drawing.Size(47, 13);
            this.lblDefaultMessageTimeToLiveMinutes.TabIndex = 23;
            this.lblDefaultMessageTimeToLiveMinutes.Text = "Minutes:";
            // 
            // txtDefaultMessageTimeToLiveMinutes
            // 
            this.txtDefaultMessageTimeToLiveMinutes.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefaultMessageTimeToLiveMinutes.Location = new System.Drawing.Point(160, 44);
            this.txtDefaultMessageTimeToLiveMinutes.Name = "txtDefaultMessageTimeToLiveMinutes";
            this.txtDefaultMessageTimeToLiveMinutes.Size = new System.Drawing.Size(64, 20);
            this.txtDefaultMessageTimeToLiveMinutes.TabIndex = 2;
            // 
            // lbllblDefaultMessageTimeToLiveHours
            // 
            this.lbllblDefaultMessageTimeToLiveHours.AutoSize = true;
            this.lbllblDefaultMessageTimeToLiveHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbllblDefaultMessageTimeToLiveHours.Location = new System.Drawing.Point(88, 28);
            this.lbllblDefaultMessageTimeToLiveHours.Name = "lbllblDefaultMessageTimeToLiveHours";
            this.lbllblDefaultMessageTimeToLiveHours.Size = new System.Drawing.Size(38, 13);
            this.lbllblDefaultMessageTimeToLiveHours.TabIndex = 22;
            this.lbllblDefaultMessageTimeToLiveHours.Text = "Hours:";
            // 
            // lblDefaultMessageTimeToLiveDays
            // 
            this.lblDefaultMessageTimeToLiveDays.AutoSize = true;
            this.lblDefaultMessageTimeToLiveDays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDefaultMessageTimeToLiveDays.Location = new System.Drawing.Point(16, 28);
            this.lblDefaultMessageTimeToLiveDays.Name = "lblDefaultMessageTimeToLiveDays";
            this.lblDefaultMessageTimeToLiveDays.Size = new System.Drawing.Size(34, 13);
            this.lblDefaultMessageTimeToLiveDays.TabIndex = 21;
            this.lblDefaultMessageTimeToLiveDays.Text = "Days:";
            // 
            // txtDefaultMessageTimeToLiveHours
            // 
            this.txtDefaultMessageTimeToLiveHours.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefaultMessageTimeToLiveHours.Location = new System.Drawing.Point(88, 44);
            this.txtDefaultMessageTimeToLiveHours.Name = "txtDefaultMessageTimeToLiveHours";
            this.txtDefaultMessageTimeToLiveHours.Size = new System.Drawing.Size(64, 20);
            this.txtDefaultMessageTimeToLiveHours.TabIndex = 1;
            // 
            // txtDefaultMessageTimeToLiveDays
            // 
            this.txtDefaultMessageTimeToLiveDays.BackColor = System.Drawing.SystemColors.Window;
            this.txtDefaultMessageTimeToLiveDays.Location = new System.Drawing.Point(16, 44);
            this.txtDefaultMessageTimeToLiveDays.Name = "txtDefaultMessageTimeToLiveDays";
            this.txtDefaultMessageTimeToLiveDays.Size = new System.Drawing.Size(64, 20);
            this.txtDefaultMessageTimeToLiveDays.TabIndex = 0;
            // 
            // grouperDuplicateDetectionHistoryTimeWindow
            // 
            this.grouperDuplicateDetectionHistoryTimeWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperDuplicateDetectionHistoryTimeWindow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperDuplicateDetectionHistoryTimeWindow.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperDuplicateDetectionHistoryTimeWindow.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperDuplicateDetectionHistoryTimeWindow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperDuplicateDetectionHistoryTimeWindow.BorderThickness = 1F;
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.lblDuplicateDetectionHistoryTimeWindowMilliseconds);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.txtDuplicateDetectionHistoryTimeWindowMilliseconds);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.lblDuplicateDetectionHistoryTimeWindowSeconds);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.txtDuplicateDetectionHistoryTimeWindowSeconds);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.lblDuplicateDetectionHistoryTimeWindowMinutes);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.txtDuplicateDetectionHistoryTimeWindowMinutes);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.lblDuplicateDetectionHistoryTimeWindowHours);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.lblDuplicateDetectionHistoryTimeWindowDays);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.txtDuplicateDetectionHistoryTimeWindowHours);
            this.grouperDuplicateDetectionHistoryTimeWindow.Controls.Add(this.txtDuplicateDetectionHistoryTimeWindowDays);
            this.grouperDuplicateDetectionHistoryTimeWindow.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperDuplicateDetectionHistoryTimeWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperDuplicateDetectionHistoryTimeWindow.ForeColor = System.Drawing.Color.White;
            this.grouperDuplicateDetectionHistoryTimeWindow.GroupImage = null;
            this.grouperDuplicateDetectionHistoryTimeWindow.GroupTitle = "Duplicate Detection History Time Window";
            this.grouperDuplicateDetectionHistoryTimeWindow.Location = new System.Drawing.Point(416, 8);
            this.grouperDuplicateDetectionHistoryTimeWindow.Name = "grouperDuplicateDetectionHistoryTimeWindow";
            this.grouperDuplicateDetectionHistoryTimeWindow.Padding = new System.Windows.Forms.Padding(20);
            this.grouperDuplicateDetectionHistoryTimeWindow.PaintGroupBox = true;
            this.grouperDuplicateDetectionHistoryTimeWindow.RoundCorners = 4;
            this.grouperDuplicateDetectionHistoryTimeWindow.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperDuplicateDetectionHistoryTimeWindow.ShadowControl = false;
            this.grouperDuplicateDetectionHistoryTimeWindow.ShadowThickness = 1;
            this.grouperDuplicateDetectionHistoryTimeWindow.Size = new System.Drawing.Size(384, 80);
            this.grouperDuplicateDetectionHistoryTimeWindow.TabIndex = 12;
            // 
            // lblDuplicateDetectionHistoryTimeWindowMilliseconds
            // 
            this.lblDuplicateDetectionHistoryTimeWindowMilliseconds.AutoSize = true;
            this.lblDuplicateDetectionHistoryTimeWindowMilliseconds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuplicateDetectionHistoryTimeWindowMilliseconds.Location = new System.Drawing.Point(304, 28);
            this.lblDuplicateDetectionHistoryTimeWindowMilliseconds.Name = "lblDuplicateDetectionHistoryTimeWindowMilliseconds";
            this.lblDuplicateDetectionHistoryTimeWindowMilliseconds.Size = new System.Drawing.Size(67, 13);
            this.lblDuplicateDetectionHistoryTimeWindowMilliseconds.TabIndex = 25;
            this.lblDuplicateDetectionHistoryTimeWindowMilliseconds.Text = "Milliseconds:";
            // 
            // txtDuplicateDetectionHistoryTimeWindowMilliseconds
            // 
            this.txtDuplicateDetectionHistoryTimeWindowMilliseconds.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuplicateDetectionHistoryTimeWindowMilliseconds.Location = new System.Drawing.Point(304, 44);
            this.txtDuplicateDetectionHistoryTimeWindowMilliseconds.Name = "txtDuplicateDetectionHistoryTimeWindowMilliseconds";
            this.txtDuplicateDetectionHistoryTimeWindowMilliseconds.Size = new System.Drawing.Size(64, 20);
            this.txtDuplicateDetectionHistoryTimeWindowMilliseconds.TabIndex = 4;
            // 
            // lblDuplicateDetectionHistoryTimeWindowSeconds
            // 
            this.lblDuplicateDetectionHistoryTimeWindowSeconds.AutoSize = true;
            this.lblDuplicateDetectionHistoryTimeWindowSeconds.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuplicateDetectionHistoryTimeWindowSeconds.Location = new System.Drawing.Point(232, 28);
            this.lblDuplicateDetectionHistoryTimeWindowSeconds.Name = "lblDuplicateDetectionHistoryTimeWindowSeconds";
            this.lblDuplicateDetectionHistoryTimeWindowSeconds.Size = new System.Drawing.Size(52, 13);
            this.lblDuplicateDetectionHistoryTimeWindowSeconds.TabIndex = 24;
            this.lblDuplicateDetectionHistoryTimeWindowSeconds.Text = "Seconds:";
            // 
            // txtDuplicateDetectionHistoryTimeWindowSeconds
            // 
            this.txtDuplicateDetectionHistoryTimeWindowSeconds.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuplicateDetectionHistoryTimeWindowSeconds.Location = new System.Drawing.Point(232, 44);
            this.txtDuplicateDetectionHistoryTimeWindowSeconds.Name = "txtDuplicateDetectionHistoryTimeWindowSeconds";
            this.txtDuplicateDetectionHistoryTimeWindowSeconds.Size = new System.Drawing.Size(64, 20);
            this.txtDuplicateDetectionHistoryTimeWindowSeconds.TabIndex = 3;
            // 
            // lblDuplicateDetectionHistoryTimeWindowMinutes
            // 
            this.lblDuplicateDetectionHistoryTimeWindowMinutes.AutoSize = true;
            this.lblDuplicateDetectionHistoryTimeWindowMinutes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuplicateDetectionHistoryTimeWindowMinutes.Location = new System.Drawing.Point(160, 28);
            this.lblDuplicateDetectionHistoryTimeWindowMinutes.Name = "lblDuplicateDetectionHistoryTimeWindowMinutes";
            this.lblDuplicateDetectionHistoryTimeWindowMinutes.Size = new System.Drawing.Size(47, 13);
            this.lblDuplicateDetectionHistoryTimeWindowMinutes.TabIndex = 23;
            this.lblDuplicateDetectionHistoryTimeWindowMinutes.Text = "Minutes:";
            // 
            // txtDuplicateDetectionHistoryTimeWindowMinutes
            // 
            this.txtDuplicateDetectionHistoryTimeWindowMinutes.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuplicateDetectionHistoryTimeWindowMinutes.Location = new System.Drawing.Point(160, 44);
            this.txtDuplicateDetectionHistoryTimeWindowMinutes.Name = "txtDuplicateDetectionHistoryTimeWindowMinutes";
            this.txtDuplicateDetectionHistoryTimeWindowMinutes.Size = new System.Drawing.Size(64, 20);
            this.txtDuplicateDetectionHistoryTimeWindowMinutes.TabIndex = 2;
            // 
            // lblDuplicateDetectionHistoryTimeWindowHours
            // 
            this.lblDuplicateDetectionHistoryTimeWindowHours.AutoSize = true;
            this.lblDuplicateDetectionHistoryTimeWindowHours.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuplicateDetectionHistoryTimeWindowHours.Location = new System.Drawing.Point(88, 28);
            this.lblDuplicateDetectionHistoryTimeWindowHours.Name = "lblDuplicateDetectionHistoryTimeWindowHours";
            this.lblDuplicateDetectionHistoryTimeWindowHours.Size = new System.Drawing.Size(38, 13);
            this.lblDuplicateDetectionHistoryTimeWindowHours.TabIndex = 22;
            this.lblDuplicateDetectionHistoryTimeWindowHours.Text = "Hours:";
            // 
            // lblDuplicateDetectionHistoryTimeWindowDays
            // 
            this.lblDuplicateDetectionHistoryTimeWindowDays.AutoSize = true;
            this.lblDuplicateDetectionHistoryTimeWindowDays.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDuplicateDetectionHistoryTimeWindowDays.Location = new System.Drawing.Point(16, 28);
            this.lblDuplicateDetectionHistoryTimeWindowDays.Name = "lblDuplicateDetectionHistoryTimeWindowDays";
            this.lblDuplicateDetectionHistoryTimeWindowDays.Size = new System.Drawing.Size(34, 13);
            this.lblDuplicateDetectionHistoryTimeWindowDays.TabIndex = 21;
            this.lblDuplicateDetectionHistoryTimeWindowDays.Text = "Days:";
            // 
            // txtDuplicateDetectionHistoryTimeWindowHours
            // 
            this.txtDuplicateDetectionHistoryTimeWindowHours.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuplicateDetectionHistoryTimeWindowHours.Location = new System.Drawing.Point(88, 44);
            this.txtDuplicateDetectionHistoryTimeWindowHours.Name = "txtDuplicateDetectionHistoryTimeWindowHours";
            this.txtDuplicateDetectionHistoryTimeWindowHours.Size = new System.Drawing.Size(64, 20);
            this.txtDuplicateDetectionHistoryTimeWindowHours.TabIndex = 1;
            // 
            // txtDuplicateDetectionHistoryTimeWindowDays
            // 
            this.txtDuplicateDetectionHistoryTimeWindowDays.BackColor = System.Drawing.SystemColors.Window;
            this.txtDuplicateDetectionHistoryTimeWindowDays.Location = new System.Drawing.Point(16, 44);
            this.txtDuplicateDetectionHistoryTimeWindowDays.Name = "txtDuplicateDetectionHistoryTimeWindowDays";
            this.txtDuplicateDetectionHistoryTimeWindowDays.Size = new System.Drawing.Size(64, 20);
            this.txtDuplicateDetectionHistoryTimeWindowDays.TabIndex = 0;
            // 
            // grouperPath
            // 
            this.grouperPath.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperPath.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperPath.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperPath.BorderThickness = 1F;
            this.grouperPath.Controls.Add(this.lblRelativeURI);
            this.grouperPath.Controls.Add(this.txtPath);
            this.grouperPath.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperPath.ForeColor = System.Drawing.Color.White;
            this.grouperPath.GroupImage = null;
            this.grouperPath.GroupTitle = "Path";
            this.grouperPath.Location = new System.Drawing.Point(16, 8);
            this.grouperPath.Name = "grouperPath";
            this.grouperPath.Padding = new System.Windows.Forms.Padding(20);
            this.grouperPath.PaintGroupBox = true;
            this.grouperPath.RoundCorners = 4;
            this.grouperPath.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperPath.ShadowControl = false;
            this.grouperPath.ShadowThickness = 1;
            this.grouperPath.Size = new System.Drawing.Size(384, 80);
            this.grouperPath.TabIndex = 11;
            // 
            // lblRelativeURI
            // 
            this.lblRelativeURI.AutoSize = true;
            this.lblRelativeURI.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRelativeURI.Location = new System.Drawing.Point(16, 28);
            this.lblRelativeURI.Name = "lblRelativeURI";
            this.lblRelativeURI.Size = new System.Drawing.Size(71, 13);
            this.lblRelativeURI.TabIndex = 22;
            this.lblRelativeURI.Text = "Relative URI:";
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPath.BackColor = System.Drawing.SystemColors.Window;
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtPath.Location = new System.Drawing.Point(16, 44);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(352, 20);
            this.txtPath.TabIndex = 0;
            // 
            // HandleQueueControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.grouperQueueSettings);
            this.Controls.Add(this.grouperQueueProperties);
            this.Controls.Add(this.grouperLockDuration);
            this.Controls.Add(this.groupergrouperDefaultMessageTimeToLive);
            this.Controls.Add(this.grouperDuplicateDetectionHistoryTimeWindow);
            this.Controls.Add(this.grouperPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Name = "HandleQueueControl";
            this.Size = new System.Drawing.Size(816, 344);
            this.grouperQueueSettings.ResumeLayout(false);
            this.grouperQueueProperties.ResumeLayout(false);
            this.grouperQueueProperties.PerformLayout();
            this.grouperLockDuration.ResumeLayout(false);
            this.grouperLockDuration.PerformLayout();
            this.groupergrouperDefaultMessageTimeToLive.ResumeLayout(false);
            this.groupergrouperDefaultMessageTimeToLive.PerformLayout();
            this.grouperDuplicateDetectionHistoryTimeWindow.ResumeLayout(false);
            this.grouperDuplicateDetectionHistoryTimeWindow.PerformLayout();
            this.grouperPath.ResumeLayout(false);
            this.grouperPath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip;
        private Grouper grouperPath;
        private System.Windows.Forms.TextBox txtPath;
        private Grouper grouperDuplicateDetectionHistoryTimeWindow;
        private System.Windows.Forms.Label lblDuplicateDetectionHistoryTimeWindowMilliseconds;
        private System.Windows.Forms.TextBox txtDuplicateDetectionHistoryTimeWindowMilliseconds;
        private System.Windows.Forms.Label lblDuplicateDetectionHistoryTimeWindowSeconds;
        private System.Windows.Forms.TextBox txtDuplicateDetectionHistoryTimeWindowSeconds;
        private System.Windows.Forms.Label lblDuplicateDetectionHistoryTimeWindowMinutes;
        private System.Windows.Forms.TextBox txtDuplicateDetectionHistoryTimeWindowMinutes;
        private System.Windows.Forms.Label lblDuplicateDetectionHistoryTimeWindowHours;
        private System.Windows.Forms.Label lblDuplicateDetectionHistoryTimeWindowDays;
        private System.Windows.Forms.TextBox txtDuplicateDetectionHistoryTimeWindowHours;
        private System.Windows.Forms.TextBox txtDuplicateDetectionHistoryTimeWindowDays;
        private Grouper groupergrouperDefaultMessageTimeToLive;
        private System.Windows.Forms.Label lblDefaultMessageTimeToLiveMilliseconds;
        private System.Windows.Forms.TextBox txtDefaultMessageTimeToLiveMilliseconds;
        private System.Windows.Forms.Label lblDefaultMessageTimeToLiveSeconds;
        private System.Windows.Forms.TextBox txtDefaultMessageTimeToLiveSeconds;
        private System.Windows.Forms.Label lblDefaultMessageTimeToLiveMinutes;
        private System.Windows.Forms.TextBox txtDefaultMessageTimeToLiveMinutes;
        private System.Windows.Forms.Label lbllblDefaultMessageTimeToLiveHours;
        private System.Windows.Forms.Label lblDefaultMessageTimeToLiveDays;
        private System.Windows.Forms.TextBox txtDefaultMessageTimeToLiveHours;
        private System.Windows.Forms.TextBox txtDefaultMessageTimeToLiveDays;
        private Grouper grouperLockDuration;
        private System.Windows.Forms.Label lblLockDurationMilliseconds;
        private System.Windows.Forms.TextBox txtLockDurationMilliseconds;
        private System.Windows.Forms.Label lblLockDurationSeconds;
        private System.Windows.Forms.TextBox txtLockDurationSeconds;
        private System.Windows.Forms.Label lblLockDurationMinutes;
        private System.Windows.Forms.TextBox txtLockDurationMinutes;
        private System.Windows.Forms.Label lblLockDurationHours;
        private System.Windows.Forms.Label lblLockDurationDays;
        private System.Windows.Forms.TextBox txtLockDurationHours;
        private System.Windows.Forms.TextBox txtLockDurationDays;
        private Grouper grouperQueueProperties;
        private System.Windows.Forms.Label lblSizeInBytes;
        private System.Windows.Forms.TextBox txtSizeInBytes;
        private System.Windows.Forms.Label lblMessageCount;
        private System.Windows.Forms.Label lblMaxDeliveryCount;
        private System.Windows.Forms.TextBox txtMessageCount;
        private System.Windows.Forms.TextBox txtMaxDeliveryCount;
        private System.Windows.Forms.Label lblMaxQueueSizeInMegabytes;
        private System.Windows.Forms.TextBox txtMaxQueueSizeInMegabytes;
        private Grouper grouperQueueSettings;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label lblRelativeURI;
    }
}
