using Combat.Damage;
using UnityEngine;

namespace Combat.Attack
{
    public class FireAttackerDecorator : AttackerDecorator
    {
        private readonly int _fireDamage;

        public FireAttackerDecorator(IAttacker attacker, int fireDamage) : base(attacker)
        {
            _fireDamage = fireDamage;
        }

        public override void Attack(IDamageReceiver damageReceiver)
        {
            base.Attack(damageReceiver);
            damageReceiver.ReceiveDamage(_fireDamage, Color.red);
        }
    }
}
