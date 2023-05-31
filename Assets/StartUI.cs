using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartUI: MonoBehaviour
{
    //LoadScene‚Ìˆø”–¼‚ÌƒV[ƒ“‚ÉˆÚ“®‚·‚é
    public void OnClickStartButton()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
