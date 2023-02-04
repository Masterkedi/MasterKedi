using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public GameObject GameOverUI;
    public GameObject GameOver2UI;
    void Update()
    {
        if (Hitpoint.loseGame==true)
        {
                GameOver();
            
           

        }
    }
    public void GameOver()
    {
        GameOverUI.SetActive(true);
        GameOver2UI.SetActive(true);
        Time.timeScale = 0f;
        
    }
    public void Restart()
    {
        
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;

    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }

}
