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
            throw new NotImplementedException();
        }
    }
}
