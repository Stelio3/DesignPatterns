using Combat.Command;
using Command;
using UnityEngine;

namespace Combat
{
    public class CombatConsumer : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.F1))
            {
                var compositeCommand = new CompositeCommand();
                compositeCommand.AddCommand(new DoDamageCommand());
                compositeCommand.AddCommand(new CameraShakeCommand());
                compositeCommand.AddCommand(new UpdateHealthUiCommand());
                
                CommandQueue.Instance.AddCommand(compositeCommand);
            }
        }
    }
}
