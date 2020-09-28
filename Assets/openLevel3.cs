using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openLevel3 : MonoBehaviour
{
	public GameObject levelTwo, levelThree, mainCamera, mainCameraTwo, mainCameraThree, enter, exit;
	public int startGame;
	
    
	public void level3(){
			
		PlayerPrefs.DeleteKey("p_x");
		PlayerPrefs.DeleteKey("p_y");
		PlayerPrefs.DeleteKey("SaveCameraRotation");
       
		
		startGame = PlayerPrefs.GetInt("startGame");
		startGame=3;
		
		levelTwo.SetActive(false);
		levelThree.SetActive(true);
		
		Time.timeScale = 1;
		
		
		mainCameraThree.SetActive(true);
		mainCameraThree.GetComponent<AudioListener>().enabled = true;
		mainCameraTwo.SetActive(false);
		mainCamera.GetComponent<Camera>().enabled=false;
	
		enter.SetActive(false);
		exit.SetActive(false);
		PlayerPrefs.SetInt("startGame", startGame);
		PlayerPrefs.Save();
		
		AudioListener.pause = false;
	}
}
