using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class visible : MonoBehaviour
{
	
	public string Visible, Visible2;
	public GameObject go, block1, enemy, block2, block3;
	
	public int ssss = 0;
	public int speedNumber;
	
	void OnBecameInvisible(){
		
		
		 
			block1.SetActive(false);
		
			block2.SetActive(false);
			block3.SetActive(false);
		go.GetComponent<SpriteRenderer>().color = new Color(go.GetComponent<SpriteRenderer>().color.r, go.GetComponent<SpriteRenderer>().color.g,  go.GetComponent<SpriteRenderer>().color.b, 100f);   
		
	}
	void OnBecameVisible(){
			block1.SetActive(true);
			
			block2.SetActive(true);
			block3.SetActive(true);
	
		
	}
    void Start()
    {
		
     // sprite.color = new Color(sprite.color.r, sprite.color.g,  sprite.color.b, 0f);   
    }

    // Update is called once per frame
    void Update()
    {
		speedNumber = PlayerPrefs.GetInt("SpeedNumber");
		if(speedNumber==1){
			go.GetComponent<Animation>().Stop(Visible2);
			go.GetComponent<Animation>().Stop(Visible);
		//enemy.SetActive(false);
		}
		else{
			enemy.SetActive(true);
		}
			
       go.GetComponent<SpriteRenderer>().color = new Color(go.GetComponent<SpriteRenderer>().color.r, go.GetComponent<SpriteRenderer>().color.g,  go.GetComponent<SpriteRenderer>().color.b, 100f);   
    }
	
	void OnTriggerEnter2D(Collider2D col){
	
	if(col.gameObject.tag == "screen"){
	
	go.GetComponent<Animation>().Play(Visible2);
			
	
	}
	if(col.gameObject.tag == "screen2"){
		go.GetComponent<Animation>().Play(Visible);
			block1.SetActive(true);
			enemy.SetActive(true);
			block2.SetActive(true);
			block3.SetActive(true);

	
	}
	}
	void OnTriggerExit2D(Collider2D col){
	if(col.gameObject.tag == "screen"){
		
	}
	}
	
}
