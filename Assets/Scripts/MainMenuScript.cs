using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Function to be called when the Play button is clicked
    public void PlayButtonClicked()
    {
        // Load the Endless scene
        SceneManager.LoadScene("Endless");
    }

    // Function to be called when the Exit button is clicked
    public void ExitButtonClicked()
    {
        // Exit the application
        Application.Quit();
    }
}
