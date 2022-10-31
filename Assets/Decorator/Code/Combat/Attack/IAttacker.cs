using Combat.Damage;

namespace Combat.Attack
{
    public interface IAttacker
    {
        void Attack(IDamageReceiver damageReceiver);
    }
}
