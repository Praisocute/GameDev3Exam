
using UnityEngine;

public class TimeItem : MonoBehaviour
{
    public float timeAmount = 3f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameTimer timer = FindFirstObjectByType<GameTimer>();

            if (timer != null)
            {
                timer.AddTime(timeAmount);
                Destroy(gameObject);
            }
        }
    }
}