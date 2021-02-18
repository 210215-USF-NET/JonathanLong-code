using System.Collections.Generic;
using ToHModels;

namespace ToHDL
{
    public class HeroRepoSC : IHeroRepository
    {
        public Hero AddHero(Hero newHero)
        {
            Storage.AllHeroes.Add(newHero);
            return newHero;
        }

        public List<Hero> GetHeroes()
        {
            return Storage.AllHeroes;
        }
    }
}