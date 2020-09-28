using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenPause : MonoBehaviour
{
   public GameObject btn_continue, btn_backAgain, btn_menu;
   public GameObject mainCamera, beginGame, levelOne;
   public GameObject panel, main;
   private int saveMusic, saveEffects;
   
   public Button btnMusic, btnSound;
   
   public int deletecheck, startGame;
   
  
	public GameObject itemOff, music, itemEffects, effects;
	
	    private GameMaster gm;
		
		public Image pauseBTN, create, delete;
	
	
	
     void Start(){
	//	 gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
	
	GameObject player = GameObject.FindGameObjectWithTag("Player");
	player.transform.position = new Vector3(-14f, -0.78f, -0.5f); 
   saveMusic = PlayerPrefs.GetInt("SaveMusic");
   if(saveMusic == 1){
	itemOff.SetActive(true);
	btnMusic.interactable = false;
	GetComponentInParent<AudioSource>().Pause();
	}
	
	saveEffects = PlayerPrefs.GetInt("SaveSoundEffects");
   if(saveEffects == 1){
	itemEffects.SetActive(true); // Картинка
	btnSound.interactable = false;
	effects.SetActive(false); //Звуковая дорожка
	}
	
	
	 mainCamera.GetComponent<AudioListener>().enabled = true;

	     
    } 
	
    void Update(){
	 saveMusic = PlayerPrefs.GetInt("SaveMusic");
   if(saveMusic == 1){
	itemOff.SetActive(true);
	btnMusic.interactable = false;
	GetComponentInParent<AudioSource>().Pause();
	}
	
	saveEffects = PlayerPrefs.GetInt("SaveSoundEffects");
   if(saveEffects == 1){
	itemEffects.SetActive(true);
	btnSound.interactable = false;
	effects.SetActive(false);
	}
	 	else{
			effects.SetActive(true);
		}

	
    } 
     
     
	
    
   
   public void Continue(){
	   	   
	   Time.timeScale = 1;
	    		
	   panel.SetActive(false);
	   
	saveMusic = PlayerPrefs.GetInt("SaveMusic");
	if(saveMusic == 0){
	//itemOff.SetActive(true);
	 main.GetComponent<AudioSource>().Play();
	AudioListener.pause = false;
	}
	//btnPause.interactable = true;
		
		pauseBTN.enabled = true;
		create.enabled = true;
		delete.enabled = true;
	}
	   
	   
	   
   
   public void BackAgain(){
	   Time.timeScale = 1;
	       
	   panel.SetActive(false);
	   
	   AudioListener.pause = false;
	   
	   
	   SceneManager.LoadScene("Game");
	   
	  
	   
	   PlayerPrefs.DeleteKey("p_x");
		PlayerPrefs.DeleteKey("p_y");
		
		deletecheck =1;
		PlayerPrefs.SetInt("DeleteCheck", deletecheck);
		PlayerPrefs.Save();
		
		//gm.lastCheckPointPos = new Vector3(-14, -0.78f, -0.5f);
		
		PlayerPrefs.DeleteKey("SaveCameraRotation");
		 
		//PlayerPrefs.DeleteKey("SaveScore");
	   
	   PlayerPrefs.DeleteKey("CheckFlags");
	   	   	   
   }
   public void Menu(){
	   SceneManager.LoadScene("Game");
	   Time.timeScale = 1;
	  // AudioListener.pause = false;
      
	//   panel.SetActive(false);
	   
	   //SceneManager.LoadScene("Start");
	 // levelOne.SetActive(false);
	//   mainCamera.SetActive(false);
	//mainCamera.GetComponent<AudioListener>().enabled = false;
	main.GetComponent<AudioSource>().enabled = true;
	//  beginGame.SetActive(true);
	   
	  
	 
	   
	  
		startGame=0;
		PlayerPrefs.SetInt("startGame", startGame);
		
		PlayerPrefs.DeleteKey("p_x");
		PlayerPrefs.DeleteKey("p_y");
		
		deletecheck =1;
		PlayerPrefs.SetInt("DeleteCheck", deletecheck);
		PlayerPrefs.Save();
		
		//gm.lastCheckPointPos = new Vector3(-9, -0.78f, -0.5f);
		 
		PlayerPrefs.DeleteKey("SaveCameraRotation");
		//PlayerPrefs.DeleteKey("SaveScore");
		
		
		
		
		
		
   }
   
	
	public void MusicOff(){
		saveMusic = PlayerPrefs.GetInt("SaveMusic");
		
		//if(saveMusic == 1 ){
			itemOff.SetActive(true);
			btnMusic.interactable = false;
			//AudioListener.pause = true;
			//music.SetActive(false);
			saveMusic = 1;
			PlayerPrefs.SetInt("SaveMusic", saveMusic);
			PlayerPrefs.Save();
				
		//	}
			
			
		
	}
	
	public void MusicOn(){
		saveMusic = PlayerPrefs.GetInt("SaveMusic");
		
	//	if(saveMusic == 0){
			itemOff.SetActive(false);
			btnMusic.interactable = true;
			//AudioListener.pause = false;
			//music.SetActive(true);
			saveMusic = 0;
			PlayerPrefs.SetInt("SaveMusic", saveMusic);
			PlayerPrefs.Save();
				
		//	}
			
			
		
	}
	public void EffectsOff(){
		saveEffects = PlayerPrefs.GetInt("SaveSoundEffects");
		
		//if(saveMusic == 1 ){
			itemEffects.SetActive(true);
			btnSound.interactable = false;
			//AudioListener.pause = true;
			//music.SetActive(false);
			saveEffects = 1;
			PlayerPrefs.SetInt("SaveSoundEffects", saveEffects);
			PlayerPrefs.Save();
				
		//	}
			
			
		
	}
	
	public void EffectsOn(){
		saveEffects = PlayerPrefs.GetInt("SaveSoundEffects");
		
	//	if(saveMusic == 0){
			itemEffects.SetActive(false);
			btnSound.interactable = true;
			//AudioListener.pause = false;
			//music.SetActive(true);
			saveEffects = 0;
			PlayerPrefs.SetInt("SaveSoundEffects", saveEffects);
			PlayerPrefs.Save();
				
		//	}
			
			
		
	}
	
	
}
