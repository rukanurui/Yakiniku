using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI: MonoBehaviour
{
    //LoadSceneの引数名のシーンに移動する
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
