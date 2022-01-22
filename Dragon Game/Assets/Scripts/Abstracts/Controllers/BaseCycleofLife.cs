using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Objelerin yaþam döngüsübü içeren soyut sýnýf
namespace DragonGame.Abstracts.Controllers {
    public abstract class BaseCycleofLife : MonoBehaviour
    {
        [SerializeField] float maxLife = 5f;

        protected float _currentTime;/*Metodlarda kullanilibir*/

        private void Update()/*Öðeler doðar ve yok olur*/
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > maxLife)
            {
                HideGameObject();
            }
        }

        public abstract void HideGameObject();/*Havuzdaki öðeleri gizler*/
      
    }
}

