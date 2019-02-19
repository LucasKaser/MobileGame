using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasyEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("GameDifficulty") == 2|| PlayerPrefs.GetInt("GameDifficulty") == 3)
        {
            gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
