using UnityEngine;

namespace Vehicle
{
    public class ExplosiveChassis : Chassis
    {
        protected override void OnCollisionEnter(Collision other)
        {
            // Explota al colisionar
        }
    }
    
    
}