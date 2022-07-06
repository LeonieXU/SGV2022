using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuiGame : MonoBehaviour
{
    public void home()
    {
        SceneManager.LoadScene(3);
    }
    public void QuiteGame()
    {
        Application.Quit();
    }
}
