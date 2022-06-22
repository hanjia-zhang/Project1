using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] BossPrefabs;
    private float spawnRangeX = 4;

    private float startDelay = 15;
    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnRandomEnemy", startDelay);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, BossPrefabs.Length);
        Vector2 spawnPos = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), 4);
        Instantiate(BossPrefabs[enemyIndex], spawnPos, BossPrefabs[enemyIndex].transform.rotation);
    }
}
