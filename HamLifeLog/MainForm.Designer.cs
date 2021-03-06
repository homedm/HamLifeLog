﻿namespace HamLifeLog
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.browser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowwToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logTableWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stationDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleBufferTableLayoutPanel1 = new HamLifeLog.DoubleBufferTableLayoutPanel();
            this.MySignalRSTTextBox = new System.Windows.Forms.TextBox();
            this.logDataBindingClassBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.ShowDateLabel = new System.Windows.Forms.Label();
            this.LogSpaceTitleLabel = new System.Windows.Forms.Label();
            this.CallTextBox = new System.Windows.Forms.TextBox();
            this.HisSignalRSTTextBox = new System.Windows.Forms.TextBox();
            this.ShowBandsLabel = new System.Windows.Forms.Label();
            this.ShowModeLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.doubleBufferTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDataBindingClassBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // browser
            // 
            this.browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser.Location = new System.Drawing.Point(0, 33);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1080, 408);
            this.browser.TabIndex = 1;
            this.browser.Url = new System.Uri("https://www.google.co.jp", System.UriKind.Absolute);
            this.browser.WebBrowserShortcutsEnabled = false;
            this.browser.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.WebBrowser_PreviewKeyDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileFToolStripMenuItem,
            this.windowwToolStripMenuItem,
            this.stationSettingToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileFToolStripMenuItem
            // 
            this.fileFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDatabaseToolStripMenuItem,
            this.openDatabaseToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileFToolStripMenuItem.Name = "fileFToolStripMenuItem";
            this.fileFToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.fileFToolStripMenuItem.Text = "File(&F)";
            // 
            // createNewDatabaseToolStripMenuItem
            // 
            this.createNewDatabaseToolStripMenuItem.Name = "createNewDatabaseToolStripMenuItem";
            this.createNewDatabaseToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.createNewDatabaseToolStripMenuItem.Text = "Create New Database";
            this.createNewDatabaseToolStripMenuItem.Click += new System.EventHandler(this.NewCreateDataBaseToolStripMenuItem_Click);
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            this.openDatabaseToolStripMenuItem.Click += new System.EventHandler(this.OpenDatabaseToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(262, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(265, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // windowwToolStripMenuItem
            // 
            this.windowwToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logTableWindowToolStripMenuItem});
            this.windowwToolStripMenuItem.Name = "windowwToolStripMenuItem";
            this.windowwToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.windowwToolStripMenuItem.Text = "Window(&w)";
            // 
            // logTableWindowToolStripMenuItem
            // 
            this.logTableWindowToolStripMenuItem.Name = "logTableWindowToolStripMenuItem";
            this.logTableWindowToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.logTableWindowToolStripMenuItem.Text = "Log Table Window";
            this.logTableWindowToolStripMenuItem.Click += new System.EventHandler(this.LogTableWindowToolStripMenuItem_Click);
            // 
            // stationSettingToolStripMenuItem
            // 
            this.stationSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stationDataToolStripMenuItem,
            this.cWToolStripMenuItem});
            this.stationSettingToolStripMenuItem.Name = "stationSettingToolStripMenuItem";
            this.stationSettingToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.stationSettingToolStripMenuItem.Text = "Setting";
            // 
            // stationDataToolStripMenuItem
            // 
            this.stationDataToolStripMenuItem.Name = "stationDataToolStripMenuItem";
            this.stationDataToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.stationDataToolStripMenuItem.Text = "StationData";
            this.stationDataToolStripMenuItem.Click += new System.EventHandler(this.StationDataToolStripMenuItem_Click);
            // 
            // cWToolStripMenuItem
            // 
            this.cWToolStripMenuItem.Name = "cWToolStripMenuItem";
            this.cWToolStripMenuItem.Size = new System.Drawing.Size(189, 30);
            this.cWToolStripMenuItem.Text = "CW(未実装)";
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            this.helpHToolStripMenuItem.Click += new System.EventHandler(this.HelpHToolStripMenuItem_Click);
            // 
            // doubleBufferTableLayoutPanel1
            // 
            this.doubleBufferTableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.doubleBufferTableLayoutPanel1.ColumnCount = 5;
            this.doubleBufferTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.34229F));
            this.doubleBufferTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.70468F));
            this.doubleBufferTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.63423F));
            this.doubleBufferTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.63423F));
            this.doubleBufferTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.68457F));
            this.doubleBufferTableLayoutPanel1.Controls.Add(this.MySignalRSTTextBox, 3, 1);
            this.doubleBufferTableLayoutPanel1.Controls.Add(this.CommentTextBox, 4, 1);
            this.doubleBufferTableLayoutPanel1.Controls.Add(this.ShowDateLabel, 4, 0);
            this.doubleBufferTableLayoutPanel1.Controls.Add(this.LogSpaceTitleLabel, 0, 0);
            this.doubleBufferTableLayoutPanel1.Controls.Add(this.CallTextBox, 0, 1);
            this.doubleBufferTableLayoutPanel1.Controls.Add(this.HisSignalRSTTextBox, 2, 1);
            this.doubleBufferTableLayoutPanel1.Controls.Add(this.ShowBandsLabel, 1, 0);
            this.doubleBufferTableLayoutPanel1.Controls.Add(this.ShowModeLabel, 1, 1);
            this.doubleBufferTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.doubleBufferTableLayoutPanel1.Location = new System.Drawing.Point(0, 441);
            this.doubleBufferTableLayoutPanel1.Name = "doubleBufferTableLayoutPanel1";
            this.doubleBufferTableLayoutPanel1.RowCount = 2;
            this.doubleBufferTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.doubleBufferTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.doubleBufferTableLayoutPanel1.Size = new System.Drawing.Size(1080, 144);
            this.doubleBufferTableLayoutPanel1.TabIndex = 0;
            // 
            // MySignalRSTTextBox
            // 
            this.MySignalRSTTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MySignalRSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logDataBindingClassBindingSource, "MySignalRST", true));
            this.MySignalRSTTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MySignalRSTTextBox.Location = new System.Drawing.Point(521, 94);
            this.MySignalRSTTextBox.Name = "MySignalRSTTextBox";
            this.MySignalRSTTextBox.Size = new System.Drawing.Size(75, 25);
            this.MySignalRSTTextBox.TabIndex = 5;
            this.MySignalRSTTextBox.Text = "MySignalRST";
            // 
            // logDataBindingClassBindingSource
            // 
            this.logDataBindingClassBindingSource.DataSource = typeof(HamLifeLog.LogDataBindingClass);
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logDataBindingClassBindingSource, "Comment", true));
            this.CommentTextBox.Location = new System.Drawing.Point(605, 94);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(469, 25);
            this.CommentTextBox.TabIndex = 4;
            // 
            // ShowDateLabel
            // 
            this.ShowDateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowDateLabel.AutoSize = true;
            this.ShowDateLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logDataBindingClassBindingSource, "Date", true));
            this.ShowDateLabel.Location = new System.Drawing.Point(605, 27);
            this.ShowDateLabel.Name = "ShowDateLabel";
            this.ShowDateLabel.Size = new System.Drawing.Size(469, 18);
            this.ShowDateLabel.TabIndex = 1;
            this.ShowDateLabel.Text = "yyyy/mm/dd hh:mm:ss";
            // 
            // LogSpaceTitleLabel
            // 
            this.LogSpaceTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LogSpaceTitleLabel.AutoSize = true;
            this.LogSpaceTitleLabel.Location = new System.Drawing.Point(6, 27);
            this.LogSpaceTitleLabel.Name = "LogSpaceTitleLabel";
            this.LogSpaceTitleLabel.Size = new System.Drawing.Size(231, 18);
            this.LogSpaceTitleLabel.TabIndex = 0;
            this.LogSpaceTitleLabel.Text = "LoggingSpace";
            // 
            // CallTextBox
            // 
            this.CallTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CallTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CallTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logDataBindingClassBindingSource, "HisCallSign", true));
            this.CallTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.CallTextBox.Location = new System.Drawing.Point(6, 94);
            this.CallTextBox.Name = "CallTextBox";
            this.CallTextBox.Size = new System.Drawing.Size(231, 25);
            this.CallTextBox.TabIndex = 3;
            this.CallTextBox.Text = "CALL";
            this.CallTextBox.Enter += new System.EventHandler(this.CallTextBox_Enter);
            // 
            // HisSignalRSTTextBox
            // 
            this.HisSignalRSTTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.HisSignalRSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logDataBindingClassBindingSource, "HisSignalRST", true));
            this.HisSignalRSTTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.HisSignalRSTTextBox.Location = new System.Drawing.Point(437, 94);
            this.HisSignalRSTTextBox.Name = "HisSignalRSTTextBox";
            this.HisSignalRSTTextBox.Size = new System.Drawing.Size(75, 25);
            this.HisSignalRSTTextBox.TabIndex = 4;
            this.HisSignalRSTTextBox.Text = "HisSignalRST";
            // 
            // ShowBandsLabel
            // 
            this.ShowBandsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowBandsLabel.AutoSize = true;
            this.ShowBandsLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logDataBindingClassBindingSource, "Band", true));
            this.ShowBandsLabel.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowBandsLabel.Location = new System.Drawing.Point(246, 18);
            this.ShowBandsLabel.Name = "ShowBandsLabel";
            this.ShowBandsLabel.Size = new System.Drawing.Size(182, 36);
            this.ShowBandsLabel.TabIndex = 7;
            this.ShowBandsLabel.Text = "Bands\r\n";
            this.ShowBandsLabel.Click += new System.EventHandler(this.ShowBandsLabel_Click);
            // 
            // ShowModeLabel
            // 
            this.ShowModeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowModeLabel.AutoSize = true;
            this.ShowModeLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.logDataBindingClassBindingSource, "Mode", true));
            this.ShowModeLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowModeLabel.Location = new System.Drawing.Point(246, 95);
            this.ShowModeLabel.Name = "ShowModeLabel";
            this.ShowModeLabel.Size = new System.Drawing.Size(182, 24);
            this.ShowModeLabel.TabIndex = 8;
            this.ShowModeLabel.Text = "Mode";
            this.ShowModeLabel.Click += new System.EventHandler(this.ShowModeLabel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 585);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.doubleBufferTableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "HamLifeLog";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.doubleBufferTableLayoutPanel1.ResumeLayout(false);
            this.doubleBufferTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logDataBindingClassBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DoubleBufferTableLayoutPanel doubleBufferTableLayoutPanel1;
        private System.Windows.Forms.Label LogSpaceTitleLabel;
        private System.Windows.Forms.Label ShowDateLabel;
        private System.Windows.Forms.TextBox CallTextBox;
        private System.Windows.Forms.TextBox MySignalRSTTextBox;
        private System.Windows.Forms.TextBox HisSignalRSTTextBox;
        private System.Windows.Forms.Label ShowBandsLabel;
        private System.Windows.Forms.BindingSource logDataBindingClassBindingSource;
        protected System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stationDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cWToolStripMenuItem;
        private System.Windows.Forms.Label ShowModeLabel;
        private System.Windows.Forms.ToolStripMenuItem windowwToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logTableWindowToolStripMenuItem;
    }
}

