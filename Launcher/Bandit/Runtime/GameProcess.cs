using System.Collections.Generic;
using System.Diagnostics;
using Bandit;

namespace Bandit.Runtime
{
    public abstract class GameProcess
    {
        public List<Force> Forces;
        public List<Hero> Heroes;
        public List<Prefecture> Prefectures;

        protected abstract void LoadForces(Process process);
        protected abstract void LoadHeroes(Process process);
        protected abstract void LoadPrefectures(Process process);

        public GameProcess()
        {
            Forces = new List<Force>();
            Heroes = new List<Hero>();
            Prefectures = new List<Prefecture>();
        }

        public void AttachProcess(Process process)
        {
            LoadForces(process);
            LoadHeroes(process);
            LoadPrefectures(process);
        }

        public Hero GetHeroMaster(Hero hero)
        {
            if (hero.Position < HeroPosition.死亡) {
                return Heroes[hero.MasterId];
            } else {
                return null;
            }
        }
    }
}
