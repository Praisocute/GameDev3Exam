
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public float timeLeft = 30f;
    public TMP_Text timerText;
    public GameOverUI gameOverUI;

    private bool gameOver = false;

    void Update()
    {
        if (gameOver)
            return;

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0f)
        {
            timeLeft = 0f;
            gameOver = true;

            if (timerText != null)
            {
                timerText.text = "TIME UP!";
            }

            Debug.Log("GAME OVER!");

            if (gameOverUI != null)
            {
                gameOverUI.ShowGameOver();
            }
            else
            {
                Time.timeScale = 0f;
            }

            return;
        }

        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.CeilToInt(timeLeft);
        }
    }

    public void AddTime(float amount)
    {
        if (gameOver)
            return;

        timeLeft += amount;

        if (timeLeft < 0f)
        {
            timeLeft = 0f;
        }

        if (timerText != null)
        {
            timerText.text = "Time: " + Mathf.CeilToInt(timeLeft);
        }
    }
}