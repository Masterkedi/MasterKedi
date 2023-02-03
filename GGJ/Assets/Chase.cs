using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour
{
    public GameObject OrtaTile;
    public float speed;
    private float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance=Vector2.Distance(transform.position,OrtaTile.transform.position);
        Vector2 direction=OrtaTile.transform.position-transform.position;

        transform.position=Vector2.MoveTowards(this.transform.position,OrtaTile.transform.position,speed*Time.deltaTime); 
    }
}
