using UnityEngine;

namespace Hero
{
    public class HeroUi : MonoBehaviour
    {
        [SerializeField] private GameObject _alliesUi;
        [SerializeField] private GameObject _enemiesUi;

        public void ShowAlliesUi()
        {
            _alliesUi.SetActive(true);
        }

        public void HideAlliesUi()
        {
            _alliesUi.SetActive(false);
        }

        public void ShowEnemiesUi()
        {
            _enemiesUi.SetActive(true);
        }

        public void HideEnemiesUi()
        {
            _enemiesUi.SetActive(false);
        }
    }
}
