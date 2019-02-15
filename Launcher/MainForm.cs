using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using Bandit.Runtime;

namespace Launcher
{
    public partial class MainForm : Form
    {
        public GameProcess GameProcess;

        public ProcessForm ProcessForm;
        public ForceForm ForceForm;
        public HeroForm HeroForm;
        public PrefectureForm PrefectureForm;

        public MainForm()
        {
            InitializeComponent();

            GameProcess = new GameProcess_Win32_zhTW();

            ProcessForm = new ProcessForm();
            ProcessForm.Owner = this;

            ForceForm = new ForceForm();
            ForceForm.Owner = this;

            HeroForm = new HeroForm();
            HeroForm.Owner = this;

            PrefectureForm = new PrefectureForm();
            PrefectureForm.Owner = this;
        }

        public void AttachProcess(Process process)
        {
            tsslProcessId.Text = process.Id.ToString();
            tsslProcessName.Text = process.ProcessName + ".exe";

            GameProcess.AttachProcess(process);
        }

        private void action_OpenProcess(object sender, EventArgs e)
        {
            ProcessForm.action_RefreshProcessList(sender, e);
            ProcessForm.ShowDialog();
        }

        private void action_Exit(object sender, EventArgs e)
        {
        }

        private void action_ListForces(object sender, EventArgs e) { }
        private void action_ListHeroes(object sender, EventArgs e) { }
        private void action_ListPrefectures(object sender, EventArgs e) { }
    }
}
