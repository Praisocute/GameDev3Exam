
using UnityEngine;

public class ScoreItem : MonoBehaviour
{
    public int scoreAmount = 500;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager manager = FindFirstObjectByType<ScoreManager>();

            if (manager != null)
            {
                manager.AddScore(scoreAmount);
                Destroy(gameObject);
            }
        }
    }
}