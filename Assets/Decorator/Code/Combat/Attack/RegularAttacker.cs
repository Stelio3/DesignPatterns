using Combat.Damage;
using UnityEngine;

namespace Combat.Attack
{
    public class RegularAttacker : IAttacker
    {
        private readonly int _damage;

        public RegularAttacker(int damage)
        {
            _damage = damage;
        }

        public void Attack(IDamageReceiver damageReceiver)
        {
            damageReceiver.ReceiveDamage(_damage, Color.white);
        }
    }
}