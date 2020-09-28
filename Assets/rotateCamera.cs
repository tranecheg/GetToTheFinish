using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCamera : MonoBehaviour
{
    public GameObject camera, player;
	public GameObject enemy1, enemy2, enemy3, platform1, platform2, platform3;
	public GameObject enter, exit, enter1, exit1;
	public string rotCamera, rotCamera1;
	public int cameraRot;
    void Awake()
    {
		cameraRot = PlayerPrefs.GetInt("SaveCameraRotation");
       
    }

    // Update is called once per frame
    void Update()
    {
		
		if(player.transform.position.x < 215){
		camera.transform.rotation = Quaternion.Euler(0,0,0);

		enter.SetActive(true);
		exit.SetActive(true);
		
		enter1.SetActive(false);
		exit1.SetActive(false);	
		
		
		}
        if(player.transform.position.x > 215 && camera.transform.rotation.eulerAngles.z==0){
			camera.GetComponent<Animation>().Play(rotCamera);
		}
		if(camera.transform.rotation.eulerAngles.z==180){
		//camera.GetComponent<Animation>().enabled=false;
		camera.GetComponent<Animation>().Stop(rotCamera);
		enter.SetActive(false);
		exit.SetActive(false);
		
		enter1.SetActive(true);
		exit1.SetActive(true);
		
		
		
		
		
		}
		
		if(player.transform.position.x > 455 && camera.transform.rotation.eulerAngles.z==180){
			camera.GetComponent<Animation>().Play(rotCamera1);
		}
		if(player.transform.position.x > 455 && camera.transform.rotation.eulerAngles.z==0){
			//camera.GetComponent<Animation>().enabled=false;
			camera.GetComponent<Animation>().Stop(rotCamera);
			enter.SetActive(true);
			exit.SetActive(true);
			
			enter1.SetActive(false);
			exit1.SetActive(false);
			
			
		
		
		}
		if(player.transform.position.x < 455){
		//	enemy2.SetActive(true);
		//	platform1.SetActive(true);
		//	platform2.SetActive(true);
		}
    }
}
