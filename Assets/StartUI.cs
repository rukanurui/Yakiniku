using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI: MonoBehaviour
{
    //LoadScene�̈������̃V�[���Ɉړ�����
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
