using System;
using System.Collections.Generic;
using UnityEngine;

namespace Heroes
{
    [CreateAssetMenu(menuName = "Custom/Heroes configuration")]
    public class HeroesConfiguration: ScriptableObject{
        [SerializeField] private Hero[] heroes;
        private Dictionary<string, Hero> idToHero;

        private void Awake()
        {
            idToHero = new Dictionary<string, Hero>();
            foreach (var hero in heroes)
            {
                idToHero.Add(hero.Id, hero);
            }
        }

        public Hero GetHeroPrefabById(string id)
        {
            if (!idToHero.TryGetValue(id, out var hero))
            {
                throw new Exception($"Hero with id {id} does not exit");
            }

            return hero;
        }
    }
}
