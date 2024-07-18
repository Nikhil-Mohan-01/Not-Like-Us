using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
    private GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            gameController.AddScore(1);
        }
    }
}
