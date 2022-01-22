using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DragonGame.Abstracts.Spawners;
using DragonGame.Controllers;
using DragonGame.Polls;

//Pool yap�s�n� kullarak objeleri spawn ediyor.
namespace DragonGame.Spawners
{
    public class TreeSpawner : BaseSpawner
    {
        
    
        protected override void Spawn()/*Havuzda bulunan ��eleri g�r�n�r hale getirir*/
        {
            EnemyController poolEnemy = TreePool.Instance.Get();
            poolEnemy.transform.position = this.transform.position;
            poolEnemy.gameObject.SetActive(true);
        }
    }

}

