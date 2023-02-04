using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject TileHolder;
    public GameObject []Tiles;
    [SerializeField]int totalTiles=0;
    [SerializeField]int correctTiles=0;
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
        Debug.Log("hahaha");
        if (correctTiles==19)
        {
            Debug.Log("yOU W�N");
        }
    }
    public void WrongMove()
    {
            correctTiles-= 1;
        Debug.Log("WWWWW");
    }

}
