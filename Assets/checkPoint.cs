using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPoint : MonoBehaviour { 

    private GameMaster gm;
public GameObject flag, GOFlag;


void Start()
{
    gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
	
}
void Update(){
		
}
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
			
			//flag.GetComponent<BoxCollider2D>().enabled = false;
			//GOFlag.GetComponent<BoxCollider2D>().enabled = false;
			
					
			
			
        }
		    }
	
	
	
   
}
