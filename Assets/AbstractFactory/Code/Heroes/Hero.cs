using UnityEngine;

namespace Heroes
{
    public abstract class Hero : MonoBehaviour
    {
        [SerializeField] protected string id;

        public string Id => id;
    }
}
