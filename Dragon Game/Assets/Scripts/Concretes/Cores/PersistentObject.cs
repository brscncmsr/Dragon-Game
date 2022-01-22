using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame.Cores
{
    public class PersistentObject : MonoBehaviour
    {
        [SerializeField] GameObject persistentPrefab;//Kal�c� obje �retir
        private bool _isfirsttime=true;

        private void Start()
        {
            if (_isfirsttime) {
                SpawnPersisnt();
                _isfirsttime = false;

            }
        }

        private void SpawnPersisnt()
        {
            GameObject newObject = Instantiate(persistentPrefab);
            DontDestroyOnLoad(newObject);
        }
    }
   
}

