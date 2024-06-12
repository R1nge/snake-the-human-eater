using System;
using _Assets.Scripts.Services.Factories;
using _Assets.Scripts.Services.StateMachine.States;
using _Assets.Scripts.Services.UIs.StateMachine;
using _Assets.Scripts.Services.Yandex;

namespace _Assets.Scripts.Services.StateMachine
{
    public class GameStatesFactory
    {
        private readonly UIStateMachine _uiStateMachine;
        private readonly YandexService _yandexService;
        private readonly PlayerFactory _playerFactory;
        private readonly EnemyFactory _enemyFactory;

        private GameStatesFactory(UIStateMachine uiStateMachine, YandexService yandexService, PlayerFactory playerFactory, EnemyFactory enemyFactory)
        {
            _uiStateMachine = uiStateMachine;
            _yandexService = yandexService;
            _playerFactory = playerFactory;
            _enemyFactory = enemyFactory;
        }

        public IAsyncState CreateAsyncState(GameStateType gameStateType, GameStateMachine gameStateMachine)
        {
            switch (gameStateType)
            {
                case GameStateType.Init:
                    return new InitState(gameStateMachine, _uiStateMachine, _yandexService);
                case GameStateType.Game:
                    return new GameState(gameStateMachine, _uiStateMachine, _playerFactory, _enemyFactory);
                default:
                    throw new ArgumentOutOfRangeException(nameof(gameStateType), gameStateType, null);
            }
        }
    }
}