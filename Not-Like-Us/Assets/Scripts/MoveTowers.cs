using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MoveTowers : MonoBehaviour
{
    public float height;
    public float speed;

    public int direction;

    void Start()
    {
        direction = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (direction == 0)  // 0 is up and 1 is down
        {
            if (transform.position.y < height)
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
            else
            {
                transform.position -= Vector3.up * speed * Time.deltaTime;
            }
        }
        else
        {
            if (transform.position.y > -height)
            {
                transform.position -= Vector3.up * speed * Time.deltaTime;
            }
            else
            {
                transform.position += Vector3.up * speed * Time.deltaTime;
            }
        }
    }
}
