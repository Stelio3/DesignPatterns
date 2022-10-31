using System;
using System.Threading.Tasks;
using Command;
using UnityEngine;

namespace Combat.Command
{
    public class UpdateHealthUiCommand : ICommand
    {
        public async Task Execute()
        {
            Debug.Log("Update UI");
            await Task.Delay(TimeSpan.FromSeconds(1));
        }
    }
}
