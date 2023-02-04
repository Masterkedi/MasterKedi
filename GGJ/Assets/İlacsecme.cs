using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class İlacsecme : MonoBehaviour
{
    public static bool hasSarı;
    public static bool hasMor;
    public static  bool hasYes;
    public GameObject BugSarı;
     

    
    void Update()
    { 
        if (Input.GetKey(KeyCode.Alpha1))
        {
            hasMor= false;
            hasYes= false;
            hasSarı= true;
            
            
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            
            hasYes = false;
            hasSarı = false;
            hasMor = true;
            
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            
            hasSarı = false;
            hasMor = false;
            hasYes = true;
            
        }
       
        
    }
     




}
