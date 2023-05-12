using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    // public static SphereScript instance;
    public int point;
    public bool Saraflag = false;
    // Start is called before the first frame update

    public static Eat instance;
    

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        Fire firelevel = GetComponent<Fire>();

        if (other.gameObject.tag == "Sara")
        {
            if (firelevel.level >= Fire.fireLevel.WELLDONE)
                Saraflag = true;
        }

    }

    private void OnMouseDown()
    {
        //皿の上で左クリックを押したら
        if (Saraflag == true)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
