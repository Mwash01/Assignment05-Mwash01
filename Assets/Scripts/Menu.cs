using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartNewGame() {
        SceneManager.LoadScene("Main Scene");
    }

    public void RestartGame() {
        Data.scoreNum = 0;
        SceneManager.LoadScene("Intro Scene");
    }

    public void QuitGame() {
        Application.Quit();
        UnityEditor.EditorApplication.ExitPlaymode();
    }

    public void Credits() {
        SceneManager.LoadScene("Credits");
    }

    public void ViewHighscores() {
        SceneManager.LoadScene("Highscores");
    }
}
