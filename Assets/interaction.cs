using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaction : MonoBehaviour
{
    public float Up = 2; 
    private float minTrans = 0;
    public float maxTrans = 10;
    public GameObject Mouseleft;
    public Transform Disturb;
    private bool inAct = false;
    // public GameObject Loadingbar;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inAct)
        {    
            if(Input.GetButtonDown("Fire1") && minTrans <= maxTrans)
            {
                minTrans += Up;
                Disturb.position += Up * Vector3.up;
            }
            if(minTrans > maxTrans)
            {
                minTrans = 0;
                Mouseleft.SetActive(false);
                inAct = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player")
        {
            Mouseleft.SetActive(true);
            inAct = true;
        }    
    }
}
