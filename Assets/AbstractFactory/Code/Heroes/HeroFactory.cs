using Object = UnityEngine.Object;

namespace Heroes
{
    public class HeroFactory
    {
        private readonly HeroesConfiguration heroesConfiguration;

        public HeroFactory(HeroesConfiguration heroesConfiguration)
        {
            this.heroesConfiguration = heroesConfiguration;
        }

        public Hero Create(string id)
        {
            var hero = heroesConfiguration.GetHeroPrefabById(id);
            return Object.Instantiate(hero);
        }
    }
}
