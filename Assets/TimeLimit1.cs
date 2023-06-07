using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeLimit1 : MonoBehaviour
{
    public int countdownMinutes = 3;
    private float countdownSeconds;
    private Text timeText;

    public static float score = 0;

    public static float GetScore()
    {
        return score;
    }

    private void Start()
    {
        timeText = GetComponent<Text>();
        countdownSeconds = countdownMinutes * 60;
    }

    void Update()
    {
        countdownSeconds -= Time.deltaTime;
        var span = new TimeSpan(0, 0, (int)countdownSeconds);
        timeText.text = span.ToString(@"mm\:ss");

        score = 300.0f - countdownSeconds;

        if (countdownSeconds <= 0)
        {
            // 0•b‚É‚È‚Á‚½‚Æ‚«‚Ìˆ—
            SceneManager.LoadScene("result");
        }
    }
}
