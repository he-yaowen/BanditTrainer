using System;
using System.Diagnostics;
using Bandit.Helper;

namespace Bandit.Runtime
{
    public class GameProcess_Win32_zhTW : GameProcess
    {
        private const int HeroStateAddress = 0x48F6E0;
        private const int HeroStateLength = 0x1A; // 26 bytes

        private const int HeroInfoAddress = 0x491A40;
        private const int HeroInfoLength = 0x28; // 40 bytes

        private const int PrefectureStateAddress = 0x49129C;
        private const int PrefectureStateLength = 0x28; // 40 bytes

        private const int PrefectureInfoAddress = 0x494218;
        private const int PrefectureInfoLength = 0x1A; // 26 bytes

        protected override void LoadForces(Process process)
        {
            throw new NotImplementedException();
        }

        protected override void LoadHeroes(Process process)
        {
            Heroes.Clear();

            IntPtr hProcess = ProcessMemoryHelper.OpenProcess(ProcessMemoryHelper.PROCESS_VM_READ, false, process.Id);

            for (int i = 0; i < Hero.MaxCount; i++) {
                Hero hero = new Hero();

                byte[] stateBuffer = new byte[HeroStateLength];
                ProcessMemoryHelper.ReadProcessMemory(hProcess, (IntPtr)HeroStateAddress + (i * HeroStateLength), stateBuffer, HeroStateLength, IntPtr.Zero);

                hero.Id = i;
                hero.Age = stateBuffer[4];
                hero.MasterId = stateBuffer[5];
                hero.PrefectureId = stateBuffer[6];
                hero.Stamina = stateBuffer[7];
                hero.StaminaMax = stateBuffer[8];
                hero.Integrity = stateBuffer[9];
                hero.Mercy = stateBuffer[10];
                hero.Courage = stateBuffer[11];
                hero.Strength = stateBuffer[12];
                hero.Dexterity = stateBuffer[13];
                hero.Wisdom = stateBuffer[14];
                hero.StrengthExp = stateBuffer[15];
                hero.DexterityExp = stateBuffer[16];
                hero.WisdomExp = stateBuffer[17];
                hero.Loyalty = stateBuffer[18];
                hero.Hire = stateBuffer[19];
                hero.Popularity = stateBuffer[21] * 0x100 + stateBuffer[20];
                hero.Men = stateBuffer[24];
                hero.IsDebuted = (stateBuffer[25] & 0x80) == 0x80;
                hero.HasBoat = (stateBuffer[25] & 0x40) == 0x40;
                hero.Position = (HeroPosition)(stateBuffer[25] & 0x3F);

                byte[] infoBuffer = new byte[HeroInfoLength];
                ProcessMemoryHelper.ReadProcessMemory(hProcess, (IntPtr)HeroInfoAddress + (i * HeroInfoLength), infoBuffer, HeroInfoLength, IntPtr.Zero);

                byte[] nameBuffer = new byte[7];
                Buffer.BlockCopy(infoBuffer, 0, nameBuffer, 0, 7);
                hero.Name = TextHelper.ConvertUTF8(nameBuffer);

                byte[] nicknameBuffer = new byte[9];
                Buffer.BlockCopy(infoBuffer, 16, nicknameBuffer, 0, 9);
                hero.Nickname = TextHelper.ConvertUTF8(nicknameBuffer);

                hero.FaceId = infoBuffer[37];
                hero.LineMode = infoBuffer[38];

                hero.Gender = hero.Gender = (HeroGender)((infoBuffer[39] & 0x80) == 0x80 ? 1 : 0);
                hero.Steersman = (infoBuffer[39] & 0x40) == 0x40 ? true : false;
                hero.DebutYear = (infoBuffer[39] & 0x1F) + 1100;

                Heroes.Add(hero);
            }
        }

        protected override void LoadPrefectures(Process process)
        {
            Prefectures.Clear();

            IntPtr hProcess = ProcessMemoryHelper.OpenProcess(ProcessMemoryHelper.PROCESS_VM_READ, false, process.Id);

            for (int i = 0; i < Prefecture.MaxCount; i++) {
                Prefecture prefecture = new Prefecture();

                byte[] stateBuffer = new byte[PrefectureStateLength];
                ProcessMemoryHelper.ReadProcessMemory(hProcess, (IntPtr)PrefectureStateAddress + (i * PrefectureStateLength), stateBuffer, PrefectureStateLength, IntPtr.Zero);

                prefecture.Id = i;

                prefecture.Gold = stateBuffer[0] + stateBuffer[1] * 0x100;
                prefecture.Food = stateBuffer[4] + stateBuffer[5] * 0x100;
                prefecture.Metal = stateBuffer[8] + stateBuffer[9] * 0x100;
                prefecture.Fur = stateBuffer[12] + stateBuffer[13] * 0x100;

                prefecture.Rate = stateBuffer[16];
                prefecture.Flood = stateBuffer[17];
                prefecture.Land = stateBuffer[18];
                prefecture.Wealth = stateBuffer[19];
                prefecture.Support = stateBuffer[20];
                prefecture.Arm = stateBuffer[21];
                prefecture.Skill = stateBuffer[22];

                prefecture.HasSnowstorm = (stateBuffer[23] & 0x40) == 0x40;
                prefecture.BeastType = (BeastType)((stateBuffer[23] & 0x18) >> 3);
                prefecture.BeastNum = stateBuffer[23] & 0x07;

                int rulerAddress = stateBuffer[24] + stateBuffer[25] * 0x100 + stateBuffer[26] * 0x10000 + stateBuffer[27] * 0x1000000;

                if (rulerAddress == 0) {
                    prefecture.RulerID = -1;
                } else {
                    prefecture.RulerID = (rulerAddress - HeroStateAddress) / 26;
                }

                byte[] infoBuffer = new byte[PrefectureInfoLength];
                ProcessMemoryHelper.ReadProcessMemory(hProcess, (IntPtr)PrefectureInfoAddress + (i * PrefectureInfoLength), infoBuffer, PrefectureInfoLength, IntPtr.Zero);

                byte[] nameBuffer = new byte[5];
                Buffer.BlockCopy(infoBuffer, 0, nameBuffer, 0, 5);
                prefecture.Name = TextHelper.ConvertUTF8(nameBuffer);

                if (prefecture.Name.Length < 2) {
                    prefecture.Name = prefecture.Name + "州";
                } else {
                    prefecture.Name = prefecture.Name + "府";
                }

                prefecture.Castles = infoBuffer[5];

                prefecture.HasShipyard = (infoBuffer[24] & 0x01) == 0x01;
                prefecture.HasSmithy = (infoBuffer[24] & 0x02) == 0x02;

                Prefectures.Add(prefecture);
            }
        }
    }
}
