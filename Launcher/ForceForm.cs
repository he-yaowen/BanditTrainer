using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bandit;

namespace Launcher
{
    public partial class ForceForm : Form
    {
        Force Force;

        public ForceForm()
        {
            InitializeComponent();
        }

        private void RefreshForm()
        {
            gbxForce.Text = "编号: " + Force.Id;
            cbxMaster.SelectedIndex = Force.MasterId;
            cbxIsExiling.SelectedIndex = Force.IsExiling ? 0 : 1;
        }

        public void SetForce(Force force)
        {
            Force = force;
            RefreshForm();
        }
    }
}
