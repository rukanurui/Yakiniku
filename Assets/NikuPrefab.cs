using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NikuPrefab : MonoBehaviour
{
    public float timeOut;
    private float timeElapsed;


    // Use this for initialization
    void Start()
    {
        timeOut = 5.0f;

        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("niku2");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(0.0f, 2.3f, -7.0f), Quaternion.identity);
    }

    //�X�V
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // Do anything
            // Cube�v���n�u��GameObject�^�Ŏ擾
            GameObject obj = (GameObject)Resources.Load("niku2");
            // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
            Instantiate(obj, new Vector3(2.2f, 2.3f, -7.0f), Quaternion.identity);


            timeElapsed = 0.0f;
        }
 

    }

}
