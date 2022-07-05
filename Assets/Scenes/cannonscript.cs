using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonscript : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    float timeBetween;
    public float starttimebetween;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        timeBetween = starttimebetween;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetween<= 0)
        {
            Instantiate(bullet,firepoint.position,firepoint.rotation);
            timeBetween = starttimebetween;

        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }
}
