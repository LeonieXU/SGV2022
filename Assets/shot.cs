using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb2d;
    private SpriteRenderer _spriteRenderer;
    private CapsuleCollider2D _Collider2D;
    // public Transform shotPoint;
    // public Transform target;

    public Transform Cannon;
    private Vector3 MoveSpeed;
    public float power = 30;
    public float Gravity = -10;// g
    private Vector3 GritySpeed = Vector3.zero;
    private float dTime;// passed time

    void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _Collider2D = GetComponent<CapsuleCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();

        MoveSpeed = Cannon.rotation * Vector3.right * power;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GritySpeed.y = Gravity * (dTime += Time.fixedDeltaTime); 
        transform.position += (MoveSpeed + GritySpeed) * Time.fixedDeltaTime; 
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "End")
        {
            _spriteRenderer.enabled = false;
            _Collider2D.enabled = false;
            Destroy(gameObject, t:0.2f);
        }
    }


}

