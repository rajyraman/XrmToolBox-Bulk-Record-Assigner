namespace ACL.XrmToolBox.BulkRecordAssigner
{
    partial class BulkRecordAssigner
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BulkRecordAssigner));
            this.entityComboBox = new System.Windows.Forms.ComboBox();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.closeTabButton = new System.Windows.Forms.ToolStripButton();
            this.loadCrmDataButton = new System.Windows.Forms.ToolStripButton();
            this.entityGroupBox = new System.Windows.Forms.GroupBox();
            this.assignFromGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.teamsGroupBox = new System.Windows.Forms.GroupBox();
            this.teamsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.usersGroupBox = new System.Windows.Forms.GroupBox();
            this.usersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.batchSizeNumbericUpDown = new System.Windows.Forms.NumericUpDown();
            this.batchSizeLabel = new System.Windows.Forms.Label();
            this.logFileLabel = new System.Windows.Forms.Label();
            this.logLocationTextBox = new System.Windows.Forms.TextBox();
            this.browseLogLocationButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.userSelectAllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.userClearSelectionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.teamSelectAllLinkLabel = new System.Windows.Forms.LinkLabel();
            this.teamClearSelectionLinkLabel = new System.Windows.Forms.LinkLabel();
            this.assigneeTeamComboBox = new System.Windows.Forms.ComboBox();
            this.assigneeUserComboBox = new System.Windows.Forms.ComboBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.assigneeTypeUserRadioButton = new System.Windows.Forms.RadioButton();
            this.assigneeTypeTeamRadioButton = new System.Windows.Forms.RadioButton();
            this.assignToGroupBox = new System.Windows.Forms.GroupBox();
            this.assignButton = new System.Windows.Forms.Button();
            this.mainToolStrip.SuspendLayout();
            this.entityGroupBox.SuspendLayout();
            this.assignFromGroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.teamsGroupBox.SuspendLayout();
            this.usersGroupBox.SuspendLayout();
            this.optionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchSizeNumbericUpDown)).BeginInit();
            this.assignToGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // entityComboBox
            // 
            this.entityComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.entityComboBox.FormattingEnabled = true;
            this.entityComboBox.Location = new System.Drawing.Point(6, 19);
            this.entityComboBox.Name = "entityComboBox";
            this.entityComboBox.Size = new System.Drawing.Size(474, 21);
            this.entityComboBox.Sorted = true;
            this.entityComboBox.TabIndex = 0;
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeTabButton,
            this.loadCrmDataButton});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(849, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // closeTabButton
            // 
            this.closeTabButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeTabButton.Image = ((System.Drawing.Image)(resources.GetObject("closeTabButton.Image")));
            this.closeTabButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeTabButton.Name = "closeTabButton";
            this.closeTabButton.Size = new System.Drawing.Size(23, 22);
            this.closeTabButton.Text = "Close this tab";
            this.closeTabButton.Click += new System.EventHandler(this.closeTabButton_Click);
            // 
            // loadCrmDataButton
            // 
            this.loadCrmDataButton.Image = ((System.Drawing.Image)(resources.GetObject("loadCrmDataButton.Image")));
            this.loadCrmDataButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadCrmDataButton.Name = "loadCrmDataButton";
            this.loadCrmDataButton.Size = new System.Drawing.Size(109, 22);
            this.loadCrmDataButton.Text = "Load CRM Data";
            this.loadCrmDataButton.Click += new System.EventHandler(this.loadCrmDataButton_Click);
            // 
            // entityGroupBox
            // 
            this.entityGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.entityGroupBox.Controls.Add(this.entityComboBox);
            this.entityGroupBox.Location = new System.Drawing.Point(3, 28);
            this.entityGroupBox.Name = "entityGroupBox";
            this.entityGroupBox.Size = new System.Drawing.Size(486, 53);
            this.entityGroupBox.TabIndex = 3;
            this.entityGroupBox.TabStop = false;
            this.entityGroupBox.Text = "Entity";
            // 
            // assignFromGroupBox
            // 
            this.assignFromGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignFromGroupBox.Controls.Add(this.tableLayoutPanel2);
            this.assignFromGroupBox.Location = new System.Drawing.Point(3, 81);
            this.assignFromGroupBox.Name = "assignFromGroupBox";
            this.assignFromGroupBox.Size = new System.Drawing.Size(486, 197);
            this.assignFromGroupBox.TabIndex = 5;
            this.assignFromGroupBox.TabStop = false;
            this.assignFromGroupBox.Text = "Assign From";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.teamsGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.usersGroupBox, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 172);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // teamsGroupBox
            // 
            this.teamsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamsGroupBox.Controls.Add(this.teamClearSelectionLinkLabel);
            this.teamsGroupBox.Controls.Add(this.teamSelectAllLinkLabel);
            this.teamsGroupBox.Controls.Add(this.teamsCheckedListBox);
            this.teamsGroupBox.Location = new System.Drawing.Point(240, 3);
            this.teamsGroupBox.Name = "teamsGroupBox";
            this.teamsGroupBox.Size = new System.Drawing.Size(231, 166);
            this.teamsGroupBox.TabIndex = 11;
            this.teamsGroupBox.TabStop = false;
            this.teamsGroupBox.Text = "Teams";
            // 
            // teamsCheckedListBox
            // 
            this.teamsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamsCheckedListBox.CheckOnClick = true;
            this.teamsCheckedListBox.FormattingEnabled = true;
            this.teamsCheckedListBox.Location = new System.Drawing.Point(6, 36);
            this.teamsCheckedListBox.Name = "teamsCheckedListBox";
            this.teamsCheckedListBox.ScrollAlwaysVisible = true;
            this.teamsCheckedListBox.Size = new System.Drawing.Size(219, 124);
            this.teamsCheckedListBox.TabIndex = 8;
            // 
            // usersGroupBox
            // 
            this.usersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersGroupBox.Controls.Add(this.userClearSelectionLinkLabel);
            this.usersGroupBox.Controls.Add(this.userSelectAllLinkLabel);
            this.usersGroupBox.Controls.Add(this.usersCheckedListBox);
            this.usersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.usersGroupBox.Name = "usersGroupBox";
            this.usersGroupBox.Size = new System.Drawing.Size(231, 166);
            this.usersGroupBox.TabIndex = 10;
            this.usersGroupBox.TabStop = false;
            this.usersGroupBox.Text = "Users";
            // 
            // usersCheckedListBox
            // 
            this.usersCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usersCheckedListBox.CheckOnClick = true;
            this.usersCheckedListBox.FormattingEnabled = true;
            this.usersCheckedListBox.Location = new System.Drawing.Point(6, 36);
            this.usersCheckedListBox.Name = "usersCheckedListBox";
            this.usersCheckedListBox.ScrollAlwaysVisible = true;
            this.usersCheckedListBox.Size = new System.Drawing.Size(219, 124);
            this.usersCheckedListBox.TabIndex = 6;
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.optionsGroupBox.Controls.Add(this.batchSizeNumbericUpDown);
            this.optionsGroupBox.Controls.Add(this.batchSizeLabel);
            this.optionsGroupBox.Controls.Add(this.logFileLabel);
            this.optionsGroupBox.Controls.Add(this.logLocationTextBox);
            this.optionsGroupBox.Controls.Add(this.browseLogLocationButton);
            this.optionsGroupBox.Location = new System.Drawing.Point(495, 28);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(350, 103);
            this.optionsGroupBox.TabIndex = 7;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // batchSizeNumbericUpDown
            // 
            this.batchSizeNumbericUpDown.Location = new System.Drawing.Point(70, 20);
            this.batchSizeNumbericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.batchSizeNumbericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.batchSizeNumbericUpDown.Name = "batchSizeNumbericUpDown";
            this.batchSizeNumbericUpDown.Size = new System.Drawing.Size(58, 20);
            this.batchSizeNumbericUpDown.TabIndex = 5;
            this.batchSizeNumbericUpDown.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // batchSizeLabel
            // 
            this.batchSizeLabel.AutoSize = true;
            this.batchSizeLabel.Location = new System.Drawing.Point(6, 22);
            this.batchSizeLabel.Name = "batchSizeLabel";
            this.batchSizeLabel.Size = new System.Drawing.Size(58, 13);
            this.batchSizeLabel.TabIndex = 4;
            this.batchSizeLabel.Text = "Batch Size";
            // 
            // logFileLabel
            // 
            this.logFileLabel.AutoSize = true;
            this.logFileLabel.Location = new System.Drawing.Point(6, 59);
            this.logFileLabel.Name = "logFileLabel";
            this.logFileLabel.Size = new System.Drawing.Size(89, 13);
            this.logFileLabel.TabIndex = 2;
            this.logFileLabel.Text = "Log File Directory";
            // 
            // logLocationTextBox
            // 
            this.logLocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logLocationTextBox.Location = new System.Drawing.Point(9, 75);
            this.logLocationTextBox.Name = "logLocationTextBox";
            this.logLocationTextBox.Size = new System.Drawing.Size(304, 20);
            this.logLocationTextBox.TabIndex = 1;
            // 
            // browseLogLocationButton
            // 
            this.browseLogLocationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseLogLocationButton.Location = new System.Drawing.Point(319, 75);
            this.browseLogLocationButton.Name = "browseLogLocationButton";
            this.browseLogLocationButton.Size = new System.Drawing.Size(25, 20);
            this.browseLogLocationButton.TabIndex = 0;
            this.browseLogLocationButton.Text = "...";
            this.browseLogLocationButton.UseVisualStyleBackColor = true;
            this.browseLogLocationButton.Click += new System.EventHandler(this.btnBrowseLogLocation_Click);
            // 
            // userSelectAllLinkLabel
            // 
            this.userSelectAllLinkLabel.AutoSize = true;
            this.userSelectAllLinkLabel.Location = new System.Drawing.Point(6, 20);
            this.userSelectAllLinkLabel.Name = "userSelectAllLinkLabel";
            this.userSelectAllLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.userSelectAllLinkLabel.TabIndex = 7;
            this.userSelectAllLinkLabel.TabStop = true;
            this.userSelectAllLinkLabel.Text = "Select All";
            this.userSelectAllLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userSelectAllLinkLabel_LinkClicked);
            // 
            // userClearSelectionLinkLabel
            // 
            this.userClearSelectionLinkLabel.AutoSize = true;
            this.userClearSelectionLinkLabel.Location = new System.Drawing.Point(63, 20);
            this.userClearSelectionLinkLabel.Name = "userClearSelectionLinkLabel";
            this.userClearSelectionLinkLabel.Size = new System.Drawing.Size(78, 13);
            this.userClearSelectionLinkLabel.TabIndex = 8;
            this.userClearSelectionLinkLabel.TabStop = true;
            this.userClearSelectionLinkLabel.Text = "Clear Selection";
            this.userClearSelectionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userClearSelectionLinkLabel_LinkClicked);
            // 
            // teamSelectAllLinkLabel
            // 
            this.teamSelectAllLinkLabel.AutoSize = true;
            this.teamSelectAllLinkLabel.Location = new System.Drawing.Point(7, 20);
            this.teamSelectAllLinkLabel.Name = "teamSelectAllLinkLabel";
            this.teamSelectAllLinkLabel.Size = new System.Drawing.Size(51, 13);
            this.teamSelectAllLinkLabel.TabIndex = 9;
            this.teamSelectAllLinkLabel.TabStop = true;
            this.teamSelectAllLinkLabel.Text = "Select All";
            this.teamSelectAllLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teamSelectAllLinkLabel_LinkClicked);
            // 
            // teamClearSelectionLinkLabel
            // 
            this.teamClearSelectionLinkLabel.AutoSize = true;
            this.teamClearSelectionLinkLabel.Location = new System.Drawing.Point(64, 20);
            this.teamClearSelectionLinkLabel.Name = "teamClearSelectionLinkLabel";
            this.teamClearSelectionLinkLabel.Size = new System.Drawing.Size(78, 13);
            this.teamClearSelectionLinkLabel.TabIndex = 10;
            this.teamClearSelectionLinkLabel.TabStop = true;
            this.teamClearSelectionLinkLabel.Text = "Clear Selection";
            this.teamClearSelectionLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.teamClearSelectionLinkLabel_LinkClicked);
            // 
            // assigneeTeamComboBox
            // 
            this.assigneeTeamComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assigneeTeamComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assigneeTeamComboBox.FormattingEnabled = true;
            this.assigneeTeamComboBox.Location = new System.Drawing.Point(6, 42);
            this.assigneeTeamComboBox.Name = "assigneeTeamComboBox";
            this.assigneeTeamComboBox.Size = new System.Drawing.Size(474, 21);
            this.assigneeTeamComboBox.TabIndex = 5;
            this.assigneeTeamComboBox.Visible = false;
            // 
            // assigneeUserComboBox
            // 
            this.assigneeUserComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assigneeUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.assigneeUserComboBox.FormattingEnabled = true;
            this.assigneeUserComboBox.Location = new System.Drawing.Point(6, 42);
            this.assigneeUserComboBox.Name = "assigneeUserComboBox";
            this.assigneeUserComboBox.Size = new System.Drawing.Size(474, 21);
            this.assigneeUserComboBox.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(55, 114);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 13);
            this.lblUser.TabIndex = 3;
            // 
            // assigneeTypeUserRadioButton
            // 
            this.assigneeTypeUserRadioButton.AutoSize = true;
            this.assigneeTypeUserRadioButton.Checked = true;
            this.assigneeTypeUserRadioButton.Location = new System.Drawing.Point(6, 19);
            this.assigneeTypeUserRadioButton.Name = "assigneeTypeUserRadioButton";
            this.assigneeTypeUserRadioButton.Size = new System.Drawing.Size(47, 17);
            this.assigneeTypeUserRadioButton.TabIndex = 7;
            this.assigneeTypeUserRadioButton.TabStop = true;
            this.assigneeTypeUserRadioButton.Text = "User";
            this.assigneeTypeUserRadioButton.UseVisualStyleBackColor = true;
            this.assigneeTypeUserRadioButton.CheckedChanged += new System.EventHandler(this.rdoAssigneeTypeUser_CheckedChanged);
            // 
            // assigneeTypeTeamRadioButton
            // 
            this.assigneeTypeTeamRadioButton.AutoSize = true;
            this.assigneeTypeTeamRadioButton.Location = new System.Drawing.Point(58, 19);
            this.assigneeTypeTeamRadioButton.Name = "assigneeTypeTeamRadioButton";
            this.assigneeTypeTeamRadioButton.Size = new System.Drawing.Size(52, 17);
            this.assigneeTypeTeamRadioButton.TabIndex = 8;
            this.assigneeTypeTeamRadioButton.Text = "Team";
            this.assigneeTypeTeamRadioButton.UseVisualStyleBackColor = true;
            this.assigneeTypeTeamRadioButton.CheckedChanged += new System.EventHandler(this.rdoAssigneeTypeTeam_CheckedChanged);
            // 
            // assignToGroupBox
            // 
            this.assignToGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assignToGroupBox.Controls.Add(this.assigneeTypeTeamRadioButton);
            this.assignToGroupBox.Controls.Add(this.assigneeTypeUserRadioButton);
            this.assignToGroupBox.Controls.Add(this.lblUser);
            this.assignToGroupBox.Controls.Add(this.assigneeUserComboBox);
            this.assignToGroupBox.Controls.Add(this.assigneeTeamComboBox);
            this.assignToGroupBox.Location = new System.Drawing.Point(3, 278);
            this.assignToGroupBox.Name = "assignToGroupBox";
            this.assignToGroupBox.Size = new System.Drawing.Size(486, 71);
            this.assignToGroupBox.TabIndex = 0;
            this.assignToGroupBox.TabStop = false;
            this.assignToGroupBox.Text = "Assign To";
            // 
            // assignButton
            // 
            this.assignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assignButton.Location = new System.Drawing.Point(495, 303);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(350, 46);
            this.assignButton.TabIndex = 4;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // BulkRecordAssigner
            // 
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.assignFromGroupBox);
            this.Controls.Add(this.entityGroupBox);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.mainToolStrip);
            this.Controls.Add(this.assignToGroupBox);
            this.Name = "BulkRecordAssigner";
            this.Size = new System.Drawing.Size(849, 352);
            this.Load += new System.EventHandler(this.BulkRecordAssigner_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.entityGroupBox.ResumeLayout(false);
            this.assignFromGroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.teamsGroupBox.ResumeLayout(false);
            this.teamsGroupBox.PerformLayout();
            this.usersGroupBox.ResumeLayout(false);
            this.usersGroupBox.PerformLayout();
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.batchSizeNumbericUpDown)).EndInit();
            this.assignToGroupBox.ResumeLayout(false);
            this.assignToGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton closeTabButton;
        private System.Windows.Forms.ToolStripButton loadCrmDataButton;
        private System.Windows.Forms.ComboBox entityComboBox;
        private System.Windows.Forms.GroupBox entityGroupBox;
        private System.Windows.Forms.GroupBox assignFromGroupBox;
        private System.Windows.Forms.CheckedListBox usersCheckedListBox;
        private System.Windows.Forms.GroupBox teamsGroupBox;
        private System.Windows.Forms.CheckedListBox teamsCheckedListBox;
        private System.Windows.Forms.GroupBox usersGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown batchSizeNumbericUpDown;
        private System.Windows.Forms.Label batchSizeLabel;
        private System.Windows.Forms.Label logFileLabel;
        private System.Windows.Forms.TextBox logLocationTextBox;
        private System.Windows.Forms.Button browseLogLocationButton;
        private System.Windows.Forms.LinkLabel teamClearSelectionLinkLabel;
        private System.Windows.Forms.LinkLabel teamSelectAllLinkLabel;
        private System.Windows.Forms.LinkLabel userClearSelectionLinkLabel;
        private System.Windows.Forms.LinkLabel userSelectAllLinkLabel;
        private System.Windows.Forms.ComboBox assigneeTeamComboBox;
        private System.Windows.Forms.ComboBox assigneeUserComboBox;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.RadioButton assigneeTypeUserRadioButton;
        private System.Windows.Forms.RadioButton assigneeTypeTeamRadioButton;
        private System.Windows.Forms.GroupBox assignToGroupBox;
        private System.Windows.Forms.Button assignButton;
    }
}