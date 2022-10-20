using System;
using System.Collections.Generic;
using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(menuName = "Custom/Weapons configuration")]
    public class WeaponsConfiguration: ScriptableObject{
        [SerializeField] private Weapon[] weapons;
        private Dictionary<string, Weapon> idToWeapon;

        private void Awake()
        {
            idToWeapon = new Dictionary<string, Weapon>();
            foreach (var weapon in weapons)
            {
                idToWeapon.Add(weapon.Id, weapon);
            }
        }

        public Weapon GetWeaponPrefabById(string id)
        {
            if (!idToWeapon.TryGetValue(id, out var weapon))
            {
                throw new Exception($"Weapon with id {id} does not exit");
            }

            return weapon;
        }
    }
}
