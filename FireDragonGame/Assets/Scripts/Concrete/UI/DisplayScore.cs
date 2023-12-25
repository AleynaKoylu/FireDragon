using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace UdemyFirsGame.UI
{
    public class DisplayScore : MonoBehaviour
    {
        Text _pointText;
        private void Awake()
        {
            _pointText = GetComponent<Text>();
        }
        private void Start()
        {
            GameManager.Instance.PointEvent += HandleScoreChange;

        }
        private void OnEnable()
        {
            
        }
        private void OnDisable()
        {
            GameManager.Instance.PointEvent -= HandleScoreChange;
        }
        public void HandleScoreChange(int score)
        {
            _pointText.text = score.ToString();
        }
    }
}