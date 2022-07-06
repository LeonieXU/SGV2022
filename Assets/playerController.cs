using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public static class Global
{
    public static int scoreCalc = 0;
    public static int index;
}

public class playerController : MonoBehaviour
{
    public float jumpForce = 40;
    private Rigidbody2D rb;
    private CircleCollider2D coll;
    public LayerMask ground;
    private bool isGround;
    private int extraJump;
    public float speed = 6;
    public float maxTime = 1;
    private float timer = 0;
    public UnityEngine.UI.Text Score;


    private bool isPlayerstatic = false;
    private Animator anim;
    public float Timer = 3.0f;
    public float settime = 3.0f;
    public GameObject interaction1;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //get Collider2D
        coll = GetComponent<CircleCollider2D>();
        //get Animator
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //interaction
        if(isPlayerstatic == true)
        {          
            Timer -= Time.deltaTime;
            speed = 0;
            anim.SetBool("isPlayerstatic", true);
            jump();
            Movement();

            if (interaction1 == null || Timer <= 0.0f)
            {
                isPlayerstatic = false;
                anim.SetBool("isPlayerstatic", false);
                Timer = settime;
            }
        }
        else
        {
            isGround = coll.IsTouchingLayers(ground);
            speed = 6;
            Movement();
            jump();
            addScore();
        }
    }

    // Player jumping
    void jump()
    {
        if(isGround)
        {
            extraJump = 1;
            
            // anim.SetBool("isJump",false);
            // anim.SetBool("isDJump",false);
        }
        if(Input.GetButtonDown("Jump") && extraJump > 0)
        {
            rb.velocity = new Vector3(speed,jumpForce,0);
            extraJump --;
            // anim.SetBool("isJump", true); 
            AudioManager.Instance.Play("Jump");
            if(Input.GetButtonDown("Jump") && !isGround)
            {
                // anim.SetBool("isDJump", true);
                AudioManager.Instance.Play("DJump");
                // anim.SetBool("isDJump", false);
            }    
        }
        if(Input.GetButtonDown("Jump") && extraJump == 0 && isGround)
        {
            rb.velocity = new Vector3(speed,jumpForce,0);
            // anim.SetBool("isJump",false); 
        }        
    }

    //Player moving
    private void Movement()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
    // void SwitchAnim()
    // {
        
    // }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.tag == "Collection")
        {
            AudioManager.Instance.Play("Collection");
            Destroy(collision.gameObject);
            Global.scoreCalc += 50;
            Score.text = Global.scoreCalc.ToString();
        }
        if(collision.tag == "Saw"||collision.tag == "Saw1"||collision.tag == "Saw2")
        {
            AudioManager.Instance.Play("Lose");
            isPlayerstatic = true;
            Invoke("Restart", 1f);// delay 1s
        }
        if(collision.tag == "End")
        {
            Global.index = SceneManager.GetActiveScene().buildIndex;
            AudioManager.Instance.Play("Win");
            isPlayerstatic = true;
            Invoke("Win", 1f);// delay 1s
        }

        //Interaction
        if(collision.tag == "IsInteraction")
        {
            AudioManager.Instance.Play("Collection");//test audioeffect
            isPlayerstatic = true;
        }
        if(collision.tag == "Finish")
        {
            AudioManager.Instance.Play("Win");
            Invoke("Finish", 1.5f);// delay 1.5s
        }
        /*
        //win and turn to EndScreen
        
        */
        /*
        //die and restart
        if(collision.tag == "Die")
        {
            AudioManager.Instance.Play("Die");
            Invoke("Restart", 1.5f);// delay 1.5s
        }*/
    }

    private void addScore()
    {
        if(timer > maxTime)
        {
            Global.scoreCalc += 1;
            Score.text = Global.scoreCalc.ToString();
            timer = 0;
        }
        timer += (1 * Time.deltaTime);
    }
    
    // dead reload this level scene.
    void Restart()
    {
        SceneManager.LoadScene(1);
    }

    // win load EndScreen 
    void Win()
    {
        SceneManager.LoadScene("midPage");
    }
    void Finish()
    {
        SceneManager.LoadScene("startPage");
    }
    

}

    
