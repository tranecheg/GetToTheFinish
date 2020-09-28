using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PB : MonoBehaviour
{
    public Text Savetext = null;

	public float saveFirst, saveSecond;
	public GameObject player, saveFlag;
	
	public int speedNumber, startGame, spaw, flags, checkFlags;
	
	private Text First;
	private Text Second;
	
	
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
		
		
       
	//level 1
   	startGame = PlayerPrefs.GetInt("startGame");
	if(startGame==1){
		
		if(player.transform.position.x <0){
	Savetext.text = "0%";
	   }
		
	if(player.transform.position.x >0){
	Savetext.text = "" + Mathf.Round((player.transform.position.x*100)/357) + "%";
	   }
	   
	   
	 speedNumber = PlayerPrefs.GetInt("SpeedNumber");
	   	   
	   
	 saveFirst = Mathf.Round((player.transform.position.x*100)/357);
	   
	 if(player.transform.position.x >0){
		
	   
	 saveSecond = Mathf.Round((player.transform.position.x*100)/357);
		 }
		 
	   
	  
	 if(PlayerPrefs.GetFloat("SaveFirstProgress")==0){
	 if(speedNumber == 1){
	   
	   PlayerPrefs.SetFloat("SaveFirstProgress", saveFirst);
	   }
	   }
	   
	   if(PlayerPrefs.GetFloat("SaveFirstProgress")<saveSecond){
		  if(speedNumber == 1){
	   
	   PlayerPrefs.SetFloat("SaveFirstProgress", saveFirst);
	   } 
	   }
	  }
	   //level 2
   	startGame = PlayerPrefs.GetInt("startGame");
	if(startGame==2){
		if(player.transform.position.x <0){
	Savetext.text = "0%";
	   }
	if(player.transform.position.x >0){
	Savetext.text = "" + Mathf.Round((player.transform.position.x*100)/615) + "%";
	   }
	   
	   
	 speedNumber = PlayerPrefs.GetInt("SpeedNumber");
	   	   
	   
	 saveFirst = Mathf.Round((player.transform.position.x*100)/615);
	   
	 if(player.transform.position.x >0){
		
	   
	 saveSecond = Mathf.Round((player.transform.position.x*100)/615);
		 }
		 
	   
	  
	 if(PlayerPrefs.GetFloat("SaveFirstProgress2")==0){
	 if(speedNumber == 1){
	   
	   PlayerPrefs.SetFloat("SaveFirstProgress2", saveFirst);
	   }
	   }
	   
	   if(PlayerPrefs.GetFloat("SaveFirstProgress2")<saveSecond){
		  if(speedNumber == 1){
	   
	   PlayerPrefs.SetFloat("SaveFirstProgress2", saveFirst);
	   } 
	   }
	  }
	  
	   //level 3
   	startGame = PlayerPrefs.GetInt("startGame");
	if(startGame==3){
		if(player.transform.position.x <0){
	Savetext.text = "0%";
	   }
	if(player.transform.position.x >0){
	Savetext.text = "" + Mathf.Round((player.transform.position.x*100)/756) + "%";
	   }
	   
	   
	 speedNumber = PlayerPrefs.GetInt("SpeedNumber");
	   	   
	   
	 saveFirst = Mathf.Round((player.transform.position.x*100)/756);
	   
	 if(player.transform.position.x >0){
		
	   
	 saveSecond = Mathf.Round((player.transform.position.x*100)/756);
		 }
		 
	   
	  
	 if(PlayerPrefs.GetFloat("SaveFirstProgress3")==0){
	 if(speedNumber == 1){
	   
	   PlayerPrefs.SetFloat("SaveFirstProgress3", saveFirst);
	   }
	   }
	   
	   if(PlayerPrefs.GetFloat("SaveFirstProgress3")<saveSecond){
		  if(speedNumber == 1){
	   
	   PlayerPrefs.SetFloat("SaveFirstProgress3", saveFirst);
	   } 
	   }
	  }
		
			
		
    }
	
	public void OnMouseOver(){
		 
		flags = PlayerPrefs.GetInt("SaveFlags");
        flags--;
        PlayerPrefs.SetInt("SaveFlags", flags);
		
		GameObject clone = Instantiate(saveFlag, new Vector3(player.transform.position.x,player.transform.position.y+0.8f,player.transform.position.z), Quaternion.identity);
		
		clone.name = "New" + spaw;
		spaw++;
		
		
		checkFlags = 1;
		PlayerPrefs.SetInt("CheckFlags", checkFlags);
		PlayerPrefs.Save();
		 
		
	}
	public void Down()
    {
		GameObject gm = GameObject.Find("player");
		simpleJump scriptSJ = gm.GetComponent<simpleJump>();
		scriptSJ.enabled = false;
		
		flags = PlayerPrefs.GetInt("SaveFlags");
        flags--;
        PlayerPrefs.SetInt("SaveFlags", flags);
		
		GameObject clone = Instantiate(saveFlag, new Vector3(player.transform.position.x,player.transform.position.y+0.85f,player.transform.position.z), Quaternion.identity);
		
		clone.name = "New" + spaw;
		spaw++;
		
		
		checkFlags = 1;
		PlayerPrefs.SetInt("CheckFlags", checkFlags);
		PlayerPrefs.Save();
	}
	
	  public void Up()
    {
		GameObject gm = GameObject.Find("player");
		simpleJump scriptSJ = gm.GetComponent<simpleJump>();
		scriptSJ.enabled = true;
	}
}
