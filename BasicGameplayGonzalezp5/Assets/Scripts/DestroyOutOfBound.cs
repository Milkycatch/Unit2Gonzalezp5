using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
   
    private float z_limit = 30.0f;
    private float z_down_offset = -40.0f;


    private float x_limit = 0;
    private float x_offset = 25;

    static int lives = 3;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > z_limit || transform.position.z < z_limit + z_down_offset
            || transform.position.x > x_limit + x_offset || transform.position.x < x_limit - x_offset)
        {
            // we need log lives here
            Destroy(gameObject);
            lives--;
            if (lives < 0)
            {
                Debug.Log("Game Over!");
            }
            else
            {
                Debug.Log($"Lives = {lives}");
            }
        }
    }
}