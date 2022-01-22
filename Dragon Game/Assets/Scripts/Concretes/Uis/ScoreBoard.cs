using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


namespace DragonGame.Uis
{
    public class ScoreBoard : MonoBehaviour
    {
        TextMeshProUGUI _scoretext;//score

        private void Awake()
        {
            _scoretext = GetComponent<TextMeshProUGUI>();

        }
        private void Start()
        {
            GameManager.Instance.OnScoreChanged += HandleOnScoreChanged;//gamemanagaerden alýr
        }

        private void OnDisable()
        {
            GameManager.Instance.OnScoreChanged -= HandleOnScoreChanged;
        }

        private void HandleOnScoreChanged(int score)
        { 
            _scoretext.text = $"Score: {score}";//yazdýrýr
        }
    }
}

