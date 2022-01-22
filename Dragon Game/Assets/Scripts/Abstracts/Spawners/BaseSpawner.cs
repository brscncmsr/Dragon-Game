using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DragonGame.Abstracts.Spawners {
    public abstract class BaseSpawner : MonoBehaviour
    {
        [Range(2f, 5f)]
        [SerializeField] float maxSpwnTime = 2f;
        [Range(0.3f, 1.5f)]
        [SerializeField] float minSpwnTime = 0.5f;

        float _currentSpwnTime;
        float _timeBoundry;

        private void Start()
        {
            ResetTimes();
        }

        private void Update()
        {
            _currentSpwnTime += Time.deltaTime;

            if (_currentSpwnTime > _timeBoundry)
            {
                Spawn();
                ResetTimes();
            }
        }
        protected abstract void Spawn();
        
         
        private void ResetTimes()
        {
            _currentSpwnTime = 0f;
            _timeBoundry = Random.Range(minSpwnTime, maxSpwnTime);
        }
    }
}
