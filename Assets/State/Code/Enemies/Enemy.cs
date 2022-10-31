using Enemies.States;
using UnityEngine;

namespace Enemies
{
    public class Enemy : MonoBehaviour, ITarget
    {
        public Vector3 CurrentPosition => transform.position;

        private EnemyStatesConfiguration _enemyStatesConfiguration;
        private TargetFinder _targetsFinder;

        private void Awake()
        {
            _enemyStatesConfiguration = new EnemyStatesConfiguration();
            _enemyStatesConfiguration.AddInitialState(EnemyStatesConfiguration.IdleState,
                                                      new IdleState(2.0f)
                                                     );
            _enemyStatesConfiguration.AddState(EnemyStatesConfiguration.FindTargetState,
                                               new FindTargetState(this, 20, TargetFinder.Instance));
            _enemyStatesConfiguration.AddState(EnemyStatesConfiguration.MovingToTargetState,
                                               new MoveToTargetState(this, 2, 2));
            
            _enemyStatesConfiguration.AddState(EnemyStatesConfiguration.AttackingTargetState,
                                               new AttackToTargetState(2));

        }

        private void Start()
        {
            StartState(_enemyStatesConfiguration.GetInitialState());
        }

        private async void StartState(IEnemyState state, object data = null)
        {
            while (true)
            {
                var resultData = await state.DoAction(data);
                var nextState = _enemyStatesConfiguration.GetState(resultData.NextStateId);
                state = nextState;
                data = resultData.ResultData;
            }
        }

        public void DoDamage(float damageToApply)
        {
            Debug.Log("Receiving damage");
        }
    }
}
