using System;
using System.Collections;
using System.Collections.Generic;
using UdemyFirsGame.Controller;
using UnityEngine;
namespace UdemyFirsGame.UI
{
    public class GameCnvas : MonoBehaviour
    {
        [SerializeField] GameObject _gameOverPanel;
        private void Awake()
        {
            _gameOverPanel = transform.GetChild(1).gameObject;
           
        }
        private void Start()
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.DeadPanel += HandelDeadPanel;
        }

        private void HandelDeadPanel()
        {
            _gameOverPanel.SetActive(true);
        }
    }
}