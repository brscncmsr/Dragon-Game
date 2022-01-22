using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace DragonGame.Controllers
{
    public class InputController
    {
        public bool LeftMouseClickDown => Input.GetMouseButton(0);
        public bool RightMouseClickDown => Input.GetMouseButton(1);
    }
}
