using Battle;
using UnityEngine;

public class StartBattleConsumer : MonoBehaviour
{
    /* [SerializeField] private HeroSpawner _heroSpawner;
    [SerializeField] private HeroUi      _heroUi;
    [SerializeField] private ScreenFade  _screenFade; */
    [SerializeField] private BattleFacade _battleFacade;

    private void Update()
    {
        if (Input.GetKey(KeyCode.F1))
        {
            /* _screenFade.Show();
            _heroSpawner.SpawnAllies();
            _heroSpawner.SpawnEnemies();
            _heroUi.ShowAlliesUi();
            _heroUi.ShowEnemiesUi();
            _screenFade.Hide(); */
            _battleFacade.StartBattle();
        }
    }
}
