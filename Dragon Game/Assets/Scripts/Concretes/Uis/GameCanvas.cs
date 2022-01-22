using DragonGame.Combats;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DragonGame.Uis
{
    public class GameCanvas : MonoBehaviour
    {
        [SerializeField] GameObject gameOverPanel;

        private void Awake()//canvasý alýr
        {
            gameOverPanel = transform.GetChild(1).gameObject;//2.childi alýr
            
        }
        private void Start()//DeADI BULUR
        {
            Dead dead = FindObjectOfType<Dead>();
            dead.Ondead += HandleOnDead;
        }

        private void HandleOnDead()
        {
            gameOverPanel.SetActive(true);//aktif hale getirir
        }
    }
}
    
