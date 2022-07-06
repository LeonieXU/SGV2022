using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RingProcess : MonoBehaviour
{
    //loading speed
    public float speed = 1;
    //one picture per frame
    public Transform _Image;

    // public Transform _Text;

    //Process Controll
    public int targetProcess = 100;
    private float currentAmout = 0;
    public GameObject leftMouse;
    public GameObject Munition;
    // public GameObject Munition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && currentAmout < targetProcess)
        {
            currentAmout += speed;
            // _Text.GetComponent<Text>().text = ((int)currentAmout).ToString() + "%";
            _Image.GetComponent<Image>().fillAmount = currentAmout / 100.0f;    
        }
        if (currentAmout >= targetProcess && gameObject != null)
        {
            currentAmout = targetProcess;

            Destroy(gameObject);
            leftMouse.SetActive(false);
            Munition.SetActive(true);
        }
    }
}
