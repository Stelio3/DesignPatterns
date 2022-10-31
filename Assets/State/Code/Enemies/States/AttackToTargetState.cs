using System.Threading.Tasks;
using UnityEngine.Assertions;

namespace Enemies.States
{
    public class AttackToTargetState : IEnemyState
    {
        private readonly float _damageToApply;

        public AttackToTargetState(float damageToApply)
        {
            _damageToApply = damageToApply;
        }
        public Task<StateResult> DoAction(object data)
        {
            var target = data as Enemy;
            Assert.IsNotNull(target);

            target.DoDamage(_damageToApply);
            return Task.FromResult(new StateResult(EnemyStatesConfiguration.IdleState));
        }
    }
}
