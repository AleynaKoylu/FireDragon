using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyFirsGame.Abstract.Controller
{
    public abstract class LifeControlle : MonoBehaviour
    {
        public abstract float MaxLifeTime { get; set; }
        float _time;

        private void OnEnable()
        {
            gameObject.transform.position = ObjectPos().transform.position;
        }
        private void Update()
        {
            _time += Time.deltaTime;
            if (_time > MaxLifeTime)
            {
                transform.position = ObjectPos().transform.position;
                _time = 0;
                gameObject.SetActive(false);
            }
        }
        public void TimeReset()
        {
            _time = 0;
        }
        public abstract GameObject ObjectPos();
    }
}