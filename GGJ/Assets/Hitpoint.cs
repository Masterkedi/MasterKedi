using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hitpoint : MonoBehaviour
{
    public  float Hitpoints;
    public static float MaxHitpoints = 5;
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
    }
   

    public void TakeHit(float damage)
    {
        
        Hitpoints -= damage;
        slider.value = Hitpoints;   
        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
            Debug.Log("YOU LOSE THE GAME");
        }
    }
    
   
   

}
