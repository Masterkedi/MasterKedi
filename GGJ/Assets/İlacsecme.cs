using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class İlacsecme : MonoBehaviour
{
    public static bool hasSarı;
    public static bool hasYes;
    public static  bool hasKır;
    public GameObject BugSarı;
     

    
    void Update()
    { 
        if (Input.GetKey(KeyCode.Alpha1))
        {
            hasYes= false;
            hasKır= false;
            hasSarı= true;
            Debug.Log("Sa");
            
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            
            hasKır = false;
            hasSarı = false;
            hasYes = true;
            Debug.Log("Yes");
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            
            hasSarı = false;
            hasYes = false;
            hasKır = true;
            Debug.Log("Kır");
        }
       
        
    }
     




}
