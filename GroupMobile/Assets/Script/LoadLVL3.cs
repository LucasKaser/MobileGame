﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLVL3 : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // attach to the object ending the game, not the player
            Time.timeScale = 1;
            SceneManager.LoadScene("Level3");
        }

    }

}
