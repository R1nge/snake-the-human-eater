namespace _Assets.Scripts.Services.Gameplay
{
    public class InputService
    {
        private float _horizontal;
        public float Horizontal => _horizontal;
        private float _vertical;
        public float Vertical => _vertical;
        private bool _enabled;
        public bool Enabled => _enabled;

        public void SetInput(float horizontal, float vertical)
        {
            _horizontal = horizontal;
            _vertical = vertical;
        }

        public void Enable(bool enabled) => _enabled = enabled;
    }
}