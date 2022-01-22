using DragonGame.Abstracts.Polls;
using DragonGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Generic Poolda miras alarak eklenen öðeleri havuza ekliyor

namespace DragonGame.Polls {
    public class TreePool : GenericPool<EnemyController>
    {
        public static TreePool Instance { get; private set; }

        public override void ResetAllObjects()
        {

            foreach (TreeController child in GetComponentsInChildren<TreeController>())
            {
                if (!child.gameObject.activeSelf) continue;

                child.HideGameObject();
            }
        }

        protected override void SingletonObject()/*Kendþni yok etmesini engeller*/
        {
            if(Instance== null)
            {
                Instance = this;
                DontDestroyOnLoad(this.gameObject);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }


    }
}

