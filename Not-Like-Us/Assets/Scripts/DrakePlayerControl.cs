using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrakePlayerControl : MonoBehaviour
{
    public Rigidbody2D rb;

    public float jumpForce = 5.0f;

    public bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            isGrounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
