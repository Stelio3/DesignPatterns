using System;
using UnityEngine;

namespace Vehicle
{
    public abstract class Chassis : MonoBehaviour
    {
        [SerializeField]
        private Transform _frontRightTyrePosition;
        [SerializeField]
        private Transform _frontLeftTyrePosition;
        [SerializeField]
        private Transform _rearRightTyrePosition;
        [SerializeField]
        private Transform _rearLeftTyrePosition;

        public Transform GetTyrePosition(TyrePositions position)
        {
            switch (position)
            {
                case TyrePositions.FrontLeft:
                    return _frontLeftTyrePosition;
                case TyrePositions.FrontRight:
                    return _frontRightTyrePosition;
                case TyrePositions.RearLeft:
                    return _rearLeftTyrePosition;
                case TyrePositions.RearRight:
                    return _rearRightTyrePosition;
            }
            
            throw new ArgumentOutOfRangeException(nameof(position), position, null);
        }

        protected abstract void OnCollisionEnter(Collision other);
    }
}