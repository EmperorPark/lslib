namespace ConverterApp
{
    partial class OsirisPane
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
            this.saveStoryBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbNameSearchBox = new System.Windows.Forms.TextBox();
            this.databaseGrid = new System.Windows.Forms.DataGridView();
            this.databaseSelectorCb = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.loadStoryBtn = new System.Windows.Forms.Button();
            this.decompileStoryBtn = new System.Windows.Forms.Button();
            this.storyFilePath = new System.Windows.Forms.TextBox();
            this.goalPathBrowseBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.goalPath = new System.Windows.Forms.TextBox();
            this.storyFileBrowseBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.storyPathDlg = new System.Windows.Forms.OpenFileDialog();
            this.goalPathDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.btnDebugExport = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // saveStoryBtn
            // 
            this.saveStoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveStoryBtn.Location = new System.Drawing.Point(849, 46);
            this.saveStoryBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saveStoryBtn.Name = "saveStoryBtn";
            this.saveStoryBtn.Size = new System.Drawing.Size(141, 21);
            this.saveStoryBtn.TabIndex = 69;
            this.saveStoryBtn.Text = "Save";
            this.saveStoryBtn.UseVisualStyleBackColor = true;
            this.saveStoryBtn.Click += new System.EventHandler(this.saveStoryBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dbNameSearchBox);
            this.groupBox3.Controls.Add(this.databaseGrid);
            this.groupBox3.Controls.Add(this.databaseSelectorCb);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(6, 136);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(990, 397);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Editor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(634, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search:";
            // 
            // dbNameSearchBox
            // 
            this.dbNameSearchBox.Location = new System.Drawing.Point(689, 16);
            this.dbNameSearchBox.Name = "dbNameSearchBox";
            this.dbNameSearchBox.ReadOnly = true;
            this.dbNameSearchBox.Size = new System.Drawing.Size(247, 21);
            this.dbNameSearchBox.TabIndex = 3;
            this.dbNameSearchBox.TextChanged += new System.EventHandler(this.dbNameSearchBox_TextChanged);
            // 
            // databaseGrid
            // 
            this.databaseGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.databaseGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.databaseGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.databaseGrid.Location = new System.Drawing.Point(10, 43);
            this.databaseGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.databaseGrid.Name = "databaseGrid";
            this.databaseGrid.Size = new System.Drawing.Size(967, 341);
            this.databaseGrid.TabIndex = 2;
            // 
            // databaseSelectorCb
            // 
            this.databaseSelectorCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.databaseSelectorCb.FormattingEnabled = true;
            this.databaseSelectorCb.Location = new System.Drawing.Point(78, 17);
            this.databaseSelectorCb.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.databaseSelectorCb.Name = "databaseSelectorCb";
            this.databaseSelectorCb.Size = new System.Drawing.Size(549, 20);
            this.databaseSelectorCb.TabIndex = 1;
            this.databaseSelectorCb.SelectedIndexChanged += new System.EventHandler(this.databaseSelectorCb_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 20);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 12);
            this.label18.TabIndex = 0;
            this.label18.Text = "Database:";
            // 
            // loadStoryBtn
            // 
            this.loadStoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadStoryBtn.Location = new System.Drawing.Point(849, 19);
            this.loadStoryBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.loadStoryBtn.Name = "loadStoryBtn";
            this.loadStoryBtn.Size = new System.Drawing.Size(141, 21);
            this.loadStoryBtn.TabIndex = 67;
            this.loadStoryBtn.Text = "Load";
            this.loadStoryBtn.UseVisualStyleBackColor = true;
            this.loadStoryBtn.Click += new System.EventHandler(this.loadStoryBtn_Click);
            // 
            // decompileStoryBtn
            // 
            this.decompileStoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.decompileStoryBtn.Location = new System.Drawing.Point(849, 85);
            this.decompileStoryBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.decompileStoryBtn.Name = "decompileStoryBtn";
            this.decompileStoryBtn.Size = new System.Drawing.Size(141, 21);
            this.decompileStoryBtn.TabIndex = 66;
            this.decompileStoryBtn.Text = "Extract";
            this.decompileStoryBtn.UseVisualStyleBackColor = true;
            this.decompileStoryBtn.Click += new System.EventHandler(this.decompileStoryBtn_Click);
            // 
            // storyFilePath
            // 
            this.storyFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storyFilePath.Location = new System.Drawing.Point(8, 20);
            this.storyFilePath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.storyFilePath.Name = "storyFilePath";
            this.storyFilePath.Size = new System.Drawing.Size(790, 21);
            this.storyFilePath.TabIndex = 61;
            // 
            // goalPathBrowseBtn
            // 
            this.goalPathBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.goalPathBrowseBtn.Location = new System.Drawing.Point(797, 85);
            this.goalPathBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.goalPathBrowseBtn.Name = "goalPathBrowseBtn";
            this.goalPathBrowseBtn.Size = new System.Drawing.Size(48, 20);
            this.goalPathBrowseBtn.TabIndex = 65;
            this.goalPathBrowseBtn.Text = "...";
            this.goalPathBrowseBtn.UseVisualStyleBackColor = true;
            this.goalPathBrowseBtn.Click += new System.EventHandler(this.goalPathBrowseBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 6);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 12);
            this.label9.TabIndex = 60;
            this.label9.Text = "Story/savegame file path:";
            // 
            // goalPath
            // 
            this.goalPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goalPath.Location = new System.Drawing.Point(8, 86);
            this.goalPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.goalPath.Name = "goalPath";
            this.goalPath.Size = new System.Drawing.Size(790, 21);
            this.goalPath.TabIndex = 64;
            // 
            // storyFileBrowseBtn
            // 
            this.storyFileBrowseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.storyFileBrowseBtn.Location = new System.Drawing.Point(797, 19);
            this.storyFileBrowseBtn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.storyFileBrowseBtn.Name = "storyFileBrowseBtn";
            this.storyFileBrowseBtn.Size = new System.Drawing.Size(48, 20);
            this.storyFileBrowseBtn.TabIndex = 62;
            this.storyFileBrowseBtn.Text = "...";
            this.storyFileBrowseBtn.UseVisualStyleBackColor = true;
            this.storyFileBrowseBtn.Click += new System.EventHandler(this.storyFileBrowseBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 63;
            this.label10.Text = "Goal output path:";
            // 
            // storyPathDlg
            // 
            this.storyPathDlg.CheckFileExists = false;
            this.storyPathDlg.Filter = "LS story/savegame files|*.osi;*.lsv";
            // 
            // btnDebugExport
            // 
            this.btnDebugExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebugExport.Location = new System.Drawing.Point(849, 112);
            this.btnDebugExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDebugExport.Name = "btnDebugExport";
            this.btnDebugExport.Size = new System.Drawing.Size(141, 21);
            this.btnDebugExport.TabIndex = 70;
            this.btnDebugExport.Text = "Debug Export";
            this.btnDebugExport.UseVisualStyleBackColor = true;
            this.btnDebugExport.Click += new System.EventHandler(this.btnDebugExport_Click);
            // 
            // OsirisPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDebugExport);
            this.Controls.Add(this.saveStoryBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.loadStoryBtn);
            this.Controls.Add(this.decompileStoryBtn);
            this.Controls.Add(this.storyFilePath);
            this.Controls.Add(this.goalPathBrowseBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.goalPath);
            this.Controls.Add(this.storyFileBrowseBtn);
            this.Controls.Add(this.label10);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "OsirisPane";
            this.Size = new System.Drawing.Size(1007, 543);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveStoryBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView databaseGrid;
        private System.Windows.Forms.ComboBox databaseSelectorCb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button loadStoryBtn;
        private System.Windows.Forms.Button decompileStoryBtn;
        private System.Windows.Forms.TextBox storyFilePath;
        private System.Windows.Forms.Button goalPathBrowseBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox goalPath;
        private System.Windows.Forms.Button storyFileBrowseBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.OpenFileDialog storyPathDlg;
        private System.Windows.Forms.FolderBrowserDialog goalPathDlg;
        private System.Windows.Forms.Button btnDebugExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dbNameSearchBox;
    }
}
