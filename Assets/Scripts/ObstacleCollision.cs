
using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public GameOverUI gameOverUI;
    private bool hasCollided = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && !hasCollided)
        {
            hasCollided = true;

            Debug.Log("GAME OVER!");

            if (gameOverUI != null)
            {
                gameOverUI.ShowGameOver();
            }
            else
            {
                Debug.LogError("UIManager  Game Over UI!");
            }
        }
    }
}