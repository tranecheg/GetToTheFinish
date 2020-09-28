using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
	private int deletecheck;
    
    void Start()
    {
        
        if (PlayerPrefs.HasKey("p_x"))
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("p_x"), PlayerPrefs.GetFloat("p_y") + 0.84f, 0f);
        }
		
		

        //transform.position = new Vector2(-7, 0);


    }

    // Update is called once per frame
    void Update()
    {
        //  transform.position = new Vector2(PlayerPrefs.GetFloat("p_x")
        //      , PlayerPrefs.GetFloat("p_y"));
		
        if (PlayerPrefs.HasKey("p_x"))
        {
            transform.position = new Vector3(PlayerPrefs.GetFloat("p_x"), PlayerPrefs.GetFloat("p_y") + 0.84f, 0f);
        }
		
		

    }
    
   
}
