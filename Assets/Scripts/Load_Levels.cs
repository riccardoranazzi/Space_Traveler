using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Levels : MonoBehaviour
{

    public void Load_Mars()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(3);
    }

    public void Load_Moon()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(4);
    }

    public void Load_Tutorial()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
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
