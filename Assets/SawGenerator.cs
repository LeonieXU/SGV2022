using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawGenerator : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject saw;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject newsaw = Instantiate(saw);
        newsaw.transform.position = transform.position +new Vector3(0, Random.Range(0, height), 0);

    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newsaw = Instantiate(saw);
            newsaw.transform.position = transform.position +new Vector3(0, Random.Range(0, height), 0);
            Destroy(newsaw, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
