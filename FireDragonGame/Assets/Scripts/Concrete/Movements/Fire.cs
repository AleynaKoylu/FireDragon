using System.Collections;
using System.Collections.Generic;
using UdemyFirsGame.Abstract.Controller;
using UdemyFirsGame.Controller;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
namespace UdemyFirsGame.Movements {
    public class Fire : LifeControlle
    {
        [SerializeField] float _maxLifeTime;
        [SerializeField] GameObject _enemyStartPoint;
        [SerializeField] Text _pointText;
        public override float MaxLifeTime { get { return _maxLifeTime; } set { float _maxLifeTime = value; } }
        public override GameObject ObjectPos()
        {
            return _enemyStartPoint;
        }
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Down"))
            {
                GameManager.Instance.Point();
                other.GetComponent<EnemyController>().TimeReset();
                TimeReset();
                other.gameObject.SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
