namespace Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer
{
    partial class HandleRuleControl
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
            this.grouperName = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.txtName = new System.Windows.Forms.TextBox();
            this.grouperFilter = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.txtSqlFilterExpression = new System.Windows.Forms.TextBox();
            this.grouperAction = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.txtSqlFilterAction = new System.Windows.Forms.TextBox();
            this.grouper1 = new Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper();
            this.checkBoxDefault = new System.Windows.Forms.CheckBox();
            this.grouperName.SuspendLayout();
            this.grouperFilter.SuspendLayout();
            this.grouperAction.SuspendLayout();
            this.grouper1.SuspendLayout();
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
            // 
            // grouperName
            // 
            this.grouperName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperName.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperName.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperName.BorderThickness = 1F;
            this.grouperName.Controls.Add(this.txtName);
            this.grouperName.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperName.ForeColor = System.Drawing.Color.White;
            this.grouperName.GroupImage = null;
            this.grouperName.GroupTitle = "Name";
            this.grouperName.Location = new System.Drawing.Point(16, 8);
            this.grouperName.Name = "grouperName";
            this.grouperName.Padding = new System.Windows.Forms.Padding(20);
            this.grouperName.PaintGroupBox = true;
            this.grouperName.RoundCorners = 4;
            this.grouperName.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperName.ShadowControl = false;
            this.grouperName.ShadowThickness = 1;
            this.grouperName.Size = new System.Drawing.Size(664, 80);
            this.grouperName.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Location = new System.Drawing.Point(16, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(632, 20);
            this.txtName.TabIndex = 0;
            // 
            // grouperFilter
            // 
            this.grouperFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperFilter.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperFilter.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperFilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperFilter.BorderThickness = 1F;
            this.grouperFilter.Controls.Add(this.txtSqlFilterExpression);
            this.grouperFilter.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperFilter.ForeColor = System.Drawing.Color.White;
            this.grouperFilter.GroupImage = null;
            this.grouperFilter.GroupTitle = "Filter";
            this.grouperFilter.Location = new System.Drawing.Point(16, 96);
            this.grouperFilter.Name = "grouperFilter";
            this.grouperFilter.Padding = new System.Windows.Forms.Padding(20);
            this.grouperFilter.PaintGroupBox = true;
            this.grouperFilter.RoundCorners = 4;
            this.grouperFilter.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperFilter.ShadowControl = false;
            this.grouperFilter.ShadowThickness = 1;
            this.grouperFilter.Size = new System.Drawing.Size(384, 200);
            this.grouperFilter.TabIndex = 21;
            // 
            // txtSqlFilterExpression
            // 
            this.txtSqlFilterExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlFilterExpression.BackColor = System.Drawing.SystemColors.Window;
            this.txtSqlFilterExpression.Location = new System.Drawing.Point(16, 32);
            this.txtSqlFilterExpression.Multiline = true;
            this.txtSqlFilterExpression.Name = "txtSqlFilterExpression";
            this.txtSqlFilterExpression.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSqlFilterExpression.Size = new System.Drawing.Size(352, 152);
            this.txtSqlFilterExpression.TabIndex = 0;
            // 
            // grouperAction
            // 
            this.grouperAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grouperAction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouperAction.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouperAction.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouperAction.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperAction.BorderThickness = 1F;
            this.grouperAction.Controls.Add(this.txtSqlFilterAction);
            this.grouperAction.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouperAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouperAction.ForeColor = System.Drawing.Color.White;
            this.grouperAction.GroupImage = null;
            this.grouperAction.GroupTitle = "Action";
            this.grouperAction.Location = new System.Drawing.Point(416, 96);
            this.grouperAction.Name = "grouperAction";
            this.grouperAction.Padding = new System.Windows.Forms.Padding(20);
            this.grouperAction.PaintGroupBox = true;
            this.grouperAction.RoundCorners = 4;
            this.grouperAction.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouperAction.ShadowControl = false;
            this.grouperAction.ShadowThickness = 1;
            this.grouperAction.Size = new System.Drawing.Size(384, 200);
            this.grouperAction.TabIndex = 22;
            // 
            // txtSqlFilterAction
            // 
            this.txtSqlFilterAction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSqlFilterAction.BackColor = System.Drawing.SystemColors.Window;
            this.txtSqlFilterAction.Location = new System.Drawing.Point(16, 32);
            this.txtSqlFilterAction.Multiline = true;
            this.txtSqlFilterAction.Name = "txtSqlFilterAction";
            this.txtSqlFilterAction.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtSqlFilterAction.Size = new System.Drawing.Size(352, 152);
            this.txtSqlFilterAction.TabIndex = 0;
            // 
            // grouper1
            // 
            this.grouper1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grouper1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.grouper1.BackgroundGradientColor = System.Drawing.Color.White;
            this.grouper1.BackgroundGradientMode = Microsoft.AppFabric.CAT.WindowsAzure.Samples.ServiceBusExplorer.Grouper.GroupBoxGradientMode.None;
            this.grouper1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouper1.BorderThickness = 1F;
            this.grouper1.Controls.Add(this.checkBoxDefault);
            this.grouper1.CustomGroupBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.grouper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.grouper1.ForeColor = System.Drawing.Color.White;
            this.grouper1.GroupImage = null;
            this.grouper1.GroupTitle = "Is Default?";
            this.grouper1.Location = new System.Drawing.Point(696, 8);
            this.grouper1.Name = "grouper1";
            this.grouper1.Padding = new System.Windows.Forms.Padding(20);
            this.grouper1.PaintGroupBox = true;
            this.grouper1.RoundCorners = 4;
            this.grouper1.ShadowColor = System.Drawing.Color.DarkGray;
            this.grouper1.ShadowControl = false;
            this.grouper1.ShadowThickness = 1;
            this.grouper1.Size = new System.Drawing.Size(104, 80);
            this.grouper1.TabIndex = 24;
            // 
            // checkBoxDefault
            // 
            this.checkBoxDefault.AutoSize = true;
            this.checkBoxDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxDefault.Location = new System.Drawing.Point(16, 40);
            this.checkBoxDefault.Name = "checkBoxDefault";
            this.checkBoxDefault.Size = new System.Drawing.Size(60, 17);
            this.checkBoxDefault.TabIndex = 0;
            this.checkBoxDefault.Text = "Default";
            this.checkBoxDefault.UseVisualStyleBackColor = true;
            // 
            // HandleRuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.grouper1);
            this.Controls.Add(this.grouperAction);
            this.Controls.Add(this.grouperFilter);
            this.Controls.Add(this.grouperName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAction);
            this.Name = "HandleRuleControl";
            this.Size = new System.Drawing.Size(816, 344);
            this.Resize += new System.EventHandler(this.HandleRuleControl_Resize);
            this.grouperName.ResumeLayout(false);
            this.grouperName.PerformLayout();
            this.grouperFilter.ResumeLayout(false);
            this.grouperFilter.PerformLayout();
            this.grouperAction.ResumeLayout(false);
            this.grouperAction.PerformLayout();
            this.grouper1.ResumeLayout(false);
            this.grouper1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip toolTip;
        private Grouper grouperName;
        private System.Windows.Forms.TextBox txtName;
        private Grouper grouperFilter;
        private System.Windows.Forms.TextBox txtSqlFilterExpression;
        private Grouper grouperAction;
        private System.Windows.Forms.TextBox txtSqlFilterAction;
        private Grouper grouper1;
        private System.Windows.Forms.CheckBox checkBoxDefault;
    }
}
