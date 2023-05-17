using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//UI�g���Ƃ��͖Y�ꂸ�ɁB
using UnityEngine.UI;

public class Gage : MonoBehaviour
{
    //�ő�HP�ƌ��݂�HP�B
    int maxHp = 100;

    float currentHp;
    float happyHp;
    float healthHp;
    //public Eat eat;
    //Slider������
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
        Debug.Log("Start currentHp : " + currentHp);
    }

    private void OnMouseDown()
    {
        //�M�̏�ō��N���b�N�����ꂽ��
        //�����łǂ�����ĉ����ꂽ��ނ̂𔻒肷�邩
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
        //tag�̒��Ɋ܂܂��Ή��������O�ŃX�R�A�ω�
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
