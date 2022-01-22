using DragonGame.Combats;
using DragonGame.Movements;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace DragonGame.Controllers {
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        Jump _jump;
        InputController _input;
        AudioSource _audioSource;
        LaunchFireball _launch;
        bool _isLeftMouseClicked;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launch = GetComponent<LaunchFireball>();
            _audioSource = GetComponent<AudioSource>();
            _input = new InputController();
        }

        private void Update()
        {
            if (_input.LeftMouseClickDown)
            {
               
                _isLeftMouseClicked = true;

            }
            if (_input.RightMouseClickDown)
            {
                _launch.LaunchAction();
            }
        }
        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _audioSource.Play();
                _isLeftMouseClicked = false;
            }
        }
       
    }
}

