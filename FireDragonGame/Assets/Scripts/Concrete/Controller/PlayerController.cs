using System.Collections;
using System.Collections.Generic;
using UdemyFirsGame.Movements;
using UdemyFirsGame.Spawner;
using UnityEngine;

namespace UdemyFirsGame.Controller
{
    public class PlayerController : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        bool _isPlaying;
        Jump _jump;
        InputController _inputController;
        FireSpwaner _fireSpwaner;
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _fireSpwaner = GetComponent<FireSpwaner>();
            _inputController = new InputController();
        }

        private void Update()
        {
            if (_inputController.IsPlaying)
            {
                _isPlaying = true;
            }
            if (_inputController.IsFire)
            {
               
                _fireSpwaner.Fire();
            }
        }
        private void FixedUpdate()
        {
            if (_isPlaying)
            {
                _jump.JumpMovement(_rigidbody2D);
                _isPlaying = false;
            }
            
        }

     
    }
}

