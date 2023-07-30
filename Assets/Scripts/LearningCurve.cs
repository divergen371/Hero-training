using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    void Start()
    {
        int playerLives = 5;

        while (playerLives > 0)
        {
            Debug.Log("player still alive");
            playerLives--;
	}
        Debug.Log("The player's life has ended.");
    }


    void Update()
    {

    }

}
