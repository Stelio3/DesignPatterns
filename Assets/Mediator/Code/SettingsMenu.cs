using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private Button _backButton;
    [SerializeField] private CanvasGroup _canvasGroup;
    private MenuMediator _mediator;

    private void Awake()
    {
        _backButton.onClick.AddListener(()=>_mediator.BackToMainMenu());
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
