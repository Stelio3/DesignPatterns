using System;
using UnityEngine;

namespace PowerUps
{
    public class PowerUpSpawner : MonoBehaviour
    {
        [SerializeField] private PowerUpConfiguration _powerUpConfiguration;
        private PowerUpFactory _powerUpFactory;

        private void Awake()
        {
            _powerUpFactory = new PowerUpFactory(Instantiate(_powerUpConfiguration));
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Alpha1))
            {
                _powerUpFactory.Create("Speed");
            }
            else if (Input.GetKey(KeyCode.Alpha2))
            {
                _powerUpFactory.Create("Drunk");
            }
            else if (Input.GetKey(KeyCode.Alpha3))
            {
                _powerUpFactory.Create("Attack");
            }
        }
    }
}