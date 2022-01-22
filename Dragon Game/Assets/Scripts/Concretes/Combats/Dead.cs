using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DragonGame.Combats
{
    public class Dead : MonoBehaviour
    {
        [SerializeField] bool _isdead ;
        public bool Isdead => _isdead;

        public event System.Action Ondead;  
        
        private void OnCollisionEnter2D(Collision2D collision)//�ld���nde i�lem yaapr
        {
            _isdead = true;
            Ondead?.Invoke();
            Time.timeScale = 0f;
        }
    
    }


}
