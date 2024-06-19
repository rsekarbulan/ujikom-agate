using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private bool hasSpawned;
    public float timeBetweenSpawns;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasSpawned)
        {
            Spawn();

            hasSpawned = true;
            Invoke(nameof(ResetSpawn), timeBetweenSpawns);
        }
    }

    private void Spawn()
    {
        int random = Random.Range(0, animalPrefabs.Length);

        GameObject animalInstance = Instantiate(animalPrefabs[random]);

        /*Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y, transform.position.z - 1f);
        animalInstance.transform.position = spawnPos;*/
    }

    private void ResetSpawn()
    {
        hasSpawned = false;
    }
}
