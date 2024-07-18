using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject star;
    public float height;

    void Start()
    {
        InvokeRepeating("StarSpawn", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        star.transform.position = new Vector3(10, Random.Range(-height, height), 0);
    }

    void StarSpawn()
    {
        Instantiate(star, star.transform.position, star.transform.rotation);
    }
}
