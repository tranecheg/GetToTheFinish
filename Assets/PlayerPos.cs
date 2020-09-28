using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;
	private int deleteCheck;
    void Start()
    {
       gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
	   deleteCheck = PlayerPrefs.GetInt("DeleteCheck");
	   
	   if(deleteCheck>0){
		 PlayerPrefs.DeleteKey("icon");  
	   }
	   
        else{
			
			transform.position = gm.lastCheckPointPos;
		}			//если начал заново, то убрать эту строку
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
