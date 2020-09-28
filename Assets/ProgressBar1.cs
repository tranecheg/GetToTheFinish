using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[ExecuteInEditMode()]

public class ProgressBar1 : MonoBehaviour
{
    public int maximum;
	public float current;
	public Image mask;
	float time = 1.5f;
	
	public GameObject player;
	
	void Awake(){
   
  
	
   
	}

    // Update is called once per frame
    void Update()
    {
		current = player.transform.position.x;
        GetCurrentFill();
		
    }
	void GetCurrentFill(){
		float fillAmount = (float)current/(float)maximum;
		mask.fillAmount = fillAmount;
		
		
		
		
	}
	
}
