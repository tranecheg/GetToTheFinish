using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OpenLevelOne : MonoBehaviour
{
	public GameObject locktwo, lockThree, level, menu, block1, block2, player, beforeGame, levelOne, mainCamera, levelChoise, 
	mainCameraTwo, levelTwo, enter, exit, mainCameraThree, levelThree, button2, button3;
	public int finish, startGame, jewels;
	public Text numbers, numbers2,numbers3, textJewels;
	
	void Start(){
		finish = PlayerPrefs.GetInt("Finish");
		
		numbers.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress") + "%";
		numbers2.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress2") + "%";
		numbers3.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress3") + "%";
		
		
		//flags = PlayerPrefs.GetInt("SaveFlags");
       // textFlags.text = "" + flags;
		
		jewels = PlayerPrefs.GetInt("SaveJewels");
        textJewels.text = "" + jewels;
	
	
		
        if(finish>=1){
			locktwo.SetActive(false);
			button2.GetComponent<Button>().enabled=true;
			//PlayerPrefs.SetFloat("SaveFirstProgress2", 100);
		}	
		if(finish>=2){
			lockThree.SetActive(false);
			button3.GetComponent<Button>().enabled=true;
			//PlayerPrefs.SetFloat("SaveFirstProgress3", 100);
		}



    }
	
	void Update(){
		finish = PlayerPrefs.GetInt("Finish");
				
        if(finish>=1){
			locktwo.SetActive(false);
			button2.GetComponent<Button>().enabled=true;
		}	
		if(finish>=2){
			lockThree.SetActive(false);
			button3.GetComponent<Button>().enabled=true;
		}
		numbers.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress") + "%";
		numbers2.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress2") + "%";
		numbers3.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress3") + "%";
		
		jewels = PlayerPrefs.GetInt("SaveJewels");
        textJewels.text = "" + jewels;
		
		startGame = PlayerPrefs.GetInt("startGame");
		if(startGame==1){
		levelOne.SetActive(true);
		beforeGame.SetActive(false);
		mainCamera.SetActive(true);
		mainCamera.GetComponent<AudioListener>().enabled = true;
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
	
    
   	public void LevelOne()
	{
		
		
		PlayerPrefs.DeleteKey("p_x");
		PlayerPrefs.DeleteKey("p_y");
		PlayerPrefs.DeleteKey("SaveCameraRotation");
       // SceneManager.LoadScene("Game");
		
		startGame = PlayerPrefs.GetInt("startGame");
		startGame=1;
		
		levelOne.SetActive(true);
		
		levelChoise.SetActive(false);
		beforeGame.SetActive(false);
		
		mainCamera.SetActive(true);
		mainCamera.GetComponent<AudioListener>().enabled = true;
		
		PlayerPrefs.SetInt("startGame", startGame);
		PlayerPrefs.Save();
		
		 
		
       
    }
	
	public void LevelTwo()
	{
		
		
		PlayerPrefs.DeleteKey("p_x");
		PlayerPrefs.DeleteKey("p_y");
		PlayerPrefs.DeleteKey("SaveCameraRotation");
       // SceneManager.LoadScene("Game");
		
		startGame = PlayerPrefs.GetInt("startGame");
		startGame=2;
		
		levelTwo.SetActive(true);
		
		levelChoise.SetActive(false);
		beforeGame.SetActive(false);
		
		mainCameraTwo.SetActive(true);
		mainCameraTwo.GetComponent<AudioListener>().enabled = true;
		mainCamera.GetComponent<Camera>().enabled=false;
		//mainCamera.SetActive(false);
		enter.SetActive(false);
		exit.SetActive(false);
		PlayerPrefs.SetInt("startGame", startGame);
		PlayerPrefs.Save();
		
		 
		
       
    }
	
	public void LevelThree()
	{
		
		
		PlayerPrefs.DeleteKey("p_x");
		PlayerPrefs.DeleteKey("p_y");
		PlayerPrefs.DeleteKey("SaveCameraRotation");
       // SceneManager.LoadScene("Game");
		
		startGame = PlayerPrefs.GetInt("startGame");
		startGame=3;
		
		levelThree.SetActive(true);
		
		levelChoise.SetActive(false);
		beforeGame.SetActive(false);
		
		mainCameraThree.SetActive(true);
		mainCameraThree.GetComponent<AudioListener>().enabled = true;
		mainCamera.GetComponent<Camera>().enabled=false;
		//mainCamera.SetActive(false);
		enter.SetActive(false);
		exit.SetActive(false);
		PlayerPrefs.SetInt("startGame", startGame);
		PlayerPrefs.Save();
		
		 
		
       
    }
	public void Back(){
		level.SetActive(false);
		menu.SetActive(true);
		block1.SetActive(true);
		block2.SetActive(true);
		player.SetActive(true);
		
	}
	
	
		

}
