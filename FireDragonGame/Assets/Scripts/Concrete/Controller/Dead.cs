using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyFirsGame.Controller
{
    public class Dead : MonoBehaviour
    {
        bool _isDead;
        public bool IsDead => _isDead;
        public event System.Action DeadPanel;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Down") || collision.gameObject.CompareTag("Tree"))
            {
                _isDead = true;
                DeadPanel?.Invoke();
                Time.timeScale = 0f;
            }
        }

    }
}

