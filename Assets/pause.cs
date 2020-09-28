using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    

    private Text pointsText;
    private int score, saveMusic;
	public GameObject panel, main;
	
	public Image create, delete, pauseButton;
	
  
  




   public void OnMouseOver()
    {
		
	    
        //if(Input.GetMouseButton(0)){
		//if(EventSystem.current.IsPointerOverGameObject()){
			
	
         
                		        
       if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
		 //   GetComponentInParent<AudioSource>().Pause();
		 	create.enabled = false;
			delete.enabled = false;
			pauseButton.enabled = false;
     		panel.SetActive(true);
			//btnPause.interactable = false;
		 main.GetComponent<AudioSource>().Pause();
		
			
			
			
		}
        
		}
	//	}
		
	

		
	
    
	

}
	
	
	
	
    

