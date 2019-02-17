using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bandit.Common
{
    public enum HeroGender { 女 = 0, 男 };

    public enum HeroPosition
    {
        寵臣 = 0, 高官, 官吏, 好漢, 首領, 無頼漢, 義兄, 義弟,
        死亡 = 32, 罪人, 僧侶, 漁夫, 大力士, 大夫, 商人, 酒屋, 匠人, 學者, 富豪, 少爺, 小姑娘, 藝妓,
        猟戶 = 48, 相撲力士, 武藝之人, 旅商人, 流浪武士, 道士, 浪人, 蠻橫之人
    };

    public class Hero
    {
        public const int MaxCount = 255;

        public int Id;
        public string Name;
        public string Nickname;
        public HeroGender Gender;
        public bool Steersman;
        public int DebutYear;
        public int Age;
        public int MasterId;
        public int PrefectureId;
        public int Stamina;
        public int StaminaMax;
        public int Integrity;
        public int Mercy;
        public int Courage;
        public int Strength;
        public int Dexterity;
        public int Wisdom;
        public int StrengthExp;
        public int DexterityExp;
        public int WisdomExp;
        public int Loyalty;
        public int Hire;
        public int Popularity;
        public int Men;
        public bool IsDebuted;
        public bool HasBoat;
        public HeroPosition Position;
        public int FaceId;
        public int LineMode;
    }

}
