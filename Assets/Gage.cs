using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに。
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 100;

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
   // public string name;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
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
    public void ScoreUpdate(string name)
    {
        //tagの中に含まれる対応した名前でスコア変化
        if(name.Contains("Karubi"))
        {
            point += 50;
            happyPoint += 25;
            healthPoint -= 10;
        }
        else if(name.Contains("kyabetu"))
        {
            point += 25;
            happyPoint -= 10;
            healthPoint += 25;
        }
        else
        {
            point += 10;
            happyPoint += 10;
            healthPoint -= 5;
        }

        Eat.instance.GetFlag = false;
        
    }


    void Update()
    {

       

        currentHp = point;

        point -= 0.01f;
        currentHp -= 0.01f;

        happyHp = happyPoint;
        healthHp = healthPoint;


        slider.value = (float)currentHp / (float)maxHp; ;
        happySlider.value = (float)happyHp / (float)maxHp; ;
        healthSlider.value = (float)healthHp / (float)maxHp; ;
    }
}
