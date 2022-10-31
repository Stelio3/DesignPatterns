using System.Collections.Generic;
using UnityEngine;

namespace Hero
{
    public class HeroSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject[] _alliesToSpawn;

        private List<GameObject> _alliesSpawned;

        [SerializeField] private GameObject[]     _enemiesToSpawn;
        private                  List<GameObject> _enemiesSpawned;

        private void Awake()
        {
            _alliesSpawned  = new List<GameObject>();
            _enemiesSpawned = new List<GameObject>();
        }

        public void SpawnAllies()
        {
            foreach (var allyToSpawn in _alliesToSpawn)
            {
                var allyInstance = Instantiate(allyToSpawn);
                _alliesSpawned.Add(allyInstance);
            }
        }

        public void DestroyAllies()
        {
            foreach (var allyToDestroy in _alliesSpawned)
            {
                Destroy(allyToDestroy);
            }

            _alliesSpawned.Clear();
        }

        public void SpawnEnemies()
        {
            foreach (var enemyToSpawn in _enemiesToSpawn)
            {
                var enemyInstance = Instantiate(enemyToSpawn);
                _enemiesSpawned.Add(enemyInstance);
            }
        }

        public void DestroyEnemies()
        {
            foreach (var enemyToDestroy in _enemiesSpawned)
            {
                Destroy(enemyToDestroy);
            }

            _enemiesSpawned.Clear();
        }
    }
}
