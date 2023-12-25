using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyFirsGame.Spawner
{
    public class FireSpwaner : MonoBehaviour
    {
        [SerializeField] List<GameObject> _fire;
        [SerializeField] float _delayFire = 1f;
        float _fireTime;
        bool _canFire;
        [SerializeField] AudioSource _audioSource;
        private void Update()
        {
            _fireTime += Time.deltaTime;

            if (_fireTime >= _delayFire)
            { 
                _canFire = true;
                _fireTime = 0;
            }

        }
        public void Fire()
        {

            if (_canFire==true)
            {
                int _numberFire = Random.Range(0, _fire.Count);
                _fire[_numberFire].SetActive(true);
                _audioSource.Play();
                _canFire =false;
            }

        }
    }
}
