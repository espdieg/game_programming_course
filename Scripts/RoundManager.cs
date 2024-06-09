using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Assign hat, sand, and jersey prefabs here
    public Transform[] spawnPoints; // Assign possible spawn points for enemies here
    public int initialEnemiesPerRound = 20;
    public int increasePerRound = 5;
    private int currentRound = 0;
    private int enemiesToSpawn;
    private int enemiesSpawned;
    private int enemiesRemaining;

    void Start()
    {
        StartRound();
    }

    void StartRound()
    {
        currentRound++;
        enemiesToSpawn = initialEnemiesPerRound + increasePerRound * (currentRound - 1);
        enemiesRemaining = enemiesToSpawn;
        enemiesSpawned = 0;
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (enemiesSpawned < enemiesToSpawn)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f); // Wait time between spawns, adjust as needed
        }
    }

    void SpawnEnemy()
    {
        int randomEnemyIndex = Random.Range(0, enemyPrefabs.Length);
        int randomSpawnPointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefabs[randomEnemyIndex], spawnPoints[randomSpawnPointIndex].position, Quaternion.identity);
        enemiesSpawned++;
    }

    public void EnemyDestroyed()
    {
        enemiesRemaining--;
        if (enemiesRemaining <= 0 && currentRound < 10)
        {
            StartRound();
        }
    }

    // Call this method when an enemy is destroyed.
    public void OnEnemyDestroyed()
    {
        EnemyDestroyed();
    }
}
