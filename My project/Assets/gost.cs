using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gost :EnemyController
{
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        void OnTriggerEnter2D(Collider2D other)
{
if (other.tag == "Player")
{
FindObjectOfType<PlayerStats>().TakeDamage(damage);
Flip();
}
}

    void FixedUpdate()
    {
    if(sr.flipX == true)
    {
        Debug.Log("going to make ghost move");
        this.GetComponent<Rigidbody2D>().velocity =new Vector2(-maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
        Debug.Log("moving");
    }
else
{
this.GetComponent<Rigidbody2D>().velocity =new Vector2(maxSpeed, this.GetComponent<Rigidbody2D>().velocity.y);
}
}
}
