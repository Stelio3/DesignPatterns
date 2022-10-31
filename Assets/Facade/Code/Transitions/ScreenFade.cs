using UnityEngine;

namespace Transitions
{
    public class ScreenFade : MonoBehaviour
    {
        [SerializeField] private CanvasGroup _canvasGroup;
        public void Show()
        {
            _canvasGroup.alpha = 1;
        }
        
        public void Hide()
        {
            _canvasGroup.alpha = 0;
        }
    }
}
