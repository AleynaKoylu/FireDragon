using System.Collections;
using System.Collections.Generic;
using UdemyFirsGame.Enums;
using UnityEngine;

namespace UdemyFirsGame.Movements
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class LeftTrees : MonoBehaviour
    {
        Rigidbody2D _rigidbody2D;
        [SerializeField] float _moveSpeed;
        [SerializeField] DirectionEnum _direction;
        
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>(); 
        }
        private void OnEnable()
        {
           
            _rigidbody2D.velocity = Directon() * _moveSpeed;
        }
        Vector2 Directon()
        {
            Vector2 vector2;

            if (_direction == DirectionEnum.Left)
                vector2 = Vector2.left;
            else
                vector2 = Vector2.right;
            return vector2;
        }

    }
}
