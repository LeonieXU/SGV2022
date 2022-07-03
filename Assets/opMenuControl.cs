using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class opMenuControl : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene(3);
    }
    // public void Level2(
    //     {

    //     }
    // )
    public void homePage()
    {
        SceneManager.LoadScene(0);
    }
}
