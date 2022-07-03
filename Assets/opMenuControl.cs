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
    
    public void Level2()
    {
        SceneManager.LoadScene(4);
    }

    public void Level3()
    {
        SceneManager.LoadScene(5);
    }

        public void Level4()
    {
        SceneManager.LoadScene(6);
    }

        public void Level5()
    {
        SceneManager.LoadScene(7);
    }

    public void homePage()
    {
        SceneManager.LoadScene(0);
    }
}
