using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ResultScore : MonoBehaviour
{
    public Text ScoreText;
    float score;
    int IntScore;

    // Start is called before the first frame update
    void Start()
    {
        //Scoreの時間と食べ物を合算する
        score = Gage.GetScore() + TimeLimit1.GetScore();

        //合算したScoreはFloat型のためInt型に変換する
        IntScore = (int)Math.Ceiling(score);
        ScoreText.text = string.Format("{0}", IntScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
