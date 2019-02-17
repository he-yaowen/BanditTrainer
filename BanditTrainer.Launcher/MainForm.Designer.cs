namespace BanditTrainer.Launcher
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
            if (disposing && (components != null)) {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGameOpenProcess = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiGameExit = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.勢力FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.英雄HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.州府PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.幫助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關於AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslProcessId = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslProcessName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvwItemList = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.ssStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.選項OToolStripMenuItem,
            this.幫助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1060, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiGameOpenProcess,
            this.toolStripMenuItem1,
            this.tsmiGameExit});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "游戏(&G)";
            // 
            // tsmiGameOpenProcess
            // 
            this.tsmiGameOpenProcess.Name = "tsmiGameOpenProcess";
            this.tsmiGameOpenProcess.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsmiGameOpenProcess.Size = new System.Drawing.Size(174, 22);
            this.tsmiGameOpenProcess.Text = "打开进程...";
            this.tsmiGameOpenProcess.Click += new System.EventHandler(this.action_OpenProcess);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 6);
            // 
            // tsmiGameExit
            // 
            this.tsmiGameExit.Name = "tsmiGameExit";
            this.tsmiGameExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmiGameExit.Size = new System.Drawing.Size(174, 22);
            this.tsmiGameExit.Text = "退出";
            this.tsmiGameExit.Click += new System.EventHandler(this.action_Exit);
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.勢力FToolStripMenuItem,
            this.英雄HToolStripMenuItem,
            this.州府PToolStripMenuItem});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.編輯EToolStripMenuItem.Text = "编辑(&E)";
            // 
            // 勢力FToolStripMenuItem
            // 
            this.勢力FToolStripMenuItem.Name = "勢力FToolStripMenuItem";
            this.勢力FToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.勢力FToolStripMenuItem.Text = "势力(&F)";
            this.勢力FToolStripMenuItem.Click += new System.EventHandler(this.action_ListForces);
            // 
            // 英雄HToolStripMenuItem
            // 
            this.英雄HToolStripMenuItem.Name = "英雄HToolStripMenuItem";
            this.英雄HToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.英雄HToolStripMenuItem.Text = "英雄(&H)";
            this.英雄HToolStripMenuItem.Click += new System.EventHandler(this.action_ListHeroes);
            // 
            // 州府PToolStripMenuItem
            // 
            this.州府PToolStripMenuItem.Name = "州府PToolStripMenuItem";
            this.州府PToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.州府PToolStripMenuItem.Text = "州府(&P)";
            this.州府PToolStripMenuItem.Click += new System.EventHandler(this.action_ListPrefectures);
            // 
            // 選項OToolStripMenuItem
            // 
            this.選項OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.設置SToolStripMenuItem});
            this.選項OToolStripMenuItem.Name = "選項OToolStripMenuItem";
            this.選項OToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.選項OToolStripMenuItem.Text = "工具(&T)";
            // 
            // 設置SToolStripMenuItem
            // 
            this.設置SToolStripMenuItem.Name = "設置SToolStripMenuItem";
            this.設置SToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.設置SToolStripMenuItem.Text = "设置(&S)";
            // 
            // 幫助HToolStripMenuItem
            // 
            this.幫助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.關於AToolStripMenuItem});
            this.幫助HToolStripMenuItem.Name = "幫助HToolStripMenuItem";
            this.幫助HToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.幫助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 關於AToolStripMenuItem
            // 
            this.關於AToolStripMenuItem.Name = "關於AToolStripMenuItem";
            this.關於AToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.關於AToolStripMenuItem.Text = "关于(&A)...";
            // 
            // ssStatusStrip
            // 
            this.ssStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslProcessId,
            this.tsslProcessName});
            this.ssStatusStrip.Location = new System.Drawing.Point(0, 651);
            this.ssStatusStrip.Name = "ssStatusStrip";
            this.ssStatusStrip.Size = new System.Drawing.Size(1060, 22);
            this.ssStatusStrip.TabIndex = 1;
            this.ssStatusStrip.Text = "statusStrip1";
            // 
            // tsslProcessId
            // 
            this.tsslProcessId.Name = "tsslProcessId";
            this.tsslProcessId.Size = new System.Drawing.Size(118, 17);
            this.tsslProcessId.Text = "toolStripStatusLabel1";
            // 
            // tsslProcessName
            // 
            this.tsslProcessName.Name = "tsslProcessName";
            this.tsslProcessName.Size = new System.Drawing.Size(118, 17);
            this.tsslProcessName.Text = "toolStripStatusLabel1";
            // 
            // lvwItemList
            // 
            this.lvwItemList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwItemList.FullRowSelect = true;
            this.lvwItemList.GridLines = true;
            this.lvwItemList.Location = new System.Drawing.Point(0, 24);
            this.lvwItemList.MultiSelect = false;
            this.lvwItemList.Name = "lvwItemList";
            this.lvwItemList.Size = new System.Drawing.Size(1060, 627);
            this.lvwItemList.TabIndex = 2;
            this.lvwItemList.UseCompatibleStateImageBehavior = false;
            this.lvwItemList.View = System.Windows.Forms.View.Details;
            this.lvwItemList.DoubleClick += new System.EventHandler(this.lvwItemList_DoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 673);
            this.Controls.Add(this.lvwItemList);
            this.Controls.Add(this.ssStatusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "水浒传天命之誓编辑器";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ssStatusStrip.ResumeLayout(false);
            this.ssStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 幫助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiGameOpenProcess;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiGameExit;
        private System.Windows.Forms.ToolStripMenuItem 勢力FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 英雄HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 州府PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem;
        private System.Windows.Forms.StatusStrip ssStatusStrip;
        private System.Windows.Forms.ListView lvwItemList;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcessId;
        private System.Windows.Forms.ToolStripStatusLabel tsslProcessName;
    }
}

