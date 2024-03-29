using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    AudioSource audioSource;

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

    string Ami;//網かどうかの比較

    public GameObject ParticleKemuri;

    // Start is called before the first frame update
    void Start()//初期化
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (level < fireLevel.KOGE)
        {
            if (other.gameObject.tag == "Ami")
            {
                firecount += 1.0f;
                Instantiate(ParticleKemuri,this.transform.position,Quaternion.identity);
                
                audioSource = GetComponent<AudioSource>();
                audioSource.Play();
            }
            else
            {
                //audioSource = this.GetComponent<AudioSource>();
                //audioSource.Stop();
                //ParticleKemuri.SetActive(false);
            }

            if (firecount >= 480)
            {
                level++;
                firecount = 0;
            }
        }

    }

    // Update is called once per frame
    void Update()//更新
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
