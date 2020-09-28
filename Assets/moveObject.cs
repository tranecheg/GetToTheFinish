using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = -10f; //10f
	private int speedNumber;
	
	
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
        Vector2 vel = rb.velocity;
		
		 vel.x = 1 * speed;	
		
       
        rb.velocity = vel;
		
       
    
    }
	
	
}
