
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed = 3.0f;
    bool stopR = false;
    bool stopU = false;
    bool stopD = false;
    bool stopL = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 velocity = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = velocity * moveSpeed;
        if (stopR == true && stopL == true && stopU == true && stopD == true)
        {
            gameObject.GetComponent<Animator>().SetBool("Idle", true);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            stopU = false;
            gameObject.GetComponent<Animator>().SetFloat("Y", 1);
            gameObject.GetComponent<Animator>().SetFloat("X", 0);
            gameObject.GetComponent<Animator>().SetBool("Idle", false);
            gameObject.GetComponent<Animator>().SetBool("Up", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            stopU = true;
            gameObject.GetComponent<Animator>().SetFloat("X", 0);
            gameObject.GetComponent<Animator>().SetFloat("Y", 0);
            gameObject.GetComponent<Animator>().SetBool("Up", false);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            stopL = false;
            gameObject.GetComponent<Animator>().SetFloat("X", -1);
            gameObject.GetComponent<Animator>().SetFloat("Y", 0);
            gameObject.GetComponent<Animator>().SetBool("Idle", false);
            gameObject.GetComponent<Animator>().SetBool("Left", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            stopL = true;
            gameObject.GetComponent<Animator>().SetFloat("X", 0);
            gameObject.GetComponent<Animator>().SetFloat("Y", 0);
            gameObject.GetComponent<Animator>().SetBool("Left", false);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            stopD = false;
            gameObject.GetComponent<Animator>().SetFloat("Y", -1);
            gameObject.GetComponent<Animator>().SetFloat("X", 0);
            gameObject.GetComponent<Animator>().SetBool("Idle", false);
            gameObject.GetComponent<Animator>().SetBool("Down", true);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            stopD = true;
            gameObject.GetComponent<Animator>().SetFloat("X", 0);
            gameObject.GetComponent<Animator>().SetFloat("Y", 0);
            gameObject.GetComponent<Animator>().SetBool("Down", false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            stopR = false;
            gameObject.GetComponent<Animator>().SetFloat("X", 1);
            gameObject.GetComponent<Animator>().SetFloat("Y", 0);
            gameObject.GetComponent<Animator>().SetBool("Idle", false);
            gameObject.GetComponent<Animator>().SetBool("Right", true);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            stopR = true;
            gameObject.GetComponent<Animator>().SetFloat("X", 0);
            gameObject.GetComponent<Animator>().SetFloat("Y", 0);
            gameObject.GetComponent<Animator>().SetBool("Right", false);
        }
    }
    
}
