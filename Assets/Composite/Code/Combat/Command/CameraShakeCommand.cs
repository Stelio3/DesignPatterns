using System;
using System.Threading.Tasks;
using Command;
using UnityEngine;

namespace Combat.Command
{
    public class CameraShakeCommand : ICommand
    {
        public async Task Execute()
        {
            Debug.Log("Camera shakeeeee");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}
