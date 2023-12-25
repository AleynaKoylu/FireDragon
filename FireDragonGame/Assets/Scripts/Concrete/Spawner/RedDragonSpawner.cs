using System.Collections;
using System.Collections.Generic;
using UdemyFirsGame.Abstract.Spawners;
using UnityEngine;
namespace UdemyFirsGame.Spawner
{
    public class RedDragonSpawner : BaseSpawners
    {
        [SerializeField] List<GameObject> _enemyController;
        protected override void Spawn()
        {
            int enemyIndex = Random.Range(0, _enemyController.Count);
            _enemyController[enemyIndex].gameObject.SetActive(true);
        }
    }
}
