using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visible2 : MonoBehaviour
{
	
	public string Visible, Visible2;
	public GameObject go, dieObject;
	//private SpriteRenderer sprite;
	
	public int speedNumber;
	
	
	void OnBecameInvisible(){
		
		
		go.GetComponent<SpriteRenderer>().color = new Color(go.GetComponent<SpriteRenderer>().color.r, go.GetComponent<SpriteRenderer>().color.g,  go.GetComponent<SpriteRenderer>().color.b, 100f);   
	}
	void OnBecameVisible(){
		
			
	}
    void Start()
    {
		
      
    }

    // Update is called once per frame
    void Update()
    {
       speedNumber = PlayerPrefs.GetInt("SpeedNumber");
		if(speedNumber==1){
			go.GetComponent<Animation>().Stop(Visible2);
			go.GetComponent<Animation>().Stop(Visible);
		
		}
		else{
		
		}
			
       go.GetComponent<SpriteRenderer>().color = new Color(go.GetComponent<SpriteRenderer>().color.r, go.GetComponent<SpriteRenderer>().color.g,  go.GetComponent<SpriteRenderer>().color.b, 100f);   
    }
	
	void OnTriggerEnter2D(Collider2D col){
	
	if(col.gameObject.tag == "screen"){
	
	go.GetComponent<Animation>().Play(Visible2);
	
	
	}
	if(col.gameObject.tag == "screen2"){
		go.GetComponent<Animation>().Play(Visible);
	

	
	}
	}
}
