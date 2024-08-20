using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public float MoveTo;
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < MoveTo)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
    }
}
