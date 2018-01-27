using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public TextMeshProUGUI counter;
    public TextMeshProUGUI timer;
    public TextMeshProUGUI gameOver;
    public int GameDuration = 120;
    int countDown;
    float countDown0;
    int FramePerSec = 25;
    // Use this for initialization
    void Start()
    {
        counter.text = "Score:";
        timer.text = GameDuration.ToString();
        gameOver.text = "";
        countDown0 = (Time.realtimeSinceStartup);
    }
    private void Update()
    {
        UpdateTimer();
        UpdateScore();

    }
    void UpdateTimer()
    {
        countDown = (int)(Time.realtimeSinceStartup - countDown0);
        int seconds = GameDuration + ScoringManager.score*10 - countDown;
        if(seconds < 0)
        {
            Debug.Log("game over");
            gameOver.gameObject.SetActive(true);
            gameOver.text = "Time's up!\nYour score: " + ScoringManager.score;
            seconds = 0;
            Time.timeScale = 0; // pause game
        }
        timer.text = seconds.ToString();
    }

    void UpdateScore()
    {
        counter.text = "Score: " + ScoringManager.score;
    }

}
