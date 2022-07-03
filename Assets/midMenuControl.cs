using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class midMenuControl : MonoBehaviour
{
    public void nextLevel()
    {
        SceneManager.LoadScene(Global.index + 1);
    }
    
    public void quitGame()
    {
        Application.Quit();
    }
}
