using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI�g���Ƃ��͖Y�ꂸ�ɁB
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Gage : MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 100;

    //�Œ�HP
    int minHp = 0;

    public float currentHp;
    float happyHp;
    float healthHp;
    public float cigarettesHp;

    //public Eat eat;
    //Slider������
    public Slider slider;
    public Slider happySlider;
    public Slider healthSlider;
    public Slider cigarettesSlider;

    public static Gage instance;
    public float point;
    public float happyPoint;
    public float healthPoint;
    public float cigarettesPoint;


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
        //�|�C���g��50�ɂ���
        point = 50;
        happyPoint = 50;
        healthPoint = 50;
        //Slider�𖞃^���ɂ���B
        slider.value = 50;
        happySlider.value = 50;
        healthSlider.value =50;
        //���݂�HP��50�Ɠ����ɁB
        currentHp = 50;
        happyHp = 50;
        healthHp = 50;
        pointLostTime = 0;
        Debug.Log("Start currentHp : " + currentHp);
    }


    public void ScoreUpdate(string name,int firelevel)
    {

        //�K���Ȃǂ̃Q�[�W�ɂ�������t����
        //tag�̒��Ɋ܂܂��Ή��������O�ŃX�R�A�ω�
        if(name.Contains("Karubi") && firelevel == 2)//���@�E�F���_��
        {
            point += 15;
            happyPoint += 25;
            healthPoint -= 10;

            score += 50;
        }
        else if(name.Contains("Karubi") && firelevel == 3)//�� �ł���
        {
            point += 5;
            happyPoint -= 10;
            healthPoint -= 20;

            score += 25;
        }
        else if(name.Contains("kyabetu") && firelevel == 2)//��؁@�E�F���_��
        {
            point += 10;
            happyPoint -= 15;
            healthPoint += 20;

            score += 25;
        }
        else if (name.Contains("kyabetu") && firelevel == 3)//��؁@�ł�
        {
            point += 5;
            happyPoint -= 15;
            healthPoint += 0;

            score -= 5;
        }
        else if (name.Contains("kabocha") && firelevel == 2)//���ڂ���@�E�F���_��
        {
            point += 10;
            happyPoint -= 10;
            healthPoint += 15;

            score += 15;
        }
        else if (name.Contains("kabocha") && firelevel == 3)//���ڂ���@�ł�
        {
            point += 5;
            happyPoint -= 20;
            healthPoint += 0;

            score -= 5;
        }
        else if (name.Contains("pi-man") && firelevel == 2)//�ҁ[�܂�@�E�F���_��
        {
            point += 10;
            happyPoint -= 15;
            healthPoint += 20;

            score += 5;
        }
        else if (name.Contains("pi-man") && firelevel == 3)//�ҁ[�܂�@�ł�
        {
            point += 5;
            happyPoint -= 30;
            healthPoint += 0;

            score -= 5;
        }
        else if (name.Contains("horumon") && firelevel == 2)//�z�������@�E�F���_��
        {
            point += 15;
            happyPoint += 20;
            healthPoint -= 15;

            score += 40;
        }
        else if (name.Contains("horumon") && firelevel == 3)//�z�������@�ł�
        {
            point += 5;
            happyPoint -= 20;
            healthPoint -= 25;

            score += 20;
        }
        else if (name.Contains("tori") && firelevel == 2)//���@�E�F���_��
        {
            point += 15;
            happyPoint += 15;
            healthPoint -= 5;

            score += 25;
        }
        else if (name.Contains("tori") && firelevel == 3)//���@�ł�
        {
            point += 5;
            happyPoint -= 10;
            healthPoint -= 10;

            score += 15;
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


    public void OnClickSquatButton()
    {
        //�{�^����������X�e�[�^�X��������
        point -= 1.0f;
        currentHp -= 1.0f;
    }


    void Update()
    {
        // �󕠂��O���ƃJ�E���g�_�E���n�܂�
        if(point<=0)
        {
            pointLostTime += 1;
            //�J�E���g�_�E�����I���ƃQ�[���I��
            if (pointLostTime > 180)
            {
                //�󕠂�0����莞�ԗ�������
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

        //�Œ�l�A�ō��l�𒴂�����C��
        if (point > maxHp)
        {
            point = maxHp;
        }
        else if(point<minHp)
        {
            point = minHp;
        }
        //�Œ�l�A�ō��l�𒴂�����C��
        if (happyPoint > maxHp)
        {
            happyPoint = maxHp;
        }
        else if (happyPoint < minHp)
        {
            happyPoint = minHp;
        }
        //�Œ�l�A�ō��l�𒴂�����C��
        if (healthPoint > maxHp)
        {
            healthPoint = maxHp;
        }
        else if (healthPoint < minHp)
        {
            healthPoint = minHp;
        }
        //�Œ�l�A�ō��l�𒴂�����C��
        if (cigarettesPoint > maxHp)
        {
            cigarettesPoint = maxHp;
        }
        else if (cigarettesPoint < minHp)
        {
            cigarettesPoint = minHp;
        }


        happyHp = happyPoint;
        healthHp = healthPoint;
        cigarettesHp = cigarettesPoint;


        slider.value = (float)currentHp / (float)maxHp; ;
        happySlider.value = (float)happyHp / (float)maxHp; ;
        healthSlider.value = (float)healthHp / (float)maxHp; ;
        cigarettesSlider.value = (float)cigarettesHp / (float)maxHp; ;
    }
}
