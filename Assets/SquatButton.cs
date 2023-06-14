using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquatButton : MonoBehaviour
{
    public void OnClickSquatButton()
    {
        Gage.instance.point -= 0.5f;
        Gage.instance.currentHp -= 0.5f;
    }
}
