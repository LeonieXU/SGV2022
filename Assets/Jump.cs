using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 100;
    // public float timeBetweenJumps;
    // private float timeBetweenJumpsCount;
    // public float speed;
    private Rigidbody2D rb;
    // private bool canJump;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // canJump = true;
        // timeBetweenJumpsCount = timeBetweenJumps;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Jump"))
        {
        // rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        rb.velocity = new Vector3(0,jumpForce,0);
        
        }
        
        // if(Input.GetMouseButtonDown(0))
        // {
        //     //Jump
        //     rb.velocity = Vector2.up * velocity;
        //     // rb.AddForce(Vector2.up * jumpForce);
        //     // canJump = false;
        
        // }
        // if(!canJump)
        // {
        //      timeBetweenJumps -= Time.deltaTime;
            
        //     if(timeBetweenJumps <= 0.0f)
        //     {
        //         timeBetweenJumps = timeBetweenJumpsCount;
        //         canJump = true;
        //     }
        // }
    }
}
