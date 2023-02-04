using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class böceköldürme : MonoBehaviour

{ 
    
    void OnMouseDown()
    {
        if (İlacsecme.hasSarı==true&&tag=="Bug3")
        {
            Destroy(gameObject);
            
        }
        
        if (İlacsecme.hasMor == true && tag == "Bug1")
        {
            Destroy(gameObject);
        }
        if (İlacsecme.hasYes == true && tag == "Bug2")
        {
            Destroy(gameObject);
        }
    }


}
