using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkylineMove : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > -15)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        else
        {
            transform.position = new Vector3(15, -3.72f, -1);
        }
    }
}
