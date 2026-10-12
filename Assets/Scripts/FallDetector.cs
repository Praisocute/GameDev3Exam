
using UnityEngine;

public class FallDetector : MonoBehaviour
{
    public Transform player;
    public GameOverUI gameOverUI;
    public float fallHeight = -5f;

    private bool hasFallen = false;

    void Update()
    {
        if (hasFallen || player == null)
            return;

        if (player.position.y < fallHeight)
        {
            hasFallen = true;
            Debug.Log("GAME OVER! Player fell.");

            gameOverUI.ShowGameOver();
        }
    }
}