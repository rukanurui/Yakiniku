using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{

    [SerializeField] Material[] materialArray = new Material[3];
    public enum fireLevel
    {
        NONE,
        RARE,
        WELLDONE,
        KOGE
    }
    float firecount;

    public fireLevel level = fireLevel.NONE;

    string Ami;//ñ‘Ç©Ç«Ç§Ç©ÇÃî‰är

    // Start is called before the first frame update
    void Start()//èâä˙âª
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (level < fireLevel.KOGE)
        {
            if (other.gameObject.tag == "Ami")
            {
                firecount += 1.0f;
            }

            if (firecount >= 240)
            {
                level++;
                firecount = 0;
            }
        }

    }

    // Update is called once per frame
    void Update()//çXêV
    {

        if(level==fireLevel.NONE)
        {
            GetComponent<MeshRenderer>().material = materialArray[0];
        }

        if (level== fireLevel.WELLDONE)
        {
            GetComponent<MeshRenderer>().material = materialArray[1];
        }

        if (level == fireLevel.KOGE)
        {
            GetComponent<MeshRenderer>().material = materialArray[2];
        }

    }
}
