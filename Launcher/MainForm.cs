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

        public void UpdateForceItem(ListViewItem item, Force force)
        {
            item.SubItems.Clear();
            item.Text = force.Id.ToString();

            Hero master = GameProcess.GetForceMaster(force);

            if (master == null) {
                item.SubItems.Add("");
            } else {
                item.SubItems.Add(master.Name);
            }

            item.SubItems.Add(force.IsExiling.ToString());
        }

        public void InsertForceItem(Force force)
        {
            ListViewItem item = lvwItemList.Items.Add("");
            UpdateForceItem(item, force);
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

        public void UpdatePrefectureItem(ListViewItem item, Prefecture prefecture)
        {
            Hero ruler;
            List<Hero> heroes;
            List<Hero> people;
            int men = 0;


            item.SubItems.Clear();
            item.Text = (prefecture.Id + 1).ToString();
            item.SubItems.Add(prefecture.Name);
            ruler = GameProcess.GetPrefectureRuler(prefecture);

            if (ruler == null) {
                item.SubItems.Add("");
                item.SubItems.Add("");
            } else {
                item.SubItems.Add(GameProcess.GetHeroMaster(ruler).Name);
                item.SubItems.Add(ruler.Name);
            }

            item.SubItems.Add(prefecture.Castles.ToString());
            item.SubItems.Add(prefecture.HasSmithy.ToString());
            item.SubItems.Add(prefecture.HasShipyard.ToString());
            item.SubItems.Add(prefecture.Gold.ToString());
            item.SubItems.Add(prefecture.Food.ToString());
            item.SubItems.Add(prefecture.Metal.ToString());
            item.SubItems.Add(prefecture.Fur.ToString());
            item.SubItems.Add(prefecture.Rate.ToString());
            item.SubItems.Add(prefecture.Support.ToString());
            item.SubItems.Add(prefecture.Flood.ToString());
            item.SubItems.Add(prefecture.Land.ToString());
            item.SubItems.Add(prefecture.Wealth.ToString());

            heroes = GameProcess.GetPrefectureHeroes(prefecture, true);
            people = GameProcess.GetPrefectureHeroes(prefecture, false);
            item.SubItems.Add(heroes.Count.ToString());
            item.SubItems.Add(people.Count.ToString());

            foreach (Hero hero in heroes) {
                men += hero.Men;
            }

            item.SubItems.Add(men.ToString());
            item.SubItems.Add(prefecture.Arm.ToString());
            item.SubItems.Add(prefecture.Skill.ToString());
        }

        public void InsertPrefectureItem(Prefecture prefecture)
        {
            ListViewItem item = lvwItemList.Items.Add("");
            UpdatePrefectureItem(item, prefecture);
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
            lvwItemList.Items.Clear();
            string[] columns = { "ID", "首领", "逃亡中" };

            SetItemListColumns(columns);

            foreach (Force force in GameProcess.Forces) {
                InsertForceItem(force);
            }
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
            lvwItemList.Items.Clear();

            string[] columns = {"ID", "名稱", "勢力", "首領", "城數", "武器店", "造船廠", "金錢",
                "糧食", "鐵", "毛皮", "物價", "共鳴度", "治水", "開墾", "開發", "英雄", "在野",
                "士兵", "武裝度", "訓練度"};

            SetItemListColumns(columns);

            foreach (Prefecture prefecture in GameProcess.Prefectures) {
                InsertPrefectureItem(prefecture);
            }
        }

        private void action_ShowHeroForm(object sender, EventArgs e)
        {
            HeroForm.SetHero(GameProcess.Heroes[lvwItemList.SelectedItems[0].Index]);
            HeroForm.ShowDialog();
        }
    }
}
