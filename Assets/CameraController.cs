using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public float speed = 0f;
     public float offsetX = 0f;
    public float offsetY = 1.3f;
     public float maxX = 75f;
    public float minY = 0f;
     public float maxY = 20f;
    private bool lockY, lockX = false;
    private bool alwaysFollow = false;

    private float targetY, targetX;
    private Vector3 target;
	
	public int camUp, startGame;
	public GameObject player, camera;
	
	public float cameraX, cameraY;
	
	
   
	
	void Awake(){
	
	}
    
void Start(){
	PlayerPrefs.DeleteKey("CamMove");
	
	cameraX = PlayerPrefs.GetFloat("p_x");
	cameraY = PlayerPrefs.GetFloat("p_y");

	camera.transform.position = new Vector3(cameraX, cameraY, camera.transform.position.z);
	
	
	//level3
	startGame = PlayerPrefs.GetInt("startGame");
	if(startGame==3){
	Matrix4x4 mat = Camera.main.projectionMatrix;
	mat *=Matrix4x4.Scale(new Vector3(-1,1,1));
	Camera.main.projectionMatrix = mat;
	}
	
	
}
    void LateUpdate () {

      if(Input.GetKeyDown(KeyCode.Escape)){
		  Application.Quit();
	  }

     

camUp = PlayerPrefs.GetInt("CamMove");
target = player.transform.position;



if(player.transform.position.y - camera.transform.position.y>3){
	speed = 0.8f;
}
if(player.transform.position.y - camera.transform.position.y<1){
	speed = 0f;
}

if(player.transform.position.y - camera.transform.position.y<-1){
	speed = 0.8f;
}

	

        float targetX = lockX ? 0f : Mathf.Clamp(target.x, 0f, maxX - offsetX);
        float targetY = lockY ? 0f : Mathf.Clamp(target.y, minY, maxY - offsetY);
        transform.position = new Vector3(targetX + offsetX /*Mathf.Lerp(transform.position.x, targetX + offsetX, speed * 2 * Time.deltaTime)*/,
                                         Mathf.Lerp(transform.position.y, targetY + offsetY, speed * Time.deltaTime), -10f);
	}
}
