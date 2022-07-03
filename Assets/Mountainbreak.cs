using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Mountainbreak : MonoBehaviour
{
    private TilemapRenderer _Renderer;
    private TilemapCollider2D _Collider2D;
    // Start is called before the first frame update
    void Start()
    {
        _Renderer = GetComponent<TilemapRenderer>();
        _Collider2D = GetComponent<TilemapCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Munition")
        {
            _Renderer.enabled = false;
            _Collider2D.enabled = false;
            AudioManager.Instance.Play("Boom");
            Destroy(gameObject);
        }
    }
}
