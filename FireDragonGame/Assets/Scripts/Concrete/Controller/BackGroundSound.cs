using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyFirsGame.Controller
{
    public class BackGroundSound : MonoBehaviour
    {
        [SerializeField] GameObject _backgroundObject;
        static bool _isFirstTime = true;
        private void Start()
        {
            if (_isFirstTime)
            {
                SpawnBaskGroundObject();
                _isFirstTime = false;
            }
        }

        private void SpawnBaskGroundObject()
        {
            GameObject newObject = _backgroundObject;
            DontDestroyOnLoad( newObject );
        }
    }
}

