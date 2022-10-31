using Battle;
using UnityEngine;

public class EndBattleConsumer : MonoBehaviour
{
    /* [SerializeField] private HeroSpawner _heroSpawner;
    [SerializeField] private HeroUi      _heroUi;
    [SerializeField] private ScreenFade  _screenFade; */
    [SerializeField] private BattleFacade _battleFacade;

    private void Update()
    {
        if (Input.GetKey(KeyCode.F2))
        {
            /* _screenFade.Show();
            _heroSpawner.DestroyAllies();
            _heroSpawner.DestroyEnemies();
            _heroUi.HideAlliesUi();
            _heroUi.HideEnemiesUi();
            _screenFade.Hide(); */
            _battleFacade.EndBattle();
        }
    }
}
