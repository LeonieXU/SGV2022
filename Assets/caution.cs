using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caution : MonoBehaviour
{
    public GameObject Attention;
    public GameObject Attention1;
    public GameObject Attention2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag =="Saw")// shotted
        {
            Attention.SetActive(true);
        }
        if(other.tag =="Saw1")// static
        {
            Attention1.SetActive(true);
        }
        if(other.tag =="Saw2")// dynamic
        {
            Attention2.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag =="Saw")
        {
            Attention.SetActive(false);
        }
        if(other.tag =="Saw1")
        {
            Attention1.SetActive(false);
        }
        if(other.tag =="Saw2")
        {
            Attention2.SetActive(false);
        }
    }
}
