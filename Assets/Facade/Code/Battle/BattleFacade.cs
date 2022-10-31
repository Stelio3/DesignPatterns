using Hero;
using Transitions;
using UnityEngine;

namespace Battle
{
    public class BattleFacade : MonoBehaviour
    {
        [SerializeField] private HeroSpawner _heroSpawner;
        [SerializeField] private HeroUi      _heroUi;
        [SerializeField] private ScreenFade  _screenFade;

        public void StartBattle()
        {
            _screenFade.Show();
            _heroSpawner.SpawnAllies();
            _heroSpawner.SpawnEnemies();
            _heroUi.ShowAlliesUi();
            _heroUi.ShowEnemiesUi();
            _screenFade.Hide();
        }

        public void EndBattle()
        {
            _screenFade.Show();
            _heroSpawner.DestroyAllies();
            _heroSpawner.DestroyEnemies();
            _heroUi.HideAlliesUi();
            _heroUi.HideEnemiesUi();
            _screenFade.Hide();
        }
    }
}
