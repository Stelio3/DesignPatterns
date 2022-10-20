using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

namespace Vehicle
{
    public class VehicleBuilder
    {
        private Chassis _chassis;
        private readonly Dictionary<TyrePositions, Tyre> _tyres = new Dictionary<TyrePositions, Tyre>();
        private Vector3 _position;
        private Quaternion _rotation;
        private Vehicle _vehicle;

        public VehicleBuilder WithChassis(Chassis chassis)
        {
            _chassis = chassis;
            return this;
        }

        public VehicleBuilder WithTyre(TyrePositions position, Tyre tyre)
        {
            if (_tyres.ContainsKey(position))
            {
                _tyres.Remove(position);
            }
            _tyres.Add(position, tyre);
            return this;
        }

        public VehicleBuilder WithPosition(Vector3 position)
        {
            _position = position;
            return this;
        }
        
        public VehicleBuilder WithRotation(Quaternion rotation)
        {
            _rotation = rotation;
            return this;
        }

        public VehicleBuilder FromVehiclePrefab(Vehicle vehicle)
        {
            _vehicle = vehicle;
            return this;
        }

        public Vehicle Build()
        {
            CheckPreConditions();
            var vehicle = Object.Instantiate(_vehicle, _position, _rotation);
            var chassis = Object.Instantiate(_chassis, vehicle.transform, true);
            var tyres = new Dictionary<TyrePositions, Tyre>();
            foreach (var tyre in _tyres)
            {
                var tyreInstance = Object.Instantiate(tyre.Value, chassis.GetTyrePosition(tyre.Key));
                tyres.Add(tyre.Key, tyreInstance);
            }
            
            vehicle.SetComponents(tyres, chassis);

            return vehicle;
        }
        
        private void CheckPreConditions()
        {
            Assert.IsNotNull(_vehicle);
            Assert.IsNotNull(_chassis);
            Assert.AreEqual(4, _tyres.Count);
            Assert.IsNotNull(_tyres[TyrePositions.FrontLeft]);
            Assert.IsNotNull(_tyres[TyrePositions.FrontRight]);
            Assert.IsNotNull(_tyres[TyrePositions.RearLeft]);
            Assert.IsNotNull(_tyres[TyrePositions.RearRight]);
        }


    }
}