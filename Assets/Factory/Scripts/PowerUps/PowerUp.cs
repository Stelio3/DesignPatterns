using UnityEngine;

namespace PowerUps
{
    public abstract class PowerUp : MonoBehaviour
    {
        [SerializeField] private string _id;

        public string Id => _id;
    }
}