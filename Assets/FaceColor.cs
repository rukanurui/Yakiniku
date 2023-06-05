using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//UIégÇ§Ç∆Ç´ÇÕñYÇÍÇ∏Ç…ÅB
using UnityEngine.UI;

public class FaceColor : MonoBehaviour
{

    [SerializeField] Sprite[] SpriteArray = new Sprite[3];

    public enum faceLevel
    {
        Full,
        Middle,
        Empty
    }

    public faceLevel level = faceLevel.Full;

    GameObject value;
    Gage get;

    float numvalue = 50;

    private void Start()
    {
        value = GameObject.Find("éM");
        get = value.GetComponent<Gage>();
    }


    // Update is called once per frame
    void Update()
    {

        numvalue = get.healthSlider.value;

        if (numvalue >= 0.6)
        {
            level = faceLevel.Full;
        }

        if (numvalue <= 0.59 && numvalue >= 0.3)
        {
            level = faceLevel.Middle;
        }

        if (numvalue <= 0.29)
        {
            level = faceLevel.Empty;
        }

        if (level == faceLevel.Full)
        {
            GetComponent<SpriteRenderer>().sprite = SpriteArray[0];
        }

        if (level == faceLevel.Middle)
        {
            GetComponent<SpriteRenderer>().sprite = SpriteArray[1];
        }

        if (level == faceLevel.Empty)
        {
            GetComponent<SpriteRenderer>().sprite = SpriteArray[2];
        }

    }
}
