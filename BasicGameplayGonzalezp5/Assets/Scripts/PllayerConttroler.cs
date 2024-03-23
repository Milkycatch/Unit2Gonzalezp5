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
    public float verticalInput;
    public float speed;
    public float xRange;
    public float zRange;
    public GameObject projectilePrefab;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
        horizontalinput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalinput * Time.deltaTime * speed);


        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Shoot food from the Player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
} 
