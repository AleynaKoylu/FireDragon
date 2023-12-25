using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UdemyFirsGame.Controller {
    public class InputController 
    {
        public bool IsPlaying => Input.GetMouseButtonDown(0);
        public bool IsFire => Input.GetMouseButtonDown(1);

    }
}
