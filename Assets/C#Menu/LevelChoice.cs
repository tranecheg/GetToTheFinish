using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChoice : MonoBehaviour
{
	public GameObject start;
	public GameObject menu;
	public GameObject level, shop, settings;
	public GameObject platform1, platform2, player;
	
	public Text numbers, numbers2, numbers3;
	
	
	void Start(){
		numbers.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress") + "%";
		numbers2.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress2") + "%";
		numbers3.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress3") + "%";
	}
	void Update(){
		numbers.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress") + "%";
		numbers2.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress2") + "%";
		numbers3.text = "" + PlayerPrefs.GetFloat("SaveFirstProgress3") + "%";
	}
	
	
   	public void Choise()
	{
		// GetComponent<AudioSource>().Play();
       // PlayerPrefs.DeleteAll();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
		start.SetActive(false);
		menu.SetActive(false);
		level.SetActive(true);
		platform1.SetActive(false);
		platform2.SetActive(false);
		player.SetActive(false);
		
		PlayerPrefs.SetInt("FirstStart",1);
       
    }
	public void Shop(){
		//GetComponent<AudioSource>().Play();
		//SceneManager.LoadScene("Shop");
		start.SetActive(false);
		menu.SetActive(false);
		shop.SetActive(true);
		PlayerPrefs.SetInt("FirstStart", 1);
	}
	
	public void HowToPlay(){
		//GetComponentInParent<AudioSource>().Play();
		//SceneManager.LoadScene("Settings");
		start.SetActive(false);
		menu.SetActive(false);
		settings.SetActive(true);
		PlayerPrefs.SetInt("FirstStart", 1);
	}
	
	
}
