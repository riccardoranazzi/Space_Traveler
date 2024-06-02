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

    public AudioSource MusicAudio;

    public AudioSource SuccessAudio;

    public int MenuIndex = 1;


    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        Pause.SetActive(false);
        MusicAudio.Stop();
        SuccessAudio.Play();

    }

    public void EndGame()
    {
        if (GameEnded == false)
        {

            Debug.Log("Game Over!");
            GameEnded = true;
            gameOverUI.SetActive(true);
            AudioExplosion.SetActive(true);
            MusicAudio.Stop();

        } 

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        PauseButtons.SetActive(true);
        MusicAudio.Pause();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        PauseButtons.SetActive(false);
        MusicAudio.UnPause();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        MusicAudio.Play();
    }

    public void ReturnToMenu()

    {
        SceneManager.LoadScene(MenuIndex);
    }
}
