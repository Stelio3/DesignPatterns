using System.Collections.Generic;
using UnityEngine.Assertions;

namespace Enemies.States
{
    public class EnemyStatesConfiguration
    {
        private int InitialState;

        public const int IdleState = 0;
        public const int FindTargetState = 1;
        public const int MovingToTargetState = 2;
        public const int AttackingTargetState = 3;

        private readonly Dictionary<int, IEnemyState> _states;

        public EnemyStatesConfiguration()
        {
            _states = new Dictionary<int, IEnemyState>();
        }

        public void AddInitialState(int id, IEnemyState state)
        {
            _states.Add(id, state);
            InitialState = id;
        }

        public void AddState(int id, IEnemyState state)
        {
            _states.Add(id, state);
        }

        public IEnemyState GetState(int stateId)
        {
            Assert.IsTrue(_states.ContainsKey(stateId), $"State with id {stateId} do not exit");
            return _states[stateId];
        }

        public IEnemyState GetInitialState()
        {
            return GetState(InitialState);
        }
    }
}
