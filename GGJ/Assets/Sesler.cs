using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesler : MonoBehaviour
{
    void Update()
    {
        if (böceköldürme.pat==true)
        {
            GetComponent<AudioSource>().Play();
            böceköldürme.pat = false;
        }
        
    }
}
