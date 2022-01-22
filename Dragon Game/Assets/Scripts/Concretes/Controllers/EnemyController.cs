using DragonGame.Abstracts.Controllers;
using DragonGame.Polls;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Yasam d�ng�s�nden miras alarak Pool i�indeki objeleri y�netir
namespace DragonGame.Controllers
{
    public abstract class EnemyController : BaseCycleofLife
    {
        public override void HideGameObject()/*Ya�am d�ng�s� biitnce obje gider ve zaman s�f�rlan�r*/
        {
            _currentTime = 0f;
            SetEnemyPool();
        }
        public abstract void SetEnemyPool();
      
    }

}

