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
    //Sliderを入れる
    public Slider slider;
    public Eat eat;
    public int point;

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
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit)&&hit.collider.tag=="Food"&&eat.Saraflag==true)
        {
            point += 25;
            Debug.Log(hit.collider.tag);
        }

    }

    void Update()
    {
        currentHp = Eat.instance.point;
        slider.value = (float)currentHp / (float)maxHp; ;
    }
}
