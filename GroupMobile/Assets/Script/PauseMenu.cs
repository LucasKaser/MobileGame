using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {
    public float Tm = 1.0f;
    public GameObject Pause;
    // Use this for initialization
    void Start() {
        Time.timeScale = Tm;
    }

    // Update is called once per frame
    void Update() {
        
            if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0)
                {
                Resume();
                
            }
            else 
            {
                //Show Menu Buttons, Pause game
                Pause.SetActive(true);
                Time.timeScale = 0;
            }

        }
    }
    public void Resume()
    {
        Pause.SetActive(false);
        Time.timeScale = Tm;

    }
    public void PauseGame()
    {
        //Show Menu Buttons, Pause game
        Pause.SetActive(true);
        Time.timeScale = 0;
    }
}
