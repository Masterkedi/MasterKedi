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

        Vector2 Rot = new Vector2(OrtaTile.transform.position.x, OrtaTile.transform.position.y);
        Vector2 lookDir = Rot - GetComponent<Rigidbody2D>().position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, OrtaTile.transform.position);
        Vector2 direction = OrtaTile.transform.position - transform.position;


        transform.position = Vector2.MoveTowards(this.transform.position, OrtaTile.transform.position, speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "OrtaTile")
        {
            var healthComponent = collision.GetComponent<Hitpoint>();
            if(healthComponent != null)
            {
                healthComponent.TakeHit(1);
            }
            Destroy(gameObject);
        }
        
    }
}
