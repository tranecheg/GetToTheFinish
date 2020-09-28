using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectControl : MonoBehaviour
{
    Rigidbody2D rb;
    float speed = 10.5f; //10.5f
	private int speedNumber;
	public Animator anim;
	public GameObject player;
	
	public float targetTime=0f;
	
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
		speedNumber = 0;
		PlayerPrefs.SetInt("SpeedNumber", speedNumber);
		PlayerPrefs.Save();
		
		
    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		
		
		
		speedNumber = PlayerPrefs.GetInt("SpeedNumber");
		anim = GetComponent<Animator>();
        Vector2 vel = rb.velocity;
		
		//if(speedNumber <1){
		
		targetTime -=Time.deltaTime*6f;
		if(targetTime< 0.0f){
		player.GetComponent<objectControl>().enabled = true;
		
		vel.x = 1 * speed;
		//}
		 
		

		}
		
       
        rb.velocity = vel;
		
      
    
    }
	

}
