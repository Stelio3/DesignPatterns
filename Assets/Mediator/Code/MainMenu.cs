using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _settingsButton;
    [SerializeField] private CanvasGroup _canvasGroup;
    private MenuMediator _mediator;

    private void Awake()
    {
        _startGameButton.onClick.AddListener(()=>_mediator.StartGame());
        _settingsButton.onClick.AddListener(()=>_mediator.MoveToSettingsMenu());
    }

    public void Configure(MenuMediator mediator)
    {
        _mediator = mediator;
    }
    
    public void Show()
    {
        _canvasGroup.DOFade(1.0f, 0.5f);
    }

    public void Hide()
    {
        _canvasGroup.DOFade(0.0f, 0.5f);
    }
}
