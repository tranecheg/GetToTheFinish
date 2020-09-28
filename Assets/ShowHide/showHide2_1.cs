using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHide2_1 : MonoBehaviour
{
    public GameObject player;
   public GameObject act1, enemy1_1, enemy2_1;
    public GameObject act2, enemy1_2, enemy2_2;
	 public GameObject act3, enemy1_3, enemy2_3;
	  public GameObject act4, enemy1_4, enemy2_4;
	 
  
  
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		//63 enemy
		
		
			//указываем конечную точку		
       if(player.transform.position.x - enemy2_1.transform.position.x>20){
		   act1.SetActive(false);
	   }
	   else{
		   act1.SetActive(true);
	   }
	  
	  //указываем начальную точку	
	    if(enemy1_1.transform.position.x - player.transform.position.x>20){
		   act1.SetActive(false);
	   }
	   
	   	//указываем конечную точку		
       if(player.transform.position.x - enemy2_2.transform.position.x>20){
		   act2.SetActive(false);
	   }
	   else{
		   act2.SetActive(true);
	   }
	  
	  //указываем начальную точку	
	    if(enemy1_2.transform.position.x - player.transform.position.x>20){
		   act2.SetActive(false);
	   }
	   
	   //указываем конечную точку		
       if(player.transform.position.x - enemy2_3.transform.position.x>20){
		   act3.SetActive(false);
	   }
	   else{
		   act3.SetActive(true);
	   }
	  
	  //указываем начальную точку	
	    if(enemy1_3.transform.position.x - player.transform.position.x>20){
		   act3.SetActive(false);
	   }
	   
	   //указываем конечную точку		
       if(player.transform.position.x - enemy2_4.transform.position.x>20){
		   act4.SetActive(false);
	   }
	   else{
		   act4.SetActive(true);
	   }
	  
	  //указываем начальную точку	
	    if(enemy1_4.transform.position.x - player.transform.position.x>20){
		   act4.SetActive(false);
	   }
	   
	   
	   
	   
	   
	   
	   
	   
    }
}
