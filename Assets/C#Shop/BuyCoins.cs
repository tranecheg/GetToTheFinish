using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;
using UnityEngine.Purchasing;

public class BuyCoins : MonoBehaviour
{
    
    private int jewels, flags;
	public GameObject shop, menu, lessJewels;
	public Text textFlags, textJewels;

	
	
	
	void Start(){
	
		
		
		flags = PlayerPrefs.GetInt("SaveFlags");
        textFlags.text = "" + flags;
		
		jewels = PlayerPrefs.GetInt("SaveJewels");
        textJewels.text = "" + jewels;
	}
	void Update(){
		if (Input.GetMouseButtonDown(0) && lessJewels !=null)
			lessJewels.SetActive(false);
    
	}
	
	
    
    public void CoinsForFlag()
    {
        
        jewels = PlayerPrefs.GetInt("SaveJewels");
		flags = PlayerPrefs.GetInt("SaveFlags");
        if(jewels<5){
			lessJewels.SetActive(true);
		}
		else{
			flags++;
			jewels-=5;
			PlayerPrefs.SetInt("SaveJewels", flags);
			PlayerPrefs.SetInt("SaveFlags", flags);
			textFlags.text = "" + flags;
			textJewels.text = "" + jewels;
		}
        PlayerPrefs.SetInt("SaveJewels", jewels);
      
        
    }
	
	
	public void Back(){
		
		//SceneManager.LoadScene("Menu");
			  	
		menu.SetActive(true);
		shop.SetActive(false);
		
	}
	
	
}
