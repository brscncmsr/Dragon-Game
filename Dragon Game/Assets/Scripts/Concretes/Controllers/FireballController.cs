using DragonGame.Abstracts.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DragonGame.Controllers {
    public class FireballController : BaseCycleofLife
    {
        private void OnTriggerEnter2D(Collider2D collison)
        {
            EnemyController enemy = collison.GetComponent < EnemyController>();
            if (enemy != null)
            {
                GameManager.Instance.GetScore();
                enemy.HideGameObject();
            }
            HideGameObject();
        }
        public override void HideGameObject()
        {
            Destroy(this.gameObject);
        }
    }
}

