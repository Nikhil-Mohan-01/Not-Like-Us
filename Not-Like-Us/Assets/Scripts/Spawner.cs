using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject towers;
    public float height;

    void Start()
    {
        InvokeRepeating("Spawn", 1f, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        towers.transform.position = new Vector3(5, Random.Range(-height, height), -2);
    }

    void Spawn()
    {
        Instantiate(towers, towers.transform.position, towers.transform.rotation);
    }
}
