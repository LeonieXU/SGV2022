using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("pirates");
    }

    public void QuitGame(){
        Application.Quit();
    }

    // Update is called once per frame
}
