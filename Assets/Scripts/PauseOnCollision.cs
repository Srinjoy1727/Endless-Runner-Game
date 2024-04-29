using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseOnCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Pause the game
            Time.timeScale = 0f;
            Debug.Log("Game Paused");

            // Load the Game Over scene
            SceneManager.LoadScene("Game Over");
        }
    }
}
