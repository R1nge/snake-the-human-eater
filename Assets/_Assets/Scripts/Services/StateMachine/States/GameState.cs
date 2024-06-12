using _Assets.Scripts.Services.Factories;
using _Assets.Scripts.Services.UIs.StateMachine;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace _Assets.Scripts.Services.StateMachine.States
{
    public class GameState : IAsyncState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly UIStateMachine _uiStateMachine;
        private readonly PlayerFactory _playerFactory;
        private readonly EnemyFactory _enemyFactory;

        public GameState(GameStateMachine stateMachine, UIStateMachine uiStateMachine, PlayerFactory playerFactory, EnemyFactory enemyFactory)
        {
            _stateMachine = stateMachine;
            _uiStateMachine = uiStateMachine;
            _playerFactory = playerFactory;
            _enemyFactory = enemyFactory;
        }

        public async UniTask Enter()
        {
            await _uiStateMachine.SwitchState(UIStateType.Game);
            var player = _playerFactory.Create(Vector3.zero);
            var enemy = _enemyFactory.Create(Vector3.zero);
        }

        public async UniTask Exit()
        {
        }
    }
}