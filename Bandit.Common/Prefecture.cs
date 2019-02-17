namespace Bandit.Common
{
    public enum BeastType { 虎, 狼, 熊, 豹 };

    public class Prefecture
    {
        public const int MaxCount = 49;

        public int Id;
        public string Name;
        public int Castles;
        public bool HasShipyard;
        public bool HasSmithy;
        public int Gold;
        public int Food;
        public int Metal;
        public int Fur;
        public int Rate;
        public int Flood;
        public int Land;
        public int Wealth;
        public int Support;
        public int Arm;
        public int Skill;
        public int RulerID;
        public bool HasSnowstorm;
        public BeastType BeastType;
        public int BeastNum;
    }
}
