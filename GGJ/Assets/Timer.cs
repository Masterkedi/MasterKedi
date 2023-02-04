using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Slider slider;
    float currentTime = 0f;
    float startingTime=120f;
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
                Debug.Log("YOU WÝN");
            }
        }
        
    }
}
