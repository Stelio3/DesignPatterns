using UnityEngine;

namespace Vehicle
{
    public class NormalChassis : Chassis
    {
        protected override void OnCollisionEnter(Collision other)
        {
            // Se va dañando con cada colisión
        }
    }
}