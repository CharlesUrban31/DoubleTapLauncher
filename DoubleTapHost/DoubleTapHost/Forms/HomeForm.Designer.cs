namespace DoubleTapHost
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.libraryLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHostDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gettingStartedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consoleLogBox = new System.Windows.Forms.RichTextBox();
            this.serverLaunchBtn = new System.Windows.Forms.Button();
            this.serverCloseBtn = new System.Windows.Forms.Button();
            this.viewConnBtn = new System.Windows.Forms.Button();
            this.listGamesBtn = new System.Windows.Forms.Button();
            this.menuFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.libraryLocationToolStripMenuItem,
            this.viewHostDetailsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // libraryLocationToolStripMenuItem
            // 
            this.libraryLocationToolStripMenuItem.Name = "libraryLocationToolStripMenuItem";
            this.libraryLocationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.libraryLocationToolStripMenuItem.Text = "Library Location";
            this.libraryLocationToolStripMenuItem.Click += new System.EventHandler(this.libraryLocationToolStripMenuItem_Click);
            // 
            // viewHostDetailsToolStripMenuItem
            // 
            this.viewHostDetailsToolStripMenuItem.Name = "viewHostDetailsToolStripMenuItem";
            this.viewHostDetailsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewHostDetailsToolStripMenuItem.Text = "View Host Details";
            this.viewHostDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewHostDetailsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gettingStartedToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gettingStartedToolStripMenuItem
            // 
            this.gettingStartedToolStripMenuItem.Name = "gettingStartedToolStripMenuItem";
            this.gettingStartedToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.gettingStartedToolStripMenuItem.Text = "Getting Started";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // consoleLogBox
            // 
            this.consoleLogBox.BackColor = System.Drawing.Color.Black;
            this.consoleLogBox.ForeColor = System.Drawing.Color.Lime;
            this.consoleLogBox.Location = new System.Drawing.Point(12, 74);
            this.consoleLogBox.Name = "consoleLogBox";
            this.consoleLogBox.Size = new System.Drawing.Size(776, 364);
            this.consoleLogBox.TabIndex = 1;
            this.consoleLogBox.Text = "";
            // 
            // serverLaunchBtn
            // 
            this.serverLaunchBtn.Location = new System.Drawing.Point(12, 27);
            this.serverLaunchBtn.Name = "serverLaunchBtn";
            this.serverLaunchBtn.Size = new System.Drawing.Size(99, 41);
            this.serverLaunchBtn.TabIndex = 2;
            this.serverLaunchBtn.Text = "Launch Server";
            this.serverLaunchBtn.UseVisualStyleBackColor = true;
            this.serverLaunchBtn.Click += new System.EventHandler(this.serverLaunchBtn_Click);
            // 
            // serverCloseBtn
            // 
            this.serverCloseBtn.Location = new System.Drawing.Point(117, 27);
            this.serverCloseBtn.Name = "serverCloseBtn";
            this.serverCloseBtn.Size = new System.Drawing.Size(100, 41);
            this.serverCloseBtn.TabIndex = 3;
            this.serverCloseBtn.Text = "Close Server";
            this.serverCloseBtn.UseVisualStyleBackColor = true;
            this.serverCloseBtn.Click += new System.EventHandler(this.serverCloseBtn_Click);
            // 
            // viewConnBtn
            // 
            this.viewConnBtn.Location = new System.Drawing.Point(223, 27);
            this.viewConnBtn.Name = "viewConnBtn";
            this.viewConnBtn.Size = new System.Drawing.Size(94, 41);
            this.viewConnBtn.TabIndex = 4;
            this.viewConnBtn.Text = "View Current Connections";
            this.viewConnBtn.UseVisualStyleBackColor = true;
            this.viewConnBtn.Click += new System.EventHandler(this.viewConnBtn_Click);
            // 
            // listGamesBtn
            // 
            this.listGamesBtn.Location = new System.Drawing.Point(323, 27);
            this.listGamesBtn.Name = "listGamesBtn";
            this.listGamesBtn.Size = new System.Drawing.Size(99, 41);
            this.listGamesBtn.TabIndex = 5;
            this.listGamesBtn.Text = "List Games In Library";
            this.listGamesBtn.UseVisualStyleBackColor = true;
            this.listGamesBtn.Click += new System.EventHandler(this.listGamesBtn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listGamesBtn);
            this.Controls.Add(this.viewConnBtn);
            this.Controls.Add(this.serverCloseBtn);
            this.Controls.Add(this.serverLaunchBtn);
            this.Controls.Add(this.consoleLogBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "DoubleTap Host";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem libraryLocationToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem gettingStartedToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem viewHostDetailsToolStripMenuItem;
        private RichTextBox consoleLogBox;
        private Button serverLaunchBtn;
        private Button serverCloseBtn;
        private Button viewConnBtn;
        private Button listGamesBtn;
        private FolderBrowserDialog menuFolderBrowser;
    }
}