using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    bool used = false;
    public GameObject Door;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Door.SetActive(false);
            gameObject.GetComponent<Animator>().SetBool("Used", true);
        }
    }
}
