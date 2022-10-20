using System;
using UnityEngine;
using UnityEngine.UI;

namespace Vehicle
{
    public class UI : MonoBehaviour
    {
        [SerializeField] private Chassis _chassis1;
        [SerializeField] private Chassis _chassis2;

        [SerializeField] private Tyre _tyre1;
        [SerializeField] private Tyre _tyre2;

        [SerializeField] private Vehicle _vehicle;


        [SerializeField] private Button _tyre1Button;
        [SerializeField] private Button _tyre2Button;

        [SerializeField] private Button _chassis1Button;
        [SerializeField] private Button _chassis2Button;

        [SerializeField] private Button _buildButton;

        private VehicleBuilder _vehicleBuilder;
        private Vehicle _vehicleInstance;

        private void Awake()
        {
            _vehicleBuilder = new VehicleBuilder();
            _vehicleBuilder.FromVehiclePrefab(_vehicle);

            _tyre1Button.onClick.AddListener(Tyre1Pressed);
            _tyre2Button.onClick.AddListener(Tyre2Pressed);

            _chassis1Button.onClick.AddListener(Chassis1Pressed);
            _chassis2Button.onClick.AddListener(Chassis2Pressed);

            _buildButton.onClick.AddListener(BuildPressed);
        }

        private void BuildPressed()
        {
            if (_vehicleInstance != null)
            {
                Destroy(_vehicleInstance.gameObject);
            }

            _vehicleInstance = _vehicleBuilder.Build();
        }

        private void Chassis2Pressed()
        {
            _vehicleBuilder.WithChassis(_chassis2);
        }

        private void Chassis1Pressed()
        {
            _vehicleBuilder.WithChassis(_chassis1);
        }

        private void Tyre2Pressed()
        {
            _vehicleBuilder.WithTyre(TyrePositions.FrontLeft, _tyre2);
            _vehicleBuilder.WithTyre(TyrePositions.FrontRight, _tyre2);
            _vehicleBuilder.WithTyre(TyrePositions.RearLeft, _tyre2);
            _vehicleBuilder.WithTyre(TyrePositions.RearRight, _tyre2);
        }

        private void Tyre1Pressed()
        {
            _vehicleBuilder.WithTyre(TyrePositions.FrontLeft, _tyre1);
            _vehicleBuilder.WithTyre(TyrePositions.FrontRight, _tyre1);
            _vehicleBuilder.WithTyre(TyrePositions.RearLeft, _tyre1);
            _vehicleBuilder.WithTyre(TyrePositions.RearRight, _tyre1);
        }
    }
}