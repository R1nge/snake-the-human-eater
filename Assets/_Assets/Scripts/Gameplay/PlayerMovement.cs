using _Assets.Scripts.Services.Gameplay;
using UnityEngine;

namespace _Assets.Scripts.Gameplay
{
    public class PlayerMovement
    {
        private readonly Transform _transform;
        private readonly InputService _inputService;
        private readonly float _delta;

        public PlayerMovement(Transform transform, InputService inputService, float delta)
        {
            _transform = transform;
            _inputService = inputService;
            _delta = delta;
        }

        public void Move(float moveSpeed, float rotationSpeed)
        {
            _transform.position += _transform.right * (Time.deltaTime * moveSpeed);
            var rotation = _inputService.Horizontal * (Time.deltaTime * rotationSpeed);
            _transform.Rotate(0, 0, rotation);
        }
    }
}