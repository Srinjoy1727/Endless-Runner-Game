using UnityEngine;

public class Coin : MonoBehaviour
{
    private AudioSource audioSource;
    public ScoreManager scoreManager; // Reference to ScoreManager script

    private void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();

        // Debug Log to check if Start method is getting called
        Debug.Log("Start method called.");

        // Ensure the AudioSource is not null
        if (audioSource == null)
        {
            Debug.LogError("AudioSource is not assigned!");
        }

        // Find ScoreManager object if not assigned
        if (scoreManager == null)
        {
            scoreManager = FindObjectOfType<ScoreManager>();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        // Check if the colliding object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Debug Log to check if OnTriggerEnter method is getting called
            Debug.Log("Player collided with coin.");

            // Play the coin sound
            if (audioSource != null)
            {
                audioSource.Play(); // Assuming the AudioSource is configured to play automatically when Play() is called
            }
            // Destroy the coin object (this script is attached to)
            Destroy(gameObject);

            // Increase score by 2
            if (scoreManager != null)
            {
                scoreManager.IncreaseScore(2);
            }
        }
    }
}