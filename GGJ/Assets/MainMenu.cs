using Newtonsoft.Json.Bson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject ContUI;
    public void PlayBut()
    {
        SceneManager.LoadScene(1);
    }
    public void Cont()
    {
       ContUI.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void back()
    {
        ContUI.SetActive(false);
    }

}
