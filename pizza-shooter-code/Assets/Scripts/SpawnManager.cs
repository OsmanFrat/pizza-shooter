using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float spawnRangeX = 20;
    public float spawnPosZ = 20;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ = 20;
    public float sideSpawnX = 30;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    void Start() {
        InvokeRepeating("SpawnRandomTopAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomLeftAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomRightAnimal", startDelay, spawnInterval);

    }

    void Update()
    {
        
    }
    void SpawnRandomTopAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
    void SpawnRandomRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));
        
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }


}
