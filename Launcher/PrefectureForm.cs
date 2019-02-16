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
    public partial class PrefectureForm : Form
    {
        Prefecture Prefecture;

        public PrefectureForm()
        {
            InitializeComponent();
        }

        private void RefreshForm()
        {
            gbxPrefecture.Text = "编号: " + Prefecture.Id;
            txtName.Text = Prefecture.Name;
            txtCastles.Text = Prefecture.Castles.ToString();

            Hero ruler = ((MainForm)(this.Owner)).GameProcess.GetPrefectureRuler(Prefecture);

            if (ruler == null) {
                cbxMaster.SelectedIndex = -1;
                cbxRuler.SelectedIndex = -1;
            } else {
                cbxMaster.SelectedIndex = ruler.MasterId;
                cbxRuler.SelectedIndex = Prefecture.RulerID;
            }

            cbxHasShipyard.SelectedIndex = Prefecture.HasShipyard ? 0 : 1;
            cbxHasSmithy.SelectedIndex = Prefecture.HasSmithy ? 0 : 1;
            txtGold.Text = Prefecture.Gold.ToString();
            txtFood.Text = Prefecture.Food.ToString();
            txtMetal.Text = Prefecture.Metal.ToString();
            txtFur.Text = Prefecture.Fur.ToString();
            txtRate.Text = Prefecture.Rate.ToString();
            txtFlood.Text = Prefecture.Flood.ToString();
            txtLand.Text = Prefecture.Land.ToString();
            txtWealth.Text = Prefecture.Wealth.ToString();
            txtSupport.Text = Prefecture.Support.ToString();
            txtArm.Text = Prefecture.Arm.ToString();
            txtSkill.Text = Prefecture.Skill.ToString();
    }

        public void SetPrefecture(Prefecture prefecture)
        {
            Prefecture = prefecture;
            RefreshForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
