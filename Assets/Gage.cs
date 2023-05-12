using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI使うときは忘れずに。
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 100;
    int currentHp;
    //public Eat eat;
    //Sliderを入れる
    public Slider slider;
    public static Gage instance;
    public int point;
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
        //ポイントを0にする
        point = 0;
        //Sliderを満タンにする。
        slider.value = 0;
        //現在のHPを0と同じに。
        currentHp = 0;
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

        }
        else if(name.Contains("kyabetu"))
        {
            point += 25;
        }
        else
        {
            point += 10;
        }

        Eat.instance.GetFlag = false;
        
    }
    void Update()
    {
        
        currentHp = point;
        slider.value = (float)currentHp / (float)maxHp; ;
    }
}
