using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonscript : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    float timeBetween;
    public float starttimebetween;
    private bool shoot=true;

    // Start is called before the first frame update
    void Start()
    {
        timeBetween = starttimebetween;
    }

    // Update is called once per frame
    void Update()
    {
        if(shoot == true)
        {
                if (timeBetween<= 0)
            {
                Instantiate(bullet,firepoint.position,firepoint.rotation);
                AudioManager.Instance.Play("Shoot");
                timeBetween = starttimebetween;

            }
            else
            {
                timeBetween -= Time.deltaTime;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Player") shoot = false;
    }
}
