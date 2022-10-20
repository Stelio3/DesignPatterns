using Object = UnityEngine.Object;

namespace Weapons
{
    public class WeaponFactory
    {
        private readonly WeaponsConfiguration weaponsConfiguration;

        public WeaponFactory(WeaponsConfiguration weaponsConfiguration)
        {
            this.weaponsConfiguration = weaponsConfiguration;
        }

        public Weapon Create(string id)
        {
            var weapon = weaponsConfiguration.GetWeaponPrefabById(id);
            return Object.Instantiate(weapon);
        }
    }
}
