using System;
using System.Threading.Tasks;
using Command;
using UnityEngine;

namespace Combat.Command
{
    public class DoDamageCommand : ICommand
    {
        public async Task Execute()
        {
            Debug.Log("Damage");
            await Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}
