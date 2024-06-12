﻿using System;
using _Assets.Scripts.Services.Gameplay;
using UnityEngine;
using VContainer;

namespace _Assets.Scripts.Gameplay
{
    public class PlayerController : MonoBehaviour
    {
        [Inject] private InputService _inputService;
        private BoundariesController _boundariesController;

        private void Start()
        {
            _boundariesController = new BoundariesController(transform, Camera.main);
        }

        private void Update()
        {
            transform.position += new Vector3(_inputService.Horizontal, _inputService.Vertical) * Time.deltaTime;
            _boundariesController.Update();
        }
    }
}