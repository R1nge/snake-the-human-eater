using _Assets.Scripts.Services.Factories;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace _Assets.Scripts.Services.StateMachine.States
{
    public class GameState : IAsyncState
    {
        private readonly GameStateMachine _stateMachine;
        private readonly PlayerFactory _playerFactory;

        public GameState(GameStateMachine stateMachine, PlayerFactory playerFactory)
        {
            _stateMachine = stateMachine;
            _playerFactory = playerFactory;
        }

        public async UniTask Enter()
        {
            var player = _playerFactory.Create(Vector3.zero);
        }

        public async UniTask Exit() { }
    }
}