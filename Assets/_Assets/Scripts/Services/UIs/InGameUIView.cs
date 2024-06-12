using System;
using _Assets.Scripts.Services.Gameplay;
using UnityEngine;
using VContainer;

namespace _Assets.Scripts.Services.UIs
{
    public class InGameUIView : MonoBehaviour
    {
        [SerializeField] private Joystick joystick;
        [Inject] private InputService _inputService;

        private void Update()
        {
            SetInput(joystick.Horizontal, joystick.Vertical);
        }


        private void Enable(bool enabled) => _inputService.Enable(enabled);

        private void SetInput(float horizontal, float vertical) => _inputService.SetInput(horizontal, vertical);
    }
}