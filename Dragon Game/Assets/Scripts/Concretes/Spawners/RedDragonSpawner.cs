using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonGame.Abstracts.Spawners;
using DragonGame.Controllers;
using DragonGame.Polls;

namespace DragonGame.Spawners
{
    public class RedDragonSpawner : BaseSpawner
    {
        protected override void Spawn()/*Havuzda bulunan öðeleri görünür hale getirir*/
        {
            EnemyController poolEnemy = RedDragonPool.Instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);
        }
    }

}

