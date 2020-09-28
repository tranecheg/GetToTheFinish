using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
	public GameObject menu, start_Game, music, effects, levelOne, mainCamera, beforeGame, mainCameraTwo, levelTwo, enter, exit, levelThree, mainCameraThree;
	public int saveMusic, saveEffects, startGame;
	
	void Start(){
		
		
		
      saveMusic = PlayerPrefs.GetInt("SaveMusic");
	   saveEffects = PlayerPrefs.GetInt("SaveSoundEffects");
	   
	   startGame=0;
	  
	  
		
		if(saveMusic == 0){
				
		music.SetActive(true);
		
						
	}	
	else{
		
	
		music.SetActive(false);
		
	}	
	
	if(saveEffects == 0){
		
		
		
		effects.SetActive(true);
		
				
	}	
	else{
			
	
		
		effects.SetActive(false);
	}
	
	
	
	if(PlayerPrefs.GetInt("FirstStart")==0){
	
	 PlayerPrefs.SetInt("SaveJewels", 5);
                
        PlayerPrefs.SetInt("SaveFlags", 1);
		
		PlayerPrefs.Save();
	}
	else{
		
	}
	
	}
	void Update(){
		
	startGame = PlayerPrefs.GetInt("startGame");
		if(startGame==1){
		levelOne.SetActive(true);
		beforeGame.SetActive(false);
		mainCamera.SetActive(true);
		}
		if(startGame==2){
		levelTwo.SetActive(true);
		beforeGame.SetActive(false);
		mainCameraTwo.SetActive(true);
		mainCameraTwo.GetComponent<AudioListener>().enabled = true;
		mainCamera.GetComponent<Camera>().enabled=false;
		enter.SetActive(false);
		exit.SetActive(false);
		//mainCamera.SetActive(false);
		}
		if(startGame==3){
		levelThree.SetActive(true);
		beforeGame.SetActive(false);
		mainCameraThree.SetActive(true);
		mainCameraThree.GetComponent<AudioListener>().enabled = true;
		mainCamera.GetComponent<Camera>().enabled=false;
		enter.SetActive(false);
		exit.SetActive(false);
		//mainCamera.SetActive(false);
		}
		
	}
   public void StartGame()
    {
        
		menu.SetActive(true);
		start_Game.SetActive(false);
		
       
    }
}
