using System;
using System.Threading.Tasks;

namespace Enemies.States
{
    public class IdleState : IEnemyState
    {
        private readonly float _secondsToWait;

        public IdleState(float secondsToWait)
        {
            _secondsToWait = secondsToWait;
        }

        public async Task<StateResult> DoAction(object data)
        {
            await Task.Delay(TimeSpan.FromSeconds(_secondsToWait));
            return new StateResult(EnemyStatesConfiguration.FindTargetState);
        }
    }
}
