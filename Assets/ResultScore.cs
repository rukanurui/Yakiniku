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
        //Score‚ÌŠÔ‚ÆH‚×•¨‚ğ‡Z‚·‚é
        score = Gage.GetScore() + TimeLimit1.GetScore();

        //‡Z‚µ‚½Score‚ÍFloatŒ^‚Ì‚½‚ßIntŒ^‚É•ÏŠ·‚·‚é
        IntScore = (int)Math.Ceiling(score);
        ScoreText.text = string.Format("{0}", IntScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
