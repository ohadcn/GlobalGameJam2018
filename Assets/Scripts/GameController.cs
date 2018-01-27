using System.Collections;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public TextMeshProUGUI counter;
    public int score;
    public TextMeshProUGUI timer;
    public int seconds;
    int seconds0;
    public TextMeshProUGUI gameOver;
    public int countDown;
    float countDown0;
    int FramePerSec = 25;
    // Use this for initialization
    void Start()
    {
        counter.text = "Score:";
        timer.text = "120";
        gameOver.text = " ";
        score = 0;
        seconds0 = 120;
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
        seconds = seconds0 - countDown;
        if(seconds < 0)
        {
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
