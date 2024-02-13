using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;

    public float restartdelay;

    public GameObject PauseButtons;

    public GameObject completeLevelUI;

    public GameObject gameOverUI;

    public GameObject Pause;

    public int MenuIndex = 1;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Pause.SetActive(false);
    }

    public void EndGame()
    {
        if (GameEnded == false)
        {

            Debug.Log("Game Over!");
            GameEnded = true;
            gameOverUI.SetActive(true);

        }

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseButtons.SetActive(true);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseButtons.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ReturnToMenu()

    {
        SceneManager.LoadScene(MenuIndex);
    }
}
