using UnityEngine;

namespace Combat.Damage
{
    public interface IDamageReceiver
    {
        void ReceiveDamage(int damage, Color color);
    }
}
