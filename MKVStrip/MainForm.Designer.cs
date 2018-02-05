namespace MKVStrip
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProcessBtn = new System.Windows.Forms.Button();
            this.SourceDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.LoggingTextBox = new System.Windows.Forms.RichTextBox();
            this.TrackNumbersCheckBox = new System.Windows.Forms.CheckBox();
            this.AudioFilterTextBox = new System.Windows.Forms.TextBox();
            this.SubtitlesFilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InBrowseFolderBtn = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DestinationDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.OutBrowseFolderBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TracksInfoBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProcessBtn
            // 
            this.ProcessBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcessBtn.Location = new System.Drawing.Point(764, 34);
            this.ProcessBtn.Name = "ProcessBtn";
            this.ProcessBtn.Size = new System.Drawing.Size(75, 23);
            this.ProcessBtn.TabIndex = 0;
            this.ProcessBtn.Text = "Process";
            this.ProcessBtn.UseVisualStyleBackColor = true;
            this.ProcessBtn.Click += new System.EventHandler(this.ProcessBtn_Click);
            // 
            // SourceDirectoryTextBox
            // 
            this.SourceDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceDirectoryTextBox.Location = new System.Drawing.Point(86, 36);
            this.SourceDirectoryTextBox.Name = "SourceDirectoryTextBox";
            this.SourceDirectoryTextBox.Size = new System.Drawing.Size(510, 20);
            this.SourceDirectoryTextBox.TabIndex = 1;
            // 
            // LoggingTextBox
            // 
            this.LoggingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoggingTextBox.Location = new System.Drawing.Point(12, 125);
            this.LoggingTextBox.Name = "LoggingTextBox";
            this.LoggingTextBox.Size = new System.Drawing.Size(827, 212);
            this.LoggingTextBox.TabIndex = 3;
            this.LoggingTextBox.Text = "";
            // 
            // TrackNumbersCheckBox
            // 
            this.TrackNumbersCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TrackNumbersCheckBox.AutoSize = true;
            this.TrackNumbersCheckBox.Location = new System.Drawing.Point(687, 96);
            this.TrackNumbersCheckBox.Name = "TrackNumbersCheckBox";
            this.TrackNumbersCheckBox.Size = new System.Drawing.Size(159, 17);
            this.TrackNumbersCheckBox.TabIndex = 4;
            this.TrackNumbersCheckBox.Text = "Use Track Numbers Instead";
            this.TrackNumbersCheckBox.UseVisualStyleBackColor = true;
            this.TrackNumbersCheckBox.CheckedChanged += new System.EventHandler(this.TrackNumbersCheckBox_CheckedChanged);
            // 
            // AudioFilterTextBox
            // 
            this.AudioFilterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AudioFilterTextBox.Location = new System.Drawing.Point(86, 94);
            this.AudioFilterTextBox.Name = "AudioFilterTextBox";
            this.AudioFilterTextBox.Size = new System.Drawing.Size(251, 20);
            this.AudioFilterTextBox.TabIndex = 5;
            this.AudioFilterTextBox.Text = "eng";
            // 
            // SubtitlesFilterTextBox
            // 
            this.SubtitlesFilterTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SubtitlesFilterTextBox.Location = new System.Drawing.Point(421, 94);
            this.SubtitlesFilterTextBox.Name = "SubtitlesFilterTextBox";
            this.SubtitlesFilterTextBox.Size = new System.Drawing.Size(260, 20);
            this.SubtitlesFilterTextBox.TabIndex = 6;
            this.SubtitlesFilterTextBox.Text = "eng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Audio Filter";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Subtitles Filter";
            // 
            // InBrowseFolderBtn
            // 
            this.InBrowseFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InBrowseFolderBtn.Location = new System.Drawing.Point(602, 34);
            this.InBrowseFolderBtn.Name = "InBrowseFolderBtn";
            this.InBrowseFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.InBrowseFolderBtn.TabIndex = 10;
            this.InBrowseFolderBtn.Text = "Browse";
            this.InBrowseFolderBtn.UseVisualStyleBackColor = true;
            this.InBrowseFolderBtn.Click += new System.EventHandler(this.BrowseFolderBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.ExitMenuItem.Text = "Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.AboutMenuItem.Text = "About";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // DestinationDirectoryTextBox
            // 
            this.DestinationDirectoryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationDirectoryTextBox.Location = new System.Drawing.Point(86, 63);
            this.DestinationDirectoryTextBox.Name = "DestinationDirectoryTextBox";
            this.DestinationDirectoryTextBox.Size = new System.Drawing.Size(672, 20);
            this.DestinationDirectoryTextBox.TabIndex = 12;
            // 
            // OutBrowseFolderBtn
            // 
            this.OutBrowseFolderBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OutBrowseFolderBtn.Location = new System.Drawing.Point(764, 61);
            this.OutBrowseFolderBtn.Name = "OutBrowseFolderBtn";
            this.OutBrowseFolderBtn.Size = new System.Drawing.Size(75, 23);
            this.OutBrowseFolderBtn.TabIndex = 13;
            this.OutBrowseFolderBtn.Text = "Browse";
            this.OutBrowseFolderBtn.UseVisualStyleBackColor = true;
            this.OutBrowseFolderBtn.Click += new System.EventHandler(this.OutBrowseFolderBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Input Folder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Output folder";
            // 
            // TracksInfoBtn
            // 
            this.TracksInfoBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TracksInfoBtn.Location = new System.Drawing.Point(683, 34);
            this.TracksInfoBtn.Name = "TracksInfoBtn";
            this.TracksInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.TracksInfoBtn.TabIndex = 16;
            this.TracksInfoBtn.Text = "Tracks Info";
            this.TracksInfoBtn.UseVisualStyleBackColor = true;
            this.TracksInfoBtn.Click += new System.EventHandler(this.TracksInfoBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 352);
            this.Controls.Add(this.TracksInfoBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OutBrowseFolderBtn);
            this.Controls.Add(this.DestinationDirectoryTextBox);
            this.Controls.Add(this.InBrowseFolderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SubtitlesFilterTextBox);
            this.Controls.Add(this.AudioFilterTextBox);
            this.Controls.Add(this.TrackNumbersCheckBox);
            this.Controls.Add(this.LoggingTextBox);
            this.Controls.Add(this.SourceDirectoryTextBox);
            this.Controls.Add(this.ProcessBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MKVStrip";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ProcessBtn;
        private System.Windows.Forms.TextBox SourceDirectoryTextBox;
        private System.Windows.Forms.RichTextBox LoggingTextBox;
        private System.Windows.Forms.CheckBox TrackNumbersCheckBox;
        private System.Windows.Forms.TextBox AudioFilterTextBox;
        private System.Windows.Forms.TextBox SubtitlesFilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InBrowseFolderBtn;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.TextBox DestinationDirectoryTextBox;
        private System.Windows.Forms.Button OutBrowseFolderBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button TracksInfoBtn;
    }
}

