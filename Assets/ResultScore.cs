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
        //Score�̎��ԂƐH�ו������Z����
        score = Gage.GetScore() + TimeLimit1.GetScore();

        //���Z����Score��Float�^�̂���Int�^�ɕϊ�����
        IntScore = (int)Math.Ceiling(score);
        ScoreText.text = string.Format("{0}", IntScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
