using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Meinmenu : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   public void GoToSettingMenu()
   {
        SceneManager.LoadScene("SettingMenu");
   }
   public void GoToMainMenu()
   {
        SceneManager.LoadScene("MainMenu");
   }
   public void QuitGame()
   {
        Application.Quit();
   }
}
