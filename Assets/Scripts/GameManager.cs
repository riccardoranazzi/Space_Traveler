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

    public GameObject AudioExplosion;

    public GameObject MusicAudio;

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
            AudioExplosion.SetActive(true);
            MusicAudio.SetActive(false);


        } 

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseButtons.SetActive(true);
        MusicAudio.SetActive(false);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseButtons.SetActive(false);
        MusicAudio.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        MusicAudio.SetActive(true);
    }

    public void ReturnToMenu()

    {
        SceneManager.LoadScene(MenuIndex);
    }
}
