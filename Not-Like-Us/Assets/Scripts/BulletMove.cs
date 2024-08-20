using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    public float speed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
