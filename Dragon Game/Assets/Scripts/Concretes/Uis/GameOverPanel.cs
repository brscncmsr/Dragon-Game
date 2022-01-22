using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DragonGame.Uis
{
    public class GameOverPanel : MonoBehaviour
    {
        public void NoButtonClick() => GameManager.Instance.ReturnMenu();
        public void YesButtonClick() => GameManager.Instance.StartGame();
    }
}

