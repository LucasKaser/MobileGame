using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    void hard()
    {
        PlayerPrefs.SetInt("GameDifficulty", 3);
    }
    void medium()
    {
        PlayerPrefs.SetInt("GameDifficulty", 2);
    }
    void easy()
    {
        PlayerPrefs.SetInt("GameDifficulty", 1);
    }
}
