using UnityEngine;

namespace _Assets.Scripts.Gameplay
{
    public class BoundariesController
    {
        private readonly Transform _playerTransform;
        private readonly Camera _camera;

        public BoundariesController(Transform playerTransform, Camera camera)
        {
            _playerTransform = playerTransform;
            _camera = camera;
        }

        public void Update()
        {
            var viewportPosition = _camera.WorldToViewportPoint(_playerTransform.position);
            
            if (viewportPosition.x > 1 || viewportPosition.x < 0 || viewportPosition.y > 1 || viewportPosition.y < 0)
            {
                viewportPosition.x = viewportPosition.x > 1 ? 0 : viewportPosition.x < 0 ? 1 : viewportPosition.x;
                viewportPosition.y = viewportPosition.y > 1 ? 0 : viewportPosition.y < 0 ? 1 : viewportPosition.y;
                _playerTransform.position = _camera.ViewportToWorldPoint(viewportPosition);
            }
        }
    }
}