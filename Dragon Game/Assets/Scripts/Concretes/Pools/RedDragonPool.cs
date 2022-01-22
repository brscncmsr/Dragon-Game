using DragonGame.Abstracts.Polls;
using DragonGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame.Polls
{
    public class RedDragonPool : GenericPool<EnemyController>
    {
        public static RedDragonPool Instance { get; private set; }

        public override void ResetAllObjects()
        {
            {
                foreach (RedDragonController child in GetComponentsInChildren<RedDragonController>())
                {
                    if (!child.gameObject.activeSelf) continue;

                    child.HideGameObject();
                }
            }
        }

        protected override void SingletonObject()/*Kendþni yok etmesini engeller*/
        {
            if (Instance == null)
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