using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitpoint : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5;

    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        if(Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        var enemy = collision.collider.GetComponent<Hitpoint>();
        if (enemy)
        {
            enemy.TakeHit(1);
        }
        Destroy(gameObject);
    }*/

}
