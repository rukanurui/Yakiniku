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

    void Start()
    {
        //Sliderを満タンにする。
        slider.value = 0;
        //現在のHPを0と同じに。
        currentHp = 0;
        Debug.Log("Start currentHp : " + currentHp);
    }

    void Update()
    {
        currentHp = Eat.instance.point;
        slider.value = (float)currentHp / (float)maxHp; ;
    }
}
