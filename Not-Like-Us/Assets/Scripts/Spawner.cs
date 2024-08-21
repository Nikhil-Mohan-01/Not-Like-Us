using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] towers;
    public float height;
    private GameController gameController;
    public Vector3 spawnPosition;

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
            spawnPosition = new Vector3(5, Random.Range(-height, height), -2);
        }
        else if (currentScore < 10)
        {
            towerToSpawn = towers[2];
            spawnPosition = new Vector3(5, Random.Range(-height, height), -2);
        }
        else if (currentScore < 15)
        {
            towerToSpawn = towers[Random.Range(3, 5)];

            if (towerToSpawn == towers[3])
            {
                spawnPosition = new Vector3(5, -6, -2);
                Debug.Log("Bottom Spawn");
            }
            else
            {
                spawnPosition = new Vector3(5, 6, -2);
                Debug.Log("Top Spawn");
            }

        }
        else if (currentScore < 20)
        {
            towerToSpawn = towers[5];
            spawnPosition = new Vector3(5, Random.Range(-height, height), -2);
        }
        else if (currentScore < 25)
        {
            towerToSpawn = towers[6];
            spawnPosition = new Vector3(5, Random.Range(-height, height), -2);
        }
        else
        {
            towerToSpawn = towers[Random.Range(0, 7)];
            spawnPosition = new Vector3(5, Random.Range(-height, height), -2);
        }

        Instantiate(towerToSpawn, spawnPosition, Quaternion.identity);

    }
}
