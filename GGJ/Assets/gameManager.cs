using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject TileHolder;
    public GameObject []Tiles;
    [SerializeField]int totalTiles=0;
    [SerializeField]int correctTiles=0;
    public static  bool winLevel1;
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
            winLevel1= true;
            
        }
    }
    public void WrongMove()
    {
            correctTiles-= 1;
        
    }

}
