using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBond = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
     //if an object goes past the player view in the game,remove that object 

        if (transform.position.z < topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > lowerBond)
        
        {
            Debug.Log("game Over");
            Destroy(gameObject);
        }
    }
}
