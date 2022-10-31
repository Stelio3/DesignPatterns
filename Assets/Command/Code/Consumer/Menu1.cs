using System.Collections.Generic;
using Command;
using UnityEngine;
using UnityEngine.UI;

namespace Consumer
{
    public class Menu1 : MonoBehaviour
    {
        [SerializeField] private Button _showMenu2Button;

        [SerializeField] private CanvasGroup _canvasGroup1;
        [SerializeField] private CanvasGroup _canvasGroup2;
        private List<ICommand> _showNextMenuCommands;

        private void Awake()
        {
            _showMenu2Button.onClick.AddListener(ShowNextMenu);
        }

        private void ShowNextMenu()
        {
            foreach (var command in _showNextMenuCommands)
            {
                CommandQueue.Instance.AddCommand(command);
            }
        }

        public void Configure(List<ICommand> showNextMenuCommands)
        {
            _showNextMenuCommands = showNextMenuCommands;
        }
    }
}
