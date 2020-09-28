using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Music : MonoBehaviour
{
    private int saveMusic;
	public GameObject itemOff, mainMusic;

	public Button music;
	
    void Start(){
   saveMusic = PlayerPrefs.GetInt("SaveMusic");
	if(saveMusic == 1){
	itemOff.SetActive(true);
	music.interactable = false;
	mainMusic.GetComponent<AudioSource>().Pause();
	
	}
	if(saveMusic == 0){
	itemOff.SetActive(false);
	music.interactable = true;
	mainMusic.GetComponent<AudioSource>().Play();
	
	}
	     
    } 
	
    void Update(){
	saveMusic = PlayerPrefs.GetInt("SaveMusic");
	if(saveMusic == 1){
	itemOff.SetActive(true);
	music.interactable = false;
	//mainMusic.GetComponent<AudioSource>().Pause();
	
	}
	if(saveMusic == 0){
	itemOff.SetActive(false);
	music.interactable = true;
	//mainMusic.GetComponent<AudioSource>().Play();
	
	}
	 		
    } 
     
   	
	public void MusicOff(){
		saveMusic = PlayerPrefs.GetInt("SaveMusic");
		
		//if(saveMusic == 1 ){
			itemOff.SetActive(true);
			
			//AudioListener.pause = true;
			mainMusic.GetComponent<AudioSource>().Pause();
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
			//AudioListener.pause = false;
			mainMusic.GetComponent<AudioSource>().Play();
			//music.SetActive(true);
			saveMusic = 0;
			PlayerPrefs.SetInt("SaveMusic", saveMusic);
			PlayerPrefs.Save();
				
		//	}
			
			
		
	}
	
	
	
}
