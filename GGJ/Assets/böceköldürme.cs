using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class böceköldürme : MonoBehaviour

{ 
    
    void OnMouseDown()
    {
        if (İlacsecme.hasSarı==true&&tag=="Bug1")
        {
            Destroy(gameObject);
            Debug.Log("Sarı VARRRR");
        }
        
        if (İlacsecme.hasYes == true && tag == "Bug2")
        {
            Destroy(gameObject);
        }
        if (İlacsecme.hasKır == true && tag == "Bug3")
        {
            Destroy(gameObject);
        }
    }


}
