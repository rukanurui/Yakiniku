using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Cigarettes : MonoBehaviour
{
    //�������g�p���邱�Ƃɂ���ăQ�[�W���ω�
    public void OnClickCigareButton()
    {
        Gage.instance.cigarettesPoint += 0.5f;

        Gage.instance.cigarettesHp += 0.5f;
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Gage.instance.cigarettesPoint += 0.5f;

            Gage.instance.cigarettesHp += 0.5f;
        }
    }
   
}
