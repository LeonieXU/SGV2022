using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl2 : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(player.position.x,0,-10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x,0,-10f);
    }
}
