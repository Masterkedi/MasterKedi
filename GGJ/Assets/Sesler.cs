using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sesler : MonoBehaviour
{
    void Update()
    {
        if (b�cek�ld�rme.pat==true)
        {
            GetComponent<AudioSource>().Play();
            b�cek�ld�rme.pat = false;
        }
        
    }
}
