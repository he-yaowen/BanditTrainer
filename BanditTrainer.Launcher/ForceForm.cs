using System.Windows.Forms;
using Bandit.Common;

namespace BanditTrainer.Launcher
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
