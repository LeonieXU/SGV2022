using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgControl2 : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x,0,0);
    }
}
