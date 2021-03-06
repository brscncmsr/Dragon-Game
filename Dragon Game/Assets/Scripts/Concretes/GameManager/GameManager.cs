
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score=0;
    public static GameManager Instance { get; private set; }
    public event System.Action<int> OnScoreChanged;
    public event System.Action OnSceneChanged;

    private void Awake()
    {
        SingletonThisGameObject();
        
    }
    
        private void SingletonThisGameObject() {   //yok olma engeller 
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void GetScore()//score tutar
    {
        score+=10;
        OnScoreChanged?.Invoke(score);
    }
    public void StartGame()//oyunu ba?lat?r
    {
        
        score = 0;
        Time.timeScale = 1f;
        StartCoroutine(StartGameAsync());
        
    }
    private IEnumerator StartGameAsync()//scene y?kler
    {
        OnSceneChanged?.Invoke();
        yield return SceneManager.LoadSceneAsync("Game");
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ReturnMenu()//men?ye d?ner ba?lat?r
    {
        StartCoroutine(ReturnMenuAsync());
    }
    private IEnumerator ReturnMenuAsync()//scene y?kler
    {
        OnSceneChanged?.Invoke();
        yield return SceneManager.LoadSceneAsync("Menu");
    }
}

