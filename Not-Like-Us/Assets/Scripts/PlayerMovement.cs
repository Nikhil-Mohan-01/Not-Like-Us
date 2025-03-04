using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameController gameContoller;
    public float force = 5;
    public Rigidbody2D rb;
    public float rotationSpeed = 500f;
    public float maxRotationAngle = 45f;

    private AudioManager audioManager;

    public GameObject bullet;
    public float shootDelay = 1.0f;
    private bool canShoot = true;

    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();

        audioManager = FindObjectOfType<AudioManager>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * force;
            audioManager.PlayRandomClip();
        }

        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(1)) && canShoot )
        {
            StartCoroutine(ShootWithDelay());
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HighTower" || collision.gameObject.tag == "LowTower" || collision.gameObject.tag == "Ground" || collision.gameObject.tag == "Target")
        {
            GameObject.Find("Game Controller").GetComponent<GameController>().GameOver();
        }
    }

    private IEnumerator ShootWithDelay()
    {
        canShoot = false;
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, -1), Quaternion.identity);
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }
}
