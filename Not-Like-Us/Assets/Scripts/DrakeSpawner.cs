using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrakeSpawner : MonoBehaviour
{
    public GameObject[] obstacles;
    private GameController gameController;
    public Vector3 spawnPosition;
    public float spawnRate = 5f;

    // Start is called before the first frame update
    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        InvokeRepeating("Spawn", 1f, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn()
    {
        GameObject towerToSpawn;
        towerToSpawn = obstacles[Random.Range(0, obstacles.Length)];
        spawnPosition = new Vector3(13, -3.65f, 0);
        Instantiate(towerToSpawn, spawnPosition, Quaternion.identity);
    }
}
