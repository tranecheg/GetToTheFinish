using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoundEffects : MonoBehaviour
{
    private int saveMusic;
	public GameObject itemOff, soundEffects;

	public Button effects;
	
    void Start(){
   saveMusic = PlayerPrefs.GetInt("SaveSoundEffects");
	if(saveMusic == 1){
	itemOff.SetActive(true);
	effects.interactable = false;
	soundEffects.SetActive(false);
	
	}
	if(saveMusic == 0){
	itemOff.SetActive(false);
	effects.interactable = true;
	soundEffects.SetActive(true);
	
	}
	     
    } 
	
    void Update(){
	saveMusic = PlayerPrefs.GetInt("SaveSoundEffects");
	if(saveMusic == 1){
	itemOff.SetActive(true);
	effects.interactable = false;
	//mainMusic.GetComponent<AudioSource>().Pause();
	
	}
	if(saveMusic == 0){
	itemOff.SetActive(false);
	effects.interactable = true;
	//mainMusic.GetComponent<AudioSource>().Play();
	
	}
	 		
    } 
     
   	
	public void SoundOff(){
		saveMusic = PlayerPrefs.GetInt("SaveSoundEffects");
		
		//if(saveMusic == 1 ){
			itemOff.SetActive(true);
			
			//AudioListener.pause = true;
			soundEffects.SetActive(false);
			//music.SetActive(false);
			saveMusic = 1;
			PlayerPrefs.SetInt("SaveSoundEffects", saveMusic);
			PlayerPrefs.Save();
				
		//	}
			
			
		
	}
	
	public void SoundOn(){
		saveMusic = PlayerPrefs.GetInt("SaveSoundEffects");
		
	//	if(saveMusic == 0){
			itemOff.SetActive(false);
			//AudioListener.pause = false;
			soundEffects.SetActive(true);
			//music.SetActive(true);
			saveMusic = 0;
			PlayerPrefs.SetInt("SaveSoundEffects", saveMusic);
			PlayerPrefs.Save();
				
		//	}
			
			
		
	}
	
	
}
