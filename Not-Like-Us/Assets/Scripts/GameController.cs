using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public GameObject spawner;

    public TextMeshProUGUI Score;
    private int score;

    void Start()
    {
        Time.timeScale = 1;
        scoreCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        spawner.SetActive(true);

        score = 0;
        UpdateScoreText();
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        spawner.SetActive(false);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    private void UpdateScoreText()
    {
        Score.text = score.ToString();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }
}
