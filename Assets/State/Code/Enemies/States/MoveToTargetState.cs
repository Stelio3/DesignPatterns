using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Assertions;

namespace Enemies.States
{
    public class MoveToTargetState : IEnemyState
    {
        private readonly Enemy _enemy;
        private readonly float _sqrMinDistanceToAttack;
        private readonly float _movementSpeed;

        public MoveToTargetState(Enemy enemy, float minDistanceToAttack, float movementSpeed)
        {
            _enemy = enemy;
            _movementSpeed = movementSpeed;
            _sqrMinDistanceToAttack = minDistanceToAttack * minDistanceToAttack;
        }
        public async Task<StateResult> DoAction(object data)
        {
            var target = data as Enemy;
            Assert.IsNotNull(target);
            var distanceToTheTarget = (target.CurrentPosition - _enemy.CurrentPosition);

            do
            {
                _enemy.transform.Translate(distanceToTheTarget.normalized * _movementSpeed * Time.deltaTime);
                await Task.Yield();
                distanceToTheTarget = (target.CurrentPosition - _enemy.CurrentPosition);
            } while (distanceToTheTarget.sqrMagnitude > _sqrMinDistanceToAttack);

            return new StateResult(EnemyStatesConfiguration.AttackingTargetState, target);
        }
    }
}
