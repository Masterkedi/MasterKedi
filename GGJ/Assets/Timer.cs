using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{
    public Slider slider;
    float currentTime = 0f;
    float startingTime=50f;
    public static bool comStage;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.winLevel1==true)
        {
            currentTime -= 1 * Time.deltaTime;
            slider.value = currentTime;
            if (currentTime <= 0)
            {
                currentTime = 0;
                comStage= true;
                gameManager.winLevel1 = false;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                
            }
        }
        
    }
}
