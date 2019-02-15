namespace Launcher
{
    partial class ProcessForm
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
            this.lvwProcessList = new System.Windows.Forms.ListView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwProcessList
            // 
            this.lvwProcessList.FullRowSelect = true;
            this.lvwProcessList.GridLines = true;
            this.lvwProcessList.Location = new System.Drawing.Point(12, 12);
            this.lvwProcessList.MultiSelect = false;
            this.lvwProcessList.Name = "lvwProcessList";
            this.lvwProcessList.Size = new System.Drawing.Size(270, 303);
            this.lvwProcessList.TabIndex = 0;
            this.lvwProcessList.UseCompatibleStateImageBehavior = false;
            this.lvwProcessList.View = System.Windows.Forms.View.List;
            this.lvwProcessList.DoubleClick += new System.EventHandler(this.action_SelectProcess);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(110, 321);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "刷新(&R)";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.action_RefreshProcessList);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(12, 321);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "选择(&S)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.action_SelectProcess);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(207, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.action_CloseWindow);
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 357);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lvwProcessList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "进程列表";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwProcessList;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnCancel;
    }
}