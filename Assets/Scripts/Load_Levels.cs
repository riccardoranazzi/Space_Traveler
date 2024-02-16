using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Levels : MonoBehaviour
{
    public int TutorialScene = 3;

    public int MarsScene = 4;

    public int MoonScene = 5;

    public int JupiterScene = 0;

    public int DarkMoonScene = 0;

    public GameObject ButtonUI;

    public void Button()
    {
        ButtonUI.SetActive(true);
    }

    public void Load_Mars()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(MarsScene);
    }

    public void Load_Moon()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(MoonScene);
    }

    public void Load_Tutorial()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(TutorialScene);
    }

    public void Load_Jupiter()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(5);
    }

    public void Load_Dark_Moon()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(6);
    }

}
