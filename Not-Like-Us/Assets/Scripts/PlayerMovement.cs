using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float force = 5;
    public Rigidbody2D rb;
    public float rotationSpeed = 500f;
    public float maxRotationAngle = 45f;

    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
        }

        // Get current rotation in degrees
        float rotationZ = transform.rotation.eulerAngles.z;
        // Convert from 0-360 to -180 to 180
        if (rotationZ > 180) rotationZ -= 360;

        if (rb.velocity.y > 0)
        {
            // Rotate upwards (green way)
            rotationZ += rotationSpeed * Time.deltaTime;
        }
        else
        {
            // Rotate downwards (red way)
            rotationZ -= rotationSpeed * Time.deltaTime;
        }

        // Clamp rotation to max angles
        rotationZ = Mathf.Clamp(rotationZ, -135, -45);

        // Apply the clamped rotation
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }
}
