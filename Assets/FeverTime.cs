using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//追加↓
using UnityEditor;

//これでEnemyのpublicがインスペクタに表示される
#if UNITY_EDITOR
[CustomEditor(typeof(Gage))]
#endif


public class FeverTime : Gage
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
