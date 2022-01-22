using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame.Uis {
    public class MenuCanvas : MonoBehaviour
    {
       public void QuitClick()
        {
            GameManager.Instance.ExitGame();
        }
        public void EnterClick()
        {
            GameManager.Instance.StartGame();
        }
    }
}

