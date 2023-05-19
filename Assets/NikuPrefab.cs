using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NikuPrefab : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("niku2");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(0.0f, 2.3f, -7.0f), Quaternion.identity);
    }

    //更新
    void Update()
    {
        //皿の上に置かれてない場所が存在するのならそこにランダムで生成する
        //

    }

}
