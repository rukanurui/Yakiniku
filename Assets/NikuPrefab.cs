using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NikuPrefab : MonoBehaviour
{
    public float timeOut;
    private float timeElapsed;
    public int foodRand = 0;

    public int foodTime=0;

    private bool stay;
    // Use this for initialization
    void Start()
    {

    }

    //�X�V
    void Update()
    {

        //�������Ă��Ȃ��Ƃ�
        if(stay==false)
        {
            foodTime += 1;
            if (foodTime > 90)
            {
                //����
                System.Random myObject = new System.Random();
                foodRand = UnityEngine.Random.Range(1, 7); ;

                //�����őI�����ꂽ���𐶐�
                if (foodRand == 1)
                {
                    // Do anything
                    // Cube�v���n�u��GameObject�^�Ŏ擾
                    GameObject obj = (GameObject)Resources.Load("niku2");
                    // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
                    Instantiate(obj, new Vector3(2.2f,2.5f, -7.0f), Quaternion.identity);
                }
                else if(foodRand==2)
                {
                    // Do anything
                    // Cube�v���n�u��GameObject�^�Ŏ擾
                    GameObject obj = (GameObject)Resources.Load("Yasai");
                    // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                else if (foodRand == 3)
                {
                    // Do anything
                    // Cube�v���n�u��GameObject�^�Ŏ擾
                    GameObject obj = (GameObject)Resources.Load("tori");
                    // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                else if (foodRand == 4)
                {
                    // Do anything
                    // Cube�v���n�u��GameObject�^�Ŏ擾
                    GameObject obj = (GameObject)Resources.Load("kabocha");
                    // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                else if (foodRand == 5)
                {
                    // Do anything
                    // Cube�v���n�u��GameObject�^�Ŏ擾
                    GameObject obj = (GameObject)Resources.Load("pi-man");
                    // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                else
                {
                    // Do anything
                    // Cube�v���n�u��GameObject�^�Ŏ擾
                    GameObject obj = (GameObject)Resources.Load("horumon");
                    // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                foodTime = 0;
            }
        }
        else
        {
            //�������Ă����烊�Z�b�g���Đ������Ȃ�
            foodTime = 0;
        }
    }



    private void OnCollisionEnter(Collision collision)
    {
        stay = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        stay = false;
    }
}
