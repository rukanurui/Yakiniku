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

    //更新
    void Update()
    {

        //当たっていないとき
        if(stay==false)
        {
            foodTime += 1;
            if (foodTime > 90)
            {
                //乱数
                System.Random myObject = new System.Random();
                foodRand = UnityEngine.Random.Range(1, 7); ;

                //乱数で選択された方を生成
                if (foodRand == 1)
                {
                    // Do anything
                    // CubeプレハブをGameObject型で取得
                    GameObject obj = (GameObject)Resources.Load("niku2");
                    // Cubeプレハブを元に、インスタンスを生成、
                    Instantiate(obj, new Vector3(2.2f,2.5f, -7.0f), Quaternion.identity);
                }
                else if(foodRand==2)
                {
                    // Do anything
                    // CubeプレハブをGameObject型で取得
                    GameObject obj = (GameObject)Resources.Load("Yasai");
                    // Cubeプレハブを元に、インスタンスを生成、
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                else if (foodRand == 3)
                {
                    // Do anything
                    // CubeプレハブをGameObject型で取得
                    GameObject obj = (GameObject)Resources.Load("tori");
                    // Cubeプレハブを元に、インスタンスを生成、
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                else if (foodRand == 4)
                {
                    // Do anything
                    // CubeプレハブをGameObject型で取得
                    GameObject obj = (GameObject)Resources.Load("kabocha");
                    // Cubeプレハブを元に、インスタンスを生成、
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                else if (foodRand == 5)
                {
                    // Do anything
                    // CubeプレハブをGameObject型で取得
                    GameObject obj = (GameObject)Resources.Load("pi-man");
                    // Cubeプレハブを元に、インスタンスを生成、
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                else
                {
                    // Do anything
                    // CubeプレハブをGameObject型で取得
                    GameObject obj = (GameObject)Resources.Load("horumon");
                    // Cubeプレハブを元に、インスタンスを生成、
                    Instantiate(obj, new Vector3(2.2f, 2.5f, -7.0f), Quaternion.identity);
                }
                foodTime = 0;
            }
        }
        else
        {
            //当たっていたらリセットして生成しない
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
