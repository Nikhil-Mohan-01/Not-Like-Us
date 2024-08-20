using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject scoreCanvas;
    public GameObject spawner;

    public TextMeshProUGUI Score;
    private int score;

    public GameObject KendrickPlayer;
    public GameObject NikhilPlayer;

    void Start()
    {
        Time.timeScale = 1;
        scoreCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
        spawner.SetActive(true);

        score = 0;
        UpdateScoreText();

        if (CharacterSelection.selectedCharacter == "Kendrick")
        {
            Instantiate(KendrickPlayer, new Vector3(0, 0, -2), Quaternion.identity);
        }
        else if (CharacterSelection.selectedCharacter == "Nikhil")
        {
            Instantiate(NikhilPlayer, new Vector3(0, 0, -2), Quaternion.identity);
        }
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
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

    public int GetScore()
    {
        return score;
    }
}
