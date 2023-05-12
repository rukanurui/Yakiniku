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
    public Eat eat;
    public int point;

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
