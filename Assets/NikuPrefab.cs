using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NikuPrefab : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // Cube�v���n�u��GameObject�^�Ŏ擾
        GameObject obj = (GameObject)Resources.Load("niku2");
        // Cube�v���n�u�����ɁA�C���X�^���X�𐶐��A
        Instantiate(obj, new Vector3(0.0f, 2.3f, -7.0f), Quaternion.identity);
    }

    //�X�V
    void Update()
    {
        //�M�̏�ɒu����ĂȂ��ꏊ�����݂���̂Ȃ炻���Ƀ����_���Ő�������
        //

    }

}
