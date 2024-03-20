using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnRangeY = 20;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            //randomly generate  animals index and spawn position
            Vector3 spawnPos = new Vector3(Random.Range..........);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20),animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
