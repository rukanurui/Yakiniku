using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに。
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gage : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 100;

    //最低HP
    int minHp = 0;

    float currentHp;
    float happyHp;
    float healthHp;
    //public Eat eat;
    //Sliderを入れる
    public Slider slider;
    public Slider happySlider;
    public Slider healthSlider;

    public static Gage instance;
    public float point;
    public float happyPoint;
    public float healthPoint;

    public static float score = 0;
    public static int pointLostTime = 0;
   // public string name;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public static float GetScore()
    {
        return score;
    }

    void Start()
    {
        //ポイントを50にする
        point = 50;
        happyPoint = 50;
        healthPoint = 50;
        //Sliderを満タンにする。
        slider.value = 50;
        happySlider.value = 50;
        healthSlider.value =50;
        //現在のHPを50と同じに。
        currentHp = 50;
        happyHp = 50;
        healthHp = 50;
        pointLostTime = 0;
        Debug.Log("Start currentHp : " + currentHp);
    }

    private void OnMouseDown()
    {
        //皿の上で左クリック押されたら
        //ここでどうやって押された種類のを判定するか
        //RaycastHit hit;
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        //if (Physics.Raycast(ray, out hit))
        //{
        //    a = hit.collider.tag;
        //    if(a.Contains("Food"))
        //    {
        //        point += 25;
        //    }
            
            
        //    Debug.Log(hit.collider.tag);
        //}

    }
    public void ScoreUpdate(string name,int firelevel)
    {
        //tagの中に含まれる対応した名前でスコア変化
        if(name.Contains("Karubi") && firelevel == 2)//肉　ウェルダン
        {
            point += 50;
            happyPoint += 25;
            healthPoint -= 10;

            score += 3;
        }
        else if(name.Contains("Karubi") && firelevel == 3)//肉 焦げ肉
        {
            point += 25;
            happyPoint += 5;
            healthPoint -= 20;

            score += 3;
        }
        else if(name.Contains("kyabetu") && firelevel == 2)//野菜　ウェルダン
        {
            point += 25;
            happyPoint -= 10;
            healthPoint += 25;

            score += 3;
        }
        else if (name.Contains("kyabetu") && firelevel == 3)//野菜　焦げ
        {
            point += 15;
            happyPoint -= 20;
            healthPoint += 15;

            score += 3;
        }
        else
        {
            point += 10;
            happyPoint += 10;
            healthPoint -= 5;

            score += 3;
        }

        Eat.instance.GetFlag = false;
        
    }


    void Update()
    {
        // 空腹が０だとカウントダウン始まる
        if(point<=0)
        {
            pointLostTime += 1;
            //カウントダウンが終わるとゲーム終了
            if (pointLostTime > 180)
            {
                //空腹が0かつ一定時間立った時
                SceneManager.LoadScene("result");
            }
        }
        else
        {
            pointLostTime = 0;
        }

        currentHp = point;

      

        point -= 0.01f;
        currentHp -= 0.01f;

        //最低値、最高値を超えたら修正
        if (point > maxHp)
        {
            point = maxHp;
        }
        else if(point<minHp)
        {
            point = minHp;
        }
        //最低値、最高値を超えたら修正
        if (happyPoint > maxHp)
        {
            happyPoint = maxHp;
        }
        else if (happyPoint < minHp)
        {
            happyPoint = minHp;
        }
        //最低値、最高値を超えたら修正
        if (healthPoint > maxHp)
        {
            healthPoint = maxHp;
        }
        else if (healthPoint < minHp)
        {
            healthPoint = minHp;
        }


        happyHp = happyPoint;
        healthHp = healthPoint;


        slider.value = (float)currentHp / (float)maxHp; ;
        happySlider.value = (float)happyHp / (float)maxHp; ;
        healthSlider.value = (float)healthHp / (float)maxHp; ;
    }
}
