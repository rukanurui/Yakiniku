using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI�g���Ƃ��͖Y�ꂸ�ɁB
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 100;
    int currentHp;
    //Slider������
    public Slider slider;

    void Start()
    {
        //Slider�𖞃^���ɂ���B
        slider.value = 0;
        //���݂�HP��0�Ɠ����ɁB
        currentHp = 0;
        Debug.Log("Start currentHp : " + currentHp);
    }

    void Update()
    {
        currentHp = Eat.instance.point;
        slider.value = (float)currentHp / (float)maxHp; ;
    }
}
