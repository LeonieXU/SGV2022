using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class SawGenerator : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject saw;
    // public float height;
    private int[] arr1 = new[]{5,30,60};
    private Random rnd = new Random();
    private int rndMember;
    //  = arr1[rnd.Next(arr1.Length)]


    // Start is called before the first frame update
    void Start()
    {
        GameObject newsaw = Instantiate(saw);
        // newsaw.transform.position = transform.position +new Vector3(0, Random.Range(0, height), 0);
        rndMember = arr1[rnd.Next(arr1.Length)];
        newsaw.transform.position = transform.position +new Vector3(0, rndMember, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newsaw = Instantiate(saw);
            rndMember = arr1[rnd.Next(arr1.Length)];
            newsaw.transform.position = transform.position +new Vector3(0, rndMember, 0);
            Destroy(newsaw, 6);
            timer = 0;
        }

        timer += (5 * Time.deltaTime);
    }
}
