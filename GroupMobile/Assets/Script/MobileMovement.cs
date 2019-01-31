using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileMovement : MonoBehaviour {
    public float Movespeed = 1.0f;
    public float Jumpspeed = 1.0f;
    public bool Grounded = false;
    private float moveDir = 0;
	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Move();
	}
    private void Move()
    {
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        velocity.x = Movespeed * moveDir;
        GetComponent<Rigidbody2D>().velocity = velocity;
    }
    public void MoveRight()
    {
        moveDir = 1;
    }
    public void MoveLeft()
    {
        moveDir = -1;
    }
    public void stop()
    {
        moveDir = 0;
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
