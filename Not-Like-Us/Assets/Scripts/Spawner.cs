using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] towers;
    public float height;
    private GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
        InvokeRepeating("Spawn", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        //towers.transform.position = new Vector3(5, Random.Range(-height, height), -2);
    }

    void Spawn()
    {
        //Instantiate(towers, towers.transform.position, towers.transform.rotation);
        int currentScore = gameController.GetScore();

        GameObject towerToSpawn;

        if (currentScore < 5)
        {
            towerToSpawn = towers[Random.Range(0, 2)];
        }
        else
        {
            towerToSpawn = towers[2];
        }

        Vector3 spawnPosition = new Vector3(5, Random.Range(-height, height), -2);
        Instantiate(towerToSpawn, spawnPosition, Quaternion.identity);
    }
}
