using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyFirsGame.Abstract.Spawners

{
    public abstract class BaseSpawners:MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float _minSpawnTime;
        [Range(0.3f, 1.5f)]
        [SerializeField] float _maxSpawnTime;
        float _spawnTime;
        float _timeBoundary;
       
        private void Start()
        {
            SpawnTime();
        }
        private void Update()
        {
            _spawnTime += Time.deltaTime;
            if (_spawnTime > _timeBoundary)
            {
                Spawn();
                SpawnTime();
            }

        }

        protected abstract void Spawn();
        
        void SpawnTime()
        {
            _spawnTime = 0;
            _timeBoundary = Random.Range(_minSpawnTime, _maxSpawnTime);
        }
    }
} 
   

