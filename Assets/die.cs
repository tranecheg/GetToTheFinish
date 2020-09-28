
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class die : MonoBehaviour
{
	public GameObject[] saveFlags;
	public GameObject closest;
	public string nearest;
	public float posX, posY;
    public GameObject respawn, player, playerItem;
	public GameObject gm;
	public GameObject animDead1, animDead2,animDead3,animDead4,animDead5,animDead6,animDead7,animDead8;
	public GameObject soundDead, mainMusicOff;
    public Text pointsText;
    public int speedNumber, deletecheck;
	public SpriteRenderer render;
	public GameObject animation, playerScript;
	public Canvas game;
	public float time = 1.4f;
	
	public float targetTime = 3.0f;
	
	public int score, startGame;
	
	
	private bool simpleJump = true;
	private bool objectControl;
	
	private GameObject camera;
	
	void Awake(){
		PlayerPrefs.DeleteKey("SaveScore");
		score = PlayerPrefs.GetInt("SaveScore");
		
		if(score==0){
		score++;
	PlayerPrefs.SetInt("SaveScore", score);
     //   PlayerPrefs.Save();
		}
		
		
		
	}
       
	
	
	void Update(){
		
		speedNumber = PlayerPrefs.GetInt("SpeedNumber");
		saveFlags =  GameObject.FindGameObjectsWithTag("Respawn"); 
		nearest = FindClosestFlag().name;
		gm = GameObject.Find("player");
		simpleJump scriptSJ = gm.GetComponent<simpleJump>();
		objectControl scriptOC = gm.GetComponent<objectControl>();
		
		
		//if(speedNumber == 1){
		if(scriptSJ.enabled ==false){
				
		time-=Time.deltaTime*1.4f;
			if(time < 0){
				
			
		
			//SceneManager.LoadScene("Game");	
			posX = GameObject.Find(nearest).transform.position.x;
			posY = GameObject.Find(nearest).transform.position.y-0.65f;
			
			startGame = PlayerPrefs.GetInt("startGame");
			
			
			
			
			player.transform.position = new Vector3(posX, posY, 0f);
			player.transform.rotation = Quaternion.Euler(0,0,0);
			player.GetComponent<Collider2D>().enabled = true;
		 
		 if(startGame==1){
				camera = GameObject.Find("Main Camera");
				
			camera.transform.position = new Vector3(camera.transform.position.x, posY, camera.transform.position.z);
			}
			else{
				
			}
			if(startGame==2){
				camera = GameObject.Find("Main Camera 2");
				
			camera.transform.position = new Vector3(camera.transform.position.x, posY, camera.transform.position.z);
			}
			else{
				
			}
			if(startGame==3){
				camera = GameObject.Find("Main Camera3");
				
			camera.transform.position = new Vector3(camera.transform.position.x, posY, camera.transform.position.z);
			}
			else{
				
			}
		 
		 render.enabled = true;
			scriptSJ.enabled = true;
			scriptOC.enabled = true;
			player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
			speedNumber = 0;
			PlayerPrefs.SetInt("SpeedNumber", speedNumber);
			score++;
		PlayerPrefs.SetInt("SaveScore", score);		
GetComponentInParent<AudioSource>().Play();		
			}
			
			
		
			
			
		}
		if(scriptSJ.enabled==true){
			animDead1.SetActive(false);
			animDead2.SetActive(false);
			animDead3.SetActive(false);
			animDead4.SetActive(false);
			animDead5.SetActive(false);
			animDead6.SetActive(false);
			animDead7.SetActive(false);
			animDead8.SetActive(false);
			time=1.4f;
			
		
		}
		
		
		
	}
	
	GameObject FindClosestFlag(){
	float distance = Mathf.Infinity;
	Vector3 position = transform.position;
	foreach (GameObject go in saveFlags){
		Vector3 diff = go.transform.position - position;
		float curDistance = diff.sqrMagnitude;
		if(curDistance<distance){
			closest = go;
			distance = curDistance;
		}
	}
	return closest;
}
	
	   
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            restartGame();
			
            // Time.timeScale = 2.1f;
			 render.enabled = false;
	
			
			
			PlayerPrefs.Save();
			player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY;
		//	player.tag = "Untagged";
			
			
			
			
		
		            
        }
		
    }
    public void restartGame()

    {
        
		animDead1.SetActive(true);
		animDead2.SetActive(true);
		animDead3.SetActive(true);
		animDead4.SetActive(true);
		animDead5.SetActive(true);
		animDead6.SetActive(true);
		animDead7.SetActive(true);
		animDead8.SetActive(true);
		
		//soundDead.SetActive(true);
		
		soundDead.GetComponent<AudioSource>().Play();
		mainMusicOff.SetActive(false);
		
	GetComponentInParent<AudioSource>().Stop();
	deletecheck = 0;
	   PlayerPrefs.SetInt("DeleteCheck", deletecheck);
	 PlayerPrefs.Save();
		
		
		gm = GameObject.Find("player");
		simpleJump scriptSJ = gm.GetComponent<simpleJump>();
		scriptSJ.enabled = false;
		objectControl scriptOC = gm.GetComponent<objectControl>();
		scriptOC.enabled = false;
		
		speedNumber = 1;
		PlayerPrefs.SetInt("SpeedNumber", speedNumber);
		
		
		player.GetComponent<Collider2D>().enabled = false;
		
		
	
		 
		
	}
		
		
             
     
	
	 
    

}
