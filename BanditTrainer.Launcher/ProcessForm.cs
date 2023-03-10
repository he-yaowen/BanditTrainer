using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BanditTrainer.Launcher
{
    public partial class ProcessForm : Form
    {

        public ProcessForm()
        {
            InitializeComponent();
        }

        public void action_RefreshProcessList(object sender, EventArgs e)
        {
            lvwProcessList.Items.Clear();

            Process[] procs = Process.GetProcesses();

            foreach (var proc in procs) {
                if (proc.MainWindowTitle != "") {
                    ListViewItem item = lvwProcessList.Items.Add(proc.Id.ToString() + " - " + proc.MainWindowTitle);
                    item.Tag = proc;
                }
            }
        }

        private void action_SelectProcess(object sender, EventArgs e)
        {
            Process proc = (Process)lvwProcessList.SelectedItems[0].Tag;

            ((MainForm)Owner).AttachProcess(proc);

            action_CloseWindow(sender, e);
        }

        private void action_CloseWindow(object sender, EventArgs e)
        {
            Close();
        }
    }
} 