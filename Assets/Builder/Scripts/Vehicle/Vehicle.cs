using System.Collections.Generic;
using UnityEngine;

namespace Vehicle
{
    public class Vehicle : MonoBehaviour
    {
        private Dictionary<TyrePositions, Tyre> _tyres;
        private Chassis _chassis;

        public void SetComponents(Dictionary<TyrePositions, Tyre> tyres, Chassis chassis)
        {
            _tyres   = tyres;
            _chassis = chassis;
        }
    }

}