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
    //public Eat eat;
    //Slider������
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
        //�|�C���g��0�ɂ���
        point = 0;
        //Slider�𖞃^���ɂ���B
        slider.value = 0;
        //���݂�HP��0�Ɠ����ɁB
        currentHp = 0;
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
