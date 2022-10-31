using System.Threading.Tasks;

namespace Enemies.States
{
    public class FindTargetState : IEnemyState
    {
        private readonly ITargetFinder _targetFinder;
        private readonly Enemy _enemy;
        private readonly float _sqrMaxDistance;

        public FindTargetState(Enemy enemy, float visionRange, ITargetFinder targetFinder)
        {
            _enemy = enemy;
            _sqrMaxDistance = visionRange * visionRange;
            _targetFinder = targetFinder;
        }

        public Task<StateResult> DoAction(object data)
        {
            var targets = _targetFinder.FindTargets();
            foreach (var target in targets)
            {
                if (target == _enemy)
                {
                    continue;
                }

                var sqrDistanceToTheTarget = (target.CurrentPosition - _enemy.CurrentPosition).sqrMagnitude;
                if (sqrDistanceToTheTarget > _sqrMaxDistance)
                {
                    continue;
                }

                return Task.FromResult(new StateResult(EnemyStatesConfiguration.MovingToTargetState, target));
            }

            return Task.FromResult(new StateResult(EnemyStatesConfiguration.IdleState));
        }
    }
}
