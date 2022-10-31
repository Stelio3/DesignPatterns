using System;
using System.Collections.Generic;
using Command;
using UnityEngine;

namespace Consumer
{
    public class Installer : MonoBehaviour
    {
        [SerializeField] private Menu1 _menu1;
        [SerializeField] private Menu2 _menu2;

        [SerializeField] private CanvasGroup _canvasGroup1;
        [SerializeField] private CanvasGroup _canvasGroup2;
        
        private void Awake()
        {
            var menu1Commands = new List<ICommand>
            {
                new CanvasFadeCommand(_canvasGroup1, 0, 0.5f),
                new CanvasFadeCommand(_canvasGroup2, 1, 0.5f)
            };
            _menu1.Configure(menu1Commands);
            
            
            var menu2Commands = new List<ICommand>
            {
                new CanvasFadeCommand(_canvasGroup2, 0, 0.5f),
                new LoadSceneCommand("Game")
            };
            _menu2.Configure(menu2Commands);
        }
    }
}