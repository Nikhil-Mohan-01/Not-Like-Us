using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject[] clouds;
    public float height;
    public GameObject cloudToSpawn;

    void Start()
    {
        cloudToSpawn = clouds[Random.Range(0, 2)];
        InvokeRepeating("SpawnClouds", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        cloudToSpawn = clouds[Random.Range(0, 2)];
        cloudToSpawn.transform.position = new Vector3(10, Random.Range(-height, height), -1);
    }

    void SpawnClouds()
    {
        Instantiate(cloudToSpawn, cloudToSpawn.transform.position, cloudToSpawn.transform.rotation);
    }
}
