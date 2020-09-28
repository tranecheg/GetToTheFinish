using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SavePosition : MonoBehaviour
{
  
   
    public int jewels, flags, finishOne, icon;
    public GameObject player, buttonSave, flagIcon, block, camera;
	public float cameraX, cameraY;
	


    // Start is called before the first frame update
    void Start()
    {
		
      flags = PlayerPrefs.GetInt("SaveFlags");
        if(flags<1){
			buttonSave.SetActive(false);
		}	
else{
	buttonSave.SetActive(true);
}
    }

    // Update is called once per frame
    void Update()
    {
		
	cameraX = camera.transform.position.x;
	cameraY = camera.transform.position.y;
	
	
	
		
	flags = PlayerPrefs.GetInt("SaveFlags");
        if(flags<1){
			buttonSave.SetActive(false);
		}	
else{
	buttonSave.SetActive(true);
}	
		icon = PlayerPrefs.GetInt("icon");
		if(icon==1){
		flagIcon.SetActive(true);
		
		}
        
    }
    public void onMouseOver()
    {

	
        
		
		PlayerPrefs.SetFloat("cameraX", camera.transform.position.x);
        PlayerPrefs.SetFloat("cameraY", camera.transform.position.y);
		
        PlayerPrefs.SetFloat("p_x", player.transform.position.x);
        PlayerPrefs.SetFloat("p_y", player.transform.position.y);
       
	    flags = PlayerPrefs.GetInt("SaveFlags");
		if(flags<=0){
			
		}
        else
		{
		flags-=1;
        PlayerPrefs.SetInt("SaveFlags", flags);
        PlayerPrefs.Save();
		}
		
		finishOne = PlayerPrefs.GetInt("FinishLevelOne");
        finishOne=1;
        PlayerPrefs.SetInt("FinishLevelOne", finishOne);
        PlayerPrefs.Save();
       
        
		icon = 1;
		PlayerPrefs.SetInt("icon", icon);
		PlayerPrefs.Save();
		flagIcon.SetActive(true);
		
		
		block.SetActive(false);
		
		if(camera.transform.rotation.eulerAngles.z==180){
			PlayerPrefs.SetInt("SaveCameraRotation", 180);
		}
		if(camera.transform.rotation.eulerAngles.z==0){
			PlayerPrefs.SetInt("SaveCameraRotation", 0);
		}
		
    }
	public void onMouseExit()
    {
		block.SetActive(true);
	}
	
   
    }
   

