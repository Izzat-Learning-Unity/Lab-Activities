using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandleScoreButton : MonoBehaviour
{
    public Text score;
    public Text time;
    public Button btnScore;

    private float timeSceneLoaded;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "";
        btnScore.onClick.AddListener(showScore);
        timeSceneLoaded = Time.time;

    }

    // Update is called once per frame
    void Update()
    {
        time.text = "Time: " + (int)Math.Floor(Time.time-timeSceneLoaded);
    }


    void showScore()
    {
        score.text = "Score: 100";
    }
}
