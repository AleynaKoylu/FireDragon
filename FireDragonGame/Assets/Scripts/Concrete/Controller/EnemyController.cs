using System.Collections;
using System.Collections.Generic;
using UdemyFirsGame.Abstract.Controller;
using UnityEngine;

namespace UdemyFirsGame.Controller
{
    public class EnemyController : LifeControlle
    {
        [SerializeField] float _maxLifeTime;
        [SerializeField] GameObject _enemyStartPoint;
        public override float MaxLifeTime { get { return _maxLifeTime; } set { float _maxLifeTime = value; } }
        public override GameObject ObjectPos()
        {
           return _enemyStartPoint;
        }
    }
}

