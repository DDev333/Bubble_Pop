using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public float timeRemaining = 60.0f;
    public TextMeshProUGUI timerText;
    private bool isGameOver;
    public GameObject gameOverPanel;

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    private void Update() {
        if (!isGameOver)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = "Time: " + Mathf.CeilToInt(timeRemaining);

            if (timeRemaining <= 0)
            {
                isGameOver = true;
                EndGame();
            }
        }
    }

    private void EndGame()
    {
        isGameOver = true;
        timerText.text = "Time: 0";
        ShowGameOverScreen();
    }

    private void ShowGameOverScreen()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }
}
