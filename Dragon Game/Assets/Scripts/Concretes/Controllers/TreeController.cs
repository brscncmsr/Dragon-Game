using DragonGame.Controllers;
using DragonGame.Polls;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame.Controllers {
    public class TreeController : EnemyController
    {
        public override void SetEnemyPool()
        {
            TreePool.Instance.Set(this);
        }
    }
}

