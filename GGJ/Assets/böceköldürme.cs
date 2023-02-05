using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class böceköldürme : MonoBehaviour

{
    public static bool pat;
    

    void OnMouseDown()
    {
        if (İlacsecme.hasSarı==true&&tag=="Bug3")
        {
            pat= true;
            Destroy(gameObject);
            
        }
        
        if (İlacsecme.hasMor == true && tag == "Bug1")
        {
            pat= true;
            Destroy(gameObject);
        }
        if (İlacsecme.hasYes == true && tag == "Bug2")
        {
            pat= true;
            Destroy(gameObject);
        }
    }


}
