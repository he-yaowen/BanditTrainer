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
using Bandit;
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

        private void SetItemListColumns(string[] columns)
        {
            lvwItemList.Columns.Clear();

            foreach (string column in columns) {
                lvwItemList.Columns.Add(column);
            }
        }

        public void UpdateHeroItem(ListViewItem item, Hero hero)
        {
            item.SubItems.Clear();
            item.Text = (hero.Id).ToString();
            item.SubItems.Add(hero.Name);
            item.SubItems.Add(hero.Nickname);
            item.SubItems.Add(hero.Gender.ToString());
            item.SubItems.Add(hero.Steersman.ToString());
            item.SubItems.Add(hero.DebutYear.ToString());
            item.SubItems.Add(hero.Position.ToString());
            item.SubItems.Add(hero.Age.ToString());

            Hero master = GameProcess.GetHeroMaster(hero);

            if (master == null) {
                item.SubItems.Add("");
            } else {
                item.SubItems.Add(master.Name);
            }
            item.SubItems.Add((hero.PrefectureId + 1).ToString());
            item.SubItems.Add(hero.Stamina.ToString());
            item.SubItems.Add(hero.StaminaMax.ToString());
            item.SubItems.Add(hero.Integrity.ToString());
            item.SubItems.Add(hero.Mercy.ToString());
            item.SubItems.Add(hero.Courage.ToString());
            item.SubItems.Add(hero.Strength.ToString());
            item.SubItems.Add(hero.Dexterity.ToString());
            item.SubItems.Add(hero.Wisdom.ToString());
            item.SubItems.Add(hero.StrengthExp.ToString());
            item.SubItems.Add(hero.DexterityExp.ToString());
            item.SubItems.Add(hero.WisdomExp.ToString());
            item.SubItems.Add(hero.Loyalty.ToString());
            item.SubItems.Add(hero.Popularity.ToString());
            item.SubItems.Add(hero.Men.ToString());
            item.SubItems.Add(hero.IsDebuted.ToString());
            item.SubItems.Add(hero.HasBoat.ToString());
        }

        public void InsertHeroItem(Hero hero)
        {
            ListViewItem item = lvwItemList.Items.Add("");
            UpdateHeroItem(item, hero);
        }

        private void action_OpenProcess(object sender, EventArgs e)
        {
            ProcessForm.action_RefreshProcessList(sender, e);
            ProcessForm.ShowDialog();
        }

        private void action_Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void action_ListForces(object sender, EventArgs e)
        {
        }

        private void action_ListHeroes(object sender, EventArgs e)
        {
            lvwItemList.Items.Clear();
            string[] columns = { "ID", "姓名", "諢名", "性別", "舵手", "登場年", "身份", "年齡",
                "所屬", "所在", "體力", "體力上限", "忠義", "仁愛", "勇氣", "腕力", "技量", "智力",
                "腕力經驗", "技量經驗", "智力經驗", "忠誠", "人氣", "下屬", "登場", "擁有船隻" };

            SetItemListColumns(columns);

            foreach (Hero hero in GameProcess.Heroes) {
                InsertHeroItem(hero);
            }
        }

        private void action_ListPrefectures(object sender, EventArgs e)
        {
        }
    }
}
