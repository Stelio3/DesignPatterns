using Combat.Damage;
using UnityEngine;

namespace Combat.Attack
{
    public abstract class AttackerDecorator : IAttacker
    {
        private readonly IAttacker _attacker;

        public AttackerDecorator(IAttacker attacker)
        {
            _attacker = attacker;
        }

        public virtual void Attack(IDamageReceiver damageReceiver)
        {
            _attacker.Attack(damageReceiver);
        }
    }
}
