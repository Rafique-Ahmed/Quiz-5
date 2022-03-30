using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    //Script of spawning enemies randomly
    public GameObject[] EnemyPrefabs;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy",startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SpawnRandomEnemy() {
          // Generate Ramdom Animals
            Vector3 spawnPos = new Vector3(5,0,0);
            int EnemyIndex = Random.Range(0, EnemyPrefabs.Length);
            Instantiate(EnemyPrefabs[EnemyIndex], spawnPos, EnemyPrefabs[EnemyIndex].transform.rotation);
    }
}
