using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    public void playGmae()
    {
        SceneManager.LoadScene(3);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void options()
    {
        SceneManager.LoadScene(2);
    }
}
