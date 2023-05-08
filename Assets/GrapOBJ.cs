using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapOBJ : MonoBehaviour
{

    BoxCollider BoxCol;
    bool grapflag = true;
    // Start is called before the first frame update
    void Start()
    {
        BoxCol = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
        if(grapflag==true)
        {
            BoxCol.enabled = false;
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                transform.position = new Vector3(hit.point.x, hit.point.y + 0.5f, hit.point.z);
                //Debug.Log(hit.collider.name);
            }
        }
       
    }

    private void Update()
    {
        Eat sara = GetComponent<Eat>();
        //GameObject obj = GameObject.Find("Sara");
        //sara = obj.GetComponent<Eat>();

        //皿の上にないときだけ拾える
        if (sara.Saraflag == true)
        {
            grapflag = false;
        }

    }

    void OnMouseUp()
    {
        BoxCol.enabled = true;
    }

}
