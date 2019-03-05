using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour {
    public float Movespeed = 1.0f;
    public float Jumpspeed = 1.0f;
    public bool Grounded = false;
    private float moveDirL = 0;
    private float moveDirU = 0;
    private float moveDirR = 0;
    private float moveDirD = 0;
    bool stopR = false;
    bool stopU = false;
    bool stopD = false;
    bool stopL = false;
    // Use this for initialization
    void Start ()
    {
		if(PlayerPrefs.GetInt("Controls") == 1)
        {
            this.enabled = false;
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
        if (stopR == true && stopL == true && stopU == true && stopD == true)
        {
            gameObject.GetComponent<Animator>().SetBool("Idle", true);
        }
        
    }
    private void Move()
    {
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        if (Movespeed * moveDirL < 0 && Movespeed * moveDirR == 0)
        {
            velocity.x = Movespeed * moveDirL;
        }
        else if (Movespeed * moveDirR > 0 && Movespeed * moveDirL == 0)
        {
            velocity.x = Movespeed * moveDirR;
        }
        else if (Movespeed * moveDirR == 0 && Movespeed * moveDirL == 0)
        {
            velocity.x = 0;
        }
        if (Movespeed * moveDirU > 0 && Movespeed * moveDirD == 0)
        {
            velocity.y = Movespeed * moveDirU;
        }
        else if (Movespeed * moveDirD < 0 && Movespeed * moveDirU == 0)
        {
            velocity.y = Movespeed * moveDirD;
        }
        else if (Movespeed * moveDirD == 0 && Movespeed * moveDirU == 0)
        {
            velocity.y = 0;
        }
        /*velocity.x = Movespeed * moveDirL;
        velocity.y = Movespeed * moveDirU;
        velocity.x = Movespeed * moveDirR;
        velocity.y = Movespeed * moveDirD;*/
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
    public void MoveRight()
    {
        stopR = false;
        moveDirR = 1;
        gameObject.GetComponent<Animator>().SetFloat("X", 1);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
        gameObject.GetComponent<Animator>().SetBool("Idle", false);
        gameObject.GetComponent<Animator>().SetBool("Right", true);
    }
    public void MoveLeft()
    {
        stopL = false;
        moveDirL = -1;
        gameObject.GetComponent<Animator>().SetFloat("X", -1);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
        gameObject.GetComponent<Animator>().SetBool("Idle", false);
        gameObject.GetComponent<Animator>().SetBool("Left", true);
    }
    public void MoveUp()
    {
        moveDirU = 1;
        stopU = false;
        gameObject.GetComponent<Animator>().SetFloat("Y", 1);
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetBool("Idle", false);
        gameObject.GetComponent<Animator>().SetBool("Up", true);
    }
    public void MoveDown()
    {
        moveDirD = -1;
        stopD = false;
        gameObject.GetComponent<Animator>().SetFloat("Y", -1);
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetBool("Idle", false);
        gameObject.GetComponent<Animator>().SetBool("Down", true);
    }
    public void stopUp()
    {
        stopU = true;
        moveDirU = 0;
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
        gameObject.GetComponent<Animator>().SetBool("Up", false);

    }
    public void stopDown()
    {
        stopD = true;
        moveDirD = 0;
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
        gameObject.GetComponent<Animator>().SetBool("Down", false);
    }
    public void stopLeft()
    {
        stopL = true;
        moveDirL = 0;
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
        gameObject.GetComponent<Animator>().SetBool("Left", false);
    }
    public void stopRight()
    {
        stopR = true;
        moveDirR = 0;
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
        gameObject.GetComponent<Animator>().SetBool("Right", false);
    }
    public void Jump()
    {
        if (Grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 100 * Jumpspeed));
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.layer == 8)
        {
            Grounded = true;
        } 
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Grounded = false;
        }
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Grounded = true;
        }
    }

}
