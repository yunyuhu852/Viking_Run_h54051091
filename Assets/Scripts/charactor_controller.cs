using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class charactor_controller : MonoBehaviour
{
    float forwardspeed = 800f;
    float downspeed = -600f;
    float upspeed = 14000f;
    float sidespeed = 400f;
    private Rigidbody body;
    private Animator animator;
    private Quaternion quaternion;
    bool jump;
    bool kiss;
    bool turn;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        jump = false;
        kiss = false;
        turn = false;
    }

    public void OnTriggerEnter(Collider other)
    {
//        Debug.Log(other.name + "in");
        if (other.name == "rock_07")
        {
            static_var.collinsion_stone += 6;
            kiss = true;
            transform.position += transform.forward*2;
            Invoke("KissFalse", 0.8f);
        }
        if (other.name == "conertrigger")
        {
            turn = true;
        }
    }
    public void OnTriggerExit(Collider other)
    {
//        Debug.Log(other.name + "out");
        if (other.name == "conertrigger")
        {
            turn = false;
        }
    }
    public void OnTriggerStay(Collider other)
    {
//        Debug.Log(other.name+ "in");
        if (other.name == "big_module_05_floor")
        {
            if (transform.position.y <= 0)
            {
                jump = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        RunSpeed();
        body.velocity = transform.TransformDirection(new Vector3(0, 0, 1)) * forwardspeed*Time.deltaTime;
        body.velocity += transform.TransformDirection(new Vector3(0,1,0)) * downspeed * Time.deltaTime;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (turn)
            {
                if (static_var.rotate == 0)
                {
                    static_var.rotate = 3;
                }
                else
                {
                    static_var.rotate--;
                }
                quaternion.SetLookRotation(-transform.right);
                turn = false;
            }
            else
            {
                if (!jump)
                    body.velocity += transform.TransformDirection(new Vector3(-1, 0, 0)) * sidespeed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (turn)
            {
                if (static_var.rotate == 3)
                {
                    static_var.rotate = 0;
                }
                else
                {
                    static_var.rotate++;
                }
                quaternion.SetLookRotation(transform.right);
                turn = false;
            }
            else
            {
                if (!jump)
                    body.velocity += transform.TransformDirection(new Vector3(1, 0, 0)) * sidespeed * Time.deltaTime;
            }
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (!jump)
            {
                jump = true;
                body.velocity += transform.TransformDirection(new Vector3(0, 1, 0)) * upspeed * Time.deltaTime;
//                transform.Translate(Vector3.up * Time.deltaTime * upspeed);
            }
        }
        Rotate();
        animator.SetBool("y_post", jump);
        animator.SetBool("kiss", kiss);
        overtest();

    }
    public void Rotate()
    {
        transform.rotation = Quaternion.RotateTowards(transform.rotation, quaternion, 500 * Time.deltaTime);
    }
    public void overtest()
    {
        if (transform.position.y <= -3 || static_var.collinsion_stone >= 13)
        {
            Time.timeScale = 0f;
            GameOver();
        }
    }
    public void RunSpeed()
    {

        if (kiss==true)
        {
            forwardspeed = 500f;
            sidespeed = 200f;
        }
        else
        {
            if (static_var.timescore >= 60)
            {
                if (forwardspeed >= 2000f)
                {
                    forwardspeed = 2000f;
                    sidespeed = 1200f;
                }
                else
                {
                    forwardspeed += static_var.timescore * 30;
                    sidespeed += static_var.timescore * 30;
                }

            }
            else if (static_var.timescore >= 40)
            {
                if (forwardspeed >= 1400f)
                {
                    forwardspeed = 1400f;
                    sidespeed = 800f;
                }
                else
                {
                    forwardspeed = static_var.timescore * 30;
                    sidespeed = static_var.timescore * 30;
                }

            }
            else if (static_var.timescore >= 10)
            {
                if (forwardspeed >= 1100f)
                {
                    forwardspeed = 1100f;
                    sidespeed = 700f;
                }
                else
                {
                    forwardspeed = static_var.timescore * 80;
                    sidespeed = static_var.timescore * 40;
                }

            }
            else
            {
                forwardspeed = 800f;
                sidespeed = 400f;
            }
        }
    }
    public void KissFalse()
    {
        kiss = false;
    }
    public void GameOver()
    {
        int SceneIndexDestination = 2;
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log("current scene name = " + scene.name + "and scene index = " + scene.buildIndex);


        SceneManager.LoadScene(SceneIndexDestination);
    }

}
