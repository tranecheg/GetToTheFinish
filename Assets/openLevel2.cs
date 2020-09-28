using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openLevel2 : MonoBehaviour
{
	public GameObject levelOne, levelTwo, mainCamera, mainCameraTwo, enter, exit;
	public int startGame;
	
    
	public void level2(){
		
		//SceneManager.LoadScene("Game");
		
		PlayerPrefs.DeleteKey("p_x");
		PlayerPrefs.DeleteKey("p_y");
		PlayerPrefs.DeleteKey("SaveCameraRotation");
       
		
		startGame = PlayerPrefs.GetInt("startGame");
		startGame=2;
		
		levelOne.SetActive(false);
		levelTwo.SetActive(true);
		
		Time.timeScale = 1;
		
		
		mainCameraTwo.SetActive(true);
		mainCameraTwo.GetComponent<AudioListener>().enabled = true;
		mainCamera.GetComponent<Camera>().enabled=false;
		mainCamera.GetComponent<AudioListener>().enabled = false;
	
		enter.SetActive(false);
		exit.SetActive(false);
		PlayerPrefs.SetInt("startGame", startGame);
		PlayerPrefs.Save();
		AudioListener.pause = false;
		
		
		
	}
}
