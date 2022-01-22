using DragonGame.Controllers;
using DragonGame.Polls;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame.Controllers
{
    public class RedDragonController : EnemyController
    {
        public override void SetEnemyPool()
        {
            RedDragonPool.Instance.Set(this);
        }
    }
}
