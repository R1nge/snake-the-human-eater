namespace _Assets.Scripts.Services.Gameplay
{
    public class InputService
    {
        private float _horizontal;
        public float Horizontal => _horizontal;
        private float _vertical;
        public float Vertical => _vertical;
        private bool _enabled = true;
        public bool Enabled => _enabled;

        public void SetInput(float horizontal, float vertical)
        {
            if (!_enabled)
            {
                _horizontal = 0;
                _vertical = 0;
                return;
            }
            
            _horizontal = horizontal;
            _vertical = vertical;
        }

        public void Enable(bool enabled) => _enabled = enabled;
    }
}