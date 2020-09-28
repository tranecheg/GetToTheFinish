using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[ExecuteInEditMode()]

public class progressBar : MonoBehaviour
{
   public int maximum;
	public float current;
	public Image mask;
	public int startGame;
	
	
	
	void Awake(){
   
  
	
   
	}

    // Update is called once per frame
    void Update()
    {
		
        GetCurrentFill();
		
    }
	void GetCurrentFill(){
		float fillAmount = (float)current/(float)maximum;
		mask.fillAmount = fillAmount;
		
			
		current = PlayerPrefs.GetFloat("SaveFirstProgress");
		
	
	
		
				
	}
}
