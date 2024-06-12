using _Assets.Scripts.Services.Gameplay;
using UnityEngine;
using VContainer;

namespace _Assets.Scripts.Gameplay
{
    public class PlayerController : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        private PlayerMovement _playerMovement;
        private BoundariesController _boundariesController;

        private void Start()
        {
            _playerMovement = new PlayerMovement(transform, _inputService, Time.deltaTime);
            _boundariesController = new BoundariesController(transform, Camera.main);
        }

        private void Update()
        {
            _playerMovement.Move();
            _boundariesController.Update();
        }
    }
}