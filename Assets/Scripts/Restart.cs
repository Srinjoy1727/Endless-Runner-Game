using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour
{
    public void RestartGame()
    {
        // Reload the "Endless" scene to restart the game
        SceneManager.LoadScene("Endless");

        // Reset the time scale to normal
        Time.timeScale = 1f;
    }
}
