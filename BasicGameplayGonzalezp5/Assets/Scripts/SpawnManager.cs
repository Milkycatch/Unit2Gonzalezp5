using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animals;
    public GameObject[] sideAnimals;
    private float xRange = 20;
    private float zRange = 20;

    private float spawnDelay = 2f;
    private float spawnInterval = 1.5f;



    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("AnimalSpawnPos", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalLeft", spawnDelay, spawnInterval);
        InvokeRepeating("SpawnAnimalRight", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AnimalSpawnPos()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), 0, zRange);
        int animalIndex = Random.Range(0, animals.Length);
        Instantiate(animals[animalIndex], spawnPos, animals[animalIndex].transform.rotation);
    }

    void SpawnAnimalLeft()
    {
        Vector3 spawnPos = new Vector3(-25, 0, Random.Range(5, 15));
        int animalIndex = Random.Range(0, animals.Length);
        Instantiate(animals[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.right));
    }

    void SpawnAnimalRight()
    {
        Vector3 spawnPos = new Vector3(25, 0, Random.Range(5, 15));
        int animalIndex = Random.Range(0, animals.Length);
        Instantiate(animals[animalIndex], spawnPos, Quaternion.LookRotation(Vector3.left));
    }
}
