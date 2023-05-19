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

        // CubeプレハブをGameObject型で取得
        GameObject obj = (GameObject)Resources.Load("niku2");
        // Cubeプレハブを元に、インスタンスを生成、
        Instantiate(obj, new Vector3(0.0f, 2.3f, -7.0f), Quaternion.identity);
    }

    //更新
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed >= timeOut)
        {
            // Do anything
            // CubeプレハブをGameObject型で取得
            GameObject obj = (GameObject)Resources.Load("niku2");
            // Cubeプレハブを元に、インスタンスを生成、
            Instantiate(obj, new Vector3(2.2f, 2.3f, -7.0f), Quaternion.identity);


            timeElapsed = 0.0f;
        }
 

    }

}
