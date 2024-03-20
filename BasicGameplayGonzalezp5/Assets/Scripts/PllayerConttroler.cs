using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PllayerConttroler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float horizontalinput;
    public float speed = 10.0f;
    public float xRange =10;

    public GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(horizontalinput -xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange) 
        { 
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab,transform.position, projectilePrefab.transform.rotation);
        }
    }  
}
