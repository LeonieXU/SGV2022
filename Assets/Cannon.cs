using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject Mouseleft;
    public GameObject Loadingbar;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player" && Loadingbar.gameObject != null)
        {
            Mouseleft.SetActive(true);
            Loadingbar.SetActive(true);
        }
        
    }
}
