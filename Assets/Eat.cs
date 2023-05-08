using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{

    public bool Saraflag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        NikuFire firelevel = GetComponent<NikuFire>();

       if (other.gameObject.tag == "Sara")
      {
          if(firelevel.level>=NikuFire.fireLevel.WELLDONE)
          Saraflag = true;
      }

    }

    private void OnMouseDown()
    {
        //M‚Ìã‚Å¶ƒNƒŠƒbƒN‚ğ‰Ÿ‚µ‚½‚ç
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
