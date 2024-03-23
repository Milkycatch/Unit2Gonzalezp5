using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFoward : MonoBehaviour
{
    // Start is called before the first frame update
    static private int score = 0;
    static private int lives = 3;


    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over!");
            lives = 0;

        }
        Debug.Log("Lives=" + lives);
    }

    public void AddScores(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }
}