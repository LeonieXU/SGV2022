using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CautionEnd : MonoBehaviour
{
    public GameObject Attention;

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
        if(other.tag =="Saw")
        {
            Attention.SetActive(false);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.tag =="Saw")
        {
            Attention.SetActive(false);
        }
    }
}
