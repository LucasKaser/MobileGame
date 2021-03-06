﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour {
    private void Start()
    {
        Time.timeScale = 1;
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void hard()
    {
        PlayerPrefs.SetInt("GameDifficulty", 3);
    }
    public void medium()
    {
        PlayerPrefs.SetInt("GameDifficulty", 2);
    }
    public void easy()
    {
        PlayerPrefs.SetInt("GameDifficulty", 1);
    }
    public void Keyboard()
    {
        PlayerPrefs.SetInt("Controls", 1);
    }
    public void Touch()
    {
        PlayerPrefs.SetInt("Controls", 2);
    }
    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
