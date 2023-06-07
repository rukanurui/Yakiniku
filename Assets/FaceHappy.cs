using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class FaceHappy : MonoBehaviour
{
    [SerializeField] Sprite[] SpriteArray = new Sprite[3];
    public Image image;

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
        value = GameObject.Find("ŽM");
        get = value.GetComponent<Gage>();
        image = this.GetComponent<Image>();
    }


    // Update is called once per frame
    void Update()
    {

        numvalue = get.happySlider.value;

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
            image.sprite = SpriteArray[0];
        }

        if (level == faceLevel.Middle)
        {
            image.sprite = SpriteArray[1];
        }

        if (level == faceLevel.Empty)
        {
            image.sprite = SpriteArray[2];
        }

    }
}
