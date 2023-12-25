using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyFirsGame.UI
{
    public class GameOverPanel : MonoBehaviour
    {
        public void YesButton()
        {
            GameManager.Instance.Died();
        }
        public void NoButton()
        {

        }
    }
}
