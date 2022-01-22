using DragonGame.Abstracts.Controllers;
using DragonGame.Polls;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Yasam döngüsünden miras alarak Pool içindeki objeleri yönetir
namespace DragonGame.Controllers
{
    public abstract class EnemyController : BaseCycleofLife
    {
        public override void HideGameObject()/*Yaþam döngüsü biitnce obje gider ve zaman sýfýrlanýr*/
        {
            _currentTime = 0f;
            SetEnemyPool();
        }
        public abstract void SetEnemyPool();
      
    }

}

