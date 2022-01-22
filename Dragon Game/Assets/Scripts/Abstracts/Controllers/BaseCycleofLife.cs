using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Objelerin ya�am d�ng�s�b� i�eren soyut s�n�f
namespace DragonGame.Abstracts.Controllers {
    public abstract class BaseCycleofLife : MonoBehaviour
    {
        [SerializeField] float maxLife = 5f;

        protected float _currentTime;/*Metodlarda kullanilibir*/

        private void Update()/*��eler do�ar ve yok olur*/
        {
            _currentTime += Time.deltaTime;

            if (_currentTime > maxLife)
            {
                HideGameObject();
            }
        }

        public abstract void HideGameObject();/*Havuzdaki ��eleri gizler*/
      
    }
}

