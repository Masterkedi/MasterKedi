using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject TileHolder;
    public GameObject []Tiles;
    [SerializeField]int totalTiles=0;
    [SerializeField]int correctTiles=0;
    [SerializeField] ParticleSystem Par1;
    [SerializeField] ParticleSystem Par2;
    [SerializeField] ParticleSystem Par3;
    [SerializeField] ParticleSystem Par4;
    [SerializeField] ParticleSystem Par5;
    [SerializeField] ParticleSystem Par6;
    [SerializeField] ParticleSystem Par7;
    [SerializeField] ParticleSystem Par8;
    
    public static  bool winLevel1;
    public static bool Susesi;
    void Start()
    {
        totalTiles= TileHolder.transform.childCount;
        Tiles=new GameObject[totalTiles];
        for (int i = 0; i < Tiles.Length; i++)
        {
            Tiles[i] = TileHolder.transform.GetChild(i).gameObject;
        }
    }
    public void correctMove() 
    {
        correctTiles += 1;
        
        if (correctTiles==totalTiles)
        {
            
            winLevel1 = true;
            Susesi= true;
            Par1.Play();
            Par2.Play();
            Par3.Play();
            Par4.Play();
            Par5.Play();
            Par6.Play();
            Par7.Play();
            


        }
    }
    public void WrongMove()
    {
            correctTiles-= 1;
        
    }
     void Update()
    {
        if (Susesi==true)
        {
            GetComponent<AudioSource>().Play();
            Susesi = false;
        }
        
    }

}
