using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour
{
    public TextMeshPro Score;
    public int score = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
    }
    private void Update()
    {
        Score.text = score.ToString();
    }
}
