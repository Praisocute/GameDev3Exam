
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    public TMP_Text winText;

    private bool hasWon = false;

    void Start()
    {
        UpdateScoreUI();

        if (winText != null)
        {
            winText.gameObject.SetActive(false);
        }
    }

    public void AddScore(int amount)
    {
        if (hasWon)
            return;

        score += amount;
        UpdateScoreUI();

        if (score >= 10000)
        {
            hasWon = true;
            Debug.Log("YOU WIN!");

            if (winText != null)
            {
                winText.gameObject.SetActive(true);
                winText.text = "YOU WIN!";
            }

            Time.timeScale = 0f;
        }
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}