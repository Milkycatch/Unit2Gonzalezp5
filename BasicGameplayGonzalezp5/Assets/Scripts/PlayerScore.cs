using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerScore : MonoBehaviour
{ 
public int live = 3;
public int score = 0;

public GameObject player;
// Start is called before the first frame update
void Start()
{
    player = GameObject.Find("Player");
    Debug.Log("Live = " + live);
    Debug.Log("Score = " + score);
}

// Update is called once per frame
void Update()
{
}

public void AnimalFeed()
{
    score++;
    Debug.Log("Score = " + score);
}

public void AnimalHit()
{
    if (live > 0)
    {
        live--;
        Debug.Log("Live = " + live);
    }

    else if (live < 1)
    {
        Destroy(player);
        Debug.Log("Game Over!");
    }
}
}
