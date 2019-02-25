using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour {
    public float Movespeed = 1.0f;
    public float Jumpspeed = 1.0f;
    public bool Grounded = false;
    private float moveDir = 0;
    private float moveDirY = 0;
    bool stopR = false;
    bool stopU = false;
    bool stopD = false;
    bool stopL = false;
    // Use this for initialization
    void Start ()
    {
		
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
        velocity.x = Movespeed * moveDir;
        velocity.y = Movespeed * moveDirY;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
    public void MoveRight()
    {
        moveDir = 1;
        gameObject.GetComponent<Animator>().SetFloat("X", 1);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
        gameObject.GetComponent<Animator>().SetBool("Idle", false);
    }
    public void MoveLeft()
    {
        moveDir = -1;
        gameObject.GetComponent<Animator>().SetFloat("X", -1);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
        gameObject.GetComponent<Animator>().SetBool("Idle", false);
    }
    public void MoveUp()
    {
        moveDirY = 1;
        gameObject.GetComponent<Animator>().SetFloat("Y", 1);
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetBool("Idle", false);
    }
    public void MoveDown()
    {
        moveDirY = -1;
        gameObject.GetComponent<Animator>().SetFloat("Y", -1);
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetBool("Idle", false);
    }
    public void stopUp()
    {
        stopU = true;
        moveDir = 0;
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
       // gameObject.GetComponent<Animator>().SetBool("Idle", true);

    }
    public void stopDown()
    {
        stopD = true;
        moveDirY = 0;
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
      //  gameObject.GetComponent<Animator>().SetBool("Idle", true);
    }
    public void stopLeft()
    {
        stopL = true;
        moveDir = 0;
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
       // gameObject.GetComponent<Animator>().SetBool("Idle", true);
    }
    public void stopRight()
    {
        stopR = true;
        moveDir = 0;
        gameObject.GetComponent<Animator>().SetFloat("X", 0);
        gameObject.GetComponent<Animator>().SetFloat("Y", 0);
       // gameObject.GetComponent<Animator>().SetBool("Idle", true);
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
