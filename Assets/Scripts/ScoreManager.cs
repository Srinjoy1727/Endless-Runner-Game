using UnityEngine;
using TMPro; // Import the TextMeshPro namespace

public class ScoreManager : MonoBehaviour
{
    private int score = 0;
    public TMP_Text scoreText; // Reference to the TextMeshProUGUI text element

    // Public method to increase the score
    public void IncreaseScore(int amount)
    {
        score += amount;
        Debug.Log("Score increased by " + amount + ". Current score: " + score);

        // Update the TextMeshProUGUI text element with the new score
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}
