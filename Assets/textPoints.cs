using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textPoints : MonoBehaviour
{
    [SerializeField]
    private Text points = null;

    public int score;
   // public Transform cube;
  
    void Start()
    {
          
    score = PlayerPrefs.GetInt("SaveScore");
    points.text = "Attempt " + score;
	
	
		
		//if(score==0){
		//points.text = "Attempt " + 1;
		
		//} 

    }

    // Update is called once per frame
    void Update()
    {
       
		
		
		
		score = PlayerPrefs.GetInt("SaveScore");
     points.text = "Attempt " + score;
    }
}
