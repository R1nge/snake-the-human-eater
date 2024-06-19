using _Assets.Scripts.Configs;
using _Assets.Scripts.Services.Gameplay;
using UnityEngine;
using VContainer;

namespace _Assets.Scripts.Gameplay
{
    public class PlayerController : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        [Inject] private ConfigProvider _configProvider;
        private PlayerMovement _playerMovement;
        private BoundariesController _boundariesController;

        private void Start()
        {
            _playerMovement = new PlayerMovement(transform, _inputService, Time.deltaTime);
            _boundariesController = new BoundariesController(transform, Camera.main);
        }

        private void Update()
        {
            _playerMovement.Move(_configProvider.PlayerConfig.Speed, _configProvider.PlayerConfig.RotationSpeed);
            _boundariesController.Update();
        }
    }
}