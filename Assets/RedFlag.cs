using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RedFlag : MonoBehaviour
{
    public GameObject respawn, player, panelWin, pause, txt_noFlags, main;
  
    public int jewels, flags, finish, startGame, checkFlags, firstFinishLevelOne, finishFlagsLevelOne, firstFinishLevelTwo, finishFlagsLevelTwo, firstFinishLevelThree;
	public int coin, flag;
	
	[SerializeField]
	private Text coins = null;
	[SerializeField]
	private Text checkPoints = null;
    
	void Start(){
		PlayerPrefs.DeleteKey("CheckFlags");
		//PlayerPrefs.DeleteAll();
		
	}
	void Update(){
		checkFlags = PlayerPrefs.GetInt("CheckFlags");
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            restartGame();
           
			 main.GetComponent<AudioSource>().Pause();
			
		
		
		
		

        }
    }
    public void restartGame()

    {
	checkFlags = PlayerPrefs.GetInt("CheckFlags");
	firstFinishLevelOne = PlayerPrefs.GetInt("FirstFinishLevelOne");
	firstFinishLevelTwo = PlayerPrefs.GetInt("FirstFinishLevelTwo");
	firstFinishLevelThree = PlayerPrefs.GetInt("FirstFinishLevelThree");
	finish = PlayerPrefs.GetInt("Finish");
	
	
        
        
		
		startGame = PlayerPrefs.GetInt("startGame");
		
		if(startGame==1){
			PlayerPrefs.SetFloat("SaveFirstProgress", 100);
		if(firstFinishLevelOne==2){
		
		coin+=0;
		flag+=0;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		txt_noFlags.SetActive(false);
	}

	
	if(firstFinishLevelOne==0 && checkFlags == 0){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=15;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=3;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=15;
		flag+=3;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelOne = 2;
		PlayerPrefs.SetInt("FirstFinishLevelOne", firstFinishLevelOne);
		
		txt_noFlags.SetActive(false);
	}
	
		if(firstFinishLevelOne==0 && checkFlags == 1){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=5;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=1;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=5;
		flag+=1;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelOne = 1;
		PlayerPrefs.SetInt("FirstFinishLevelOne", firstFinishLevelOne);
	}
	
	if(firstFinishLevelOne==1 && checkFlags == 0){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=10;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=2;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=10;
		flag+=2;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelOne = 2;
		PlayerPrefs.SetInt("FirstFinishLevelOne", firstFinishLevelOne);
		
		txt_noFlags.SetActive(false);
	}
	
	
	
	if(firstFinishLevelOne==1 && checkFlags == 1){
		
		coin+=0;
		flag+=0;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		txt_noFlags.SetActive(false);
	}
	
	if(finish>0){
		
	}
		else{
			finish=1;
		}
		
		}
		if(startGame==2){
				PlayerPrefs.SetFloat("SaveFirstProgress2", 100);
			
			if(firstFinishLevelTwo==2){
		
		coin+=0;
		flag+=0;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		txt_noFlags.SetActive(false);
	}

	
	if(firstFinishLevelTwo==0 && checkFlags == 0){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=15;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=3;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=15;
		flag+=3;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelTwo = 2;
		PlayerPrefs.SetInt("FirstFinishLevelTwo", firstFinishLevelTwo);
		
		txt_noFlags.SetActive(false);
	}
	
		if(firstFinishLevelTwo==0 && checkFlags == 1){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=5;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=1;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=5;
		flag+=1;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelTwo = 1;
		PlayerPrefs.SetInt("FirstFinishLevelTwo", firstFinishLevelTwo);
	}
	
	if(firstFinishLevelTwo==1 && checkFlags == 0){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=10;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=2;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=10;
		flag+=2;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelTwo = 2;
		PlayerPrefs.SetInt("FirstFinishLevelTwo", firstFinishLevelTwo);
		
		txt_noFlags.SetActive(false);
	}
	
	
	
	if(firstFinishLevelTwo==1 && checkFlags == 1){
		
		coin+=0;
		flag+=0;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		txt_noFlags.SetActive(false);
	}
	
	if(finish>1){
		
	}
		else{
			finish=2;
		}
			
		}
		if(startGame==3){
			PlayerPrefs.SetFloat("SaveFirstProgress3", 100);
		
		if(firstFinishLevelThree==2){
		
		coin+=0;
		flag+=0;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		txt_noFlags.SetActive(false);
	}

	
	if(firstFinishLevelThree==0 && checkFlags == 0){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=15;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=3;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=15;
		flag+=3;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelThree = 2;
		PlayerPrefs.SetInt("FirstFinishLevelThree", firstFinishLevelThree);
		
		txt_noFlags.SetActive(false);
	}
	
		if(firstFinishLevelThree==0 && checkFlags == 1){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=5;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=1;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=5;
		flag+=1;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelThree = 1;
		PlayerPrefs.SetInt("FirstFinishLevelThree", firstFinishLevelThree);
	}
	
	if(firstFinishLevelThree==1 && checkFlags == 0){
		jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels+=10;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();

        flags = PlayerPrefs.GetInt("SaveFlags");
        flags+=2;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		
		coin+=10;
		flag+=2;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		firstFinishLevelThree = 2;
		PlayerPrefs.SetInt("FirstFinishLevelThree", firstFinishLevelThree);
		
		txt_noFlags.SetActive(false);
	}
	
	
	
	if(firstFinishLevelThree==1 && checkFlags == 1){
		
		coin+=0;
		flag+=0;
		
		coins.text = "" + coin;
		checkPoints.text = "" + flag;
		
		txt_noFlags.SetActive(false);
	}
			
			finish=3;
		}
		PlayerPrefs.SetInt("Finish", finish);
		PlayerPrefs.Save();
		
		
		
		PlayerPrefs.DeleteKey("cameraX");
		PlayerPrefs.DeleteKey("cameraY");
		
		panelWin.SetActive(true);
		pause.SetActive(false);
		
		Time.timeScale = 0;
      
	 
        



    }
	

}
    

