using DragonGame.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame.Combats {
    public class LaunchFireball : MonoBehaviour
    {
        [SerializeField] FireballController fireballPrefab;
        [SerializeField] Transform fireballTransform;
        [SerializeField] GameObject fireballParent;
        [SerializeField] float delay=1f;

        float _currentdelay;
        bool _isLaunch = false;

        private void Update()
        {
            _currentdelay += Time.deltaTime;
            if (_currentdelay > delay)
            {
                _isLaunch = true;
                _currentdelay = 0f;
            }

        }
        public void LaunchAction()
        {
            if (_isLaunch)
            {
              
                FireballController newFireball = Instantiate(fireballPrefab, fireballTransform.position, fireballTransform.transform.rotation);
                newFireball.transform.parent = fireballParent.transform;   
                _isLaunch = false;
            }
        }

    }
   
}

