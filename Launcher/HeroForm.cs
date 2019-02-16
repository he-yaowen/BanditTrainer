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
    public partial class HeroForm : Form
    {
        private Hero Hero;

        public HeroForm()
        {
            InitializeComponent();
        }

        private void RefreshForm()
        {
            gbxHero.Text = "编号: " + Hero.Id.ToString();
            txtName.Text = Hero.Name.ToString();
            txtAge.Text = Hero.Age.ToString();
            txtDebutYear.Text = Hero.DebutYear.ToString();
            txtNickname.Text = Hero.Nickname.ToString();
            txtLoyalty.Text = Hero.Loyalty.ToString();
            txtPopularity.Text = Hero.Popularity.ToString();
            txtMen.Text = Hero.Men.ToString();
            txtIntegrity.Text = Hero.Integrity.ToString();
            txtMercy.Text = Hero.Mercy.ToString();
            txtCourage.Text = Hero.Courage.ToString();
            txtStamina.Text = Hero.Stamina.ToString();
            txtStaminaMax.Text = Hero.StaminaMax.ToString();
            txtStrength.Text = Hero.Strength.ToString();
            txtStrengthExp.Text = Hero.StrengthExp.ToString();
            txtDexterity.Text = Hero.Dexterity.ToString();
            txtDexterityExp.Text = Hero.DexterityExp.ToString();
            txtWisdom.Text = Hero.Wisdom.ToString();
            txtWisdomExp.Text = Hero.WisdomExp.ToString();

            cbxGender.SelectedIndex = Hero.Gender == HeroGender.男 ? 0 : 1;
            cbxHasBoat.SelectedIndex = Hero.HasBoat ? 0 : 1;
            cbxSteersman.SelectedIndex = Hero.Steersman ? 0 : 1;
            cbxIsDebuted.SelectedIndex = Hero.IsDebuted ? 0 : 1;
        }

        public void SetHero(Hero hero)
        {
            Hero = hero;
            RefreshForm();
        }
    }
}
