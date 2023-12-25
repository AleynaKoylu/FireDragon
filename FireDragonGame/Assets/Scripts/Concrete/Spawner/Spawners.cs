using System.Collections;
using System.Collections.Generic;
using UdemyFirsGame.Controller;
using UnityEngine;
using UdemyFirsGame.Abstract.Spawners;

namespace UdemyFirsGame.Spawner
{
    public class Spawners : BaseSpawners
    {
        [SerializeField] List<GameObject> _enemyController;

        protected override void Spawn()
        {
            int enemyIndex = Random.Range(0, _enemyController.Count);
            _enemyController[enemyIndex].gameObject.SetActive(true);
        }
    }
}