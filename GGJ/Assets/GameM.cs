using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameM : MonoBehaviour
{
    public GameObject Tile;
    public GameObject[]Tiles;
    [SerializeField] int totaltiles=0;
    void Start()
    {
        totaltiles=Tile.transform.childCount;
        Tiles= new GameObject[totaltiles];

        for (int i = 0; i <Tiles.Length ; i++)
        {
            Tiles[i]=Tile.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
