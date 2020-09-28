using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class newMethodPosition : MonoBehaviour
{
	GameObject[] saveFlags;
	GameObject closest;
	public string nearest;
	public float posX, posY;
	public GameObject player, deleteFlags;
	public int score, flags;
 
 
 
    void Start()
    {
		  saveFlags =  GameObject.FindGameObjectsWithTag("Respawn"); 
		PlayerPrefs.DeleteKey("closestFlag");
    
	
	 
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
    // Update is called once per frame
    void Update()
    {
		flags = PlayerPrefs.GetInt("SaveFlags");
     
		
	saveFlags =  GameObject.FindGameObjectsWithTag("Respawn"); 
       nearest = FindClosestFlag().name;
	 if(saveFlags.Length<=1 && flags==0){
	 deleteFlags.SetActive(false);
	 }
	 else{
		  deleteFlags.SetActive(true);
	 }
	 
	 GameObject delete = GameObject.Find(nearest);
	 GameObject panel = GameObject.Find("PanelWin");
	 if(panel != null && saveFlags.Length>1){
		Destroy(delete);
		}
	 
	   
    }
	public void OnMouseOver()
	{
		
		GameObject delete = GameObject.Find(nearest);
		GameObject del = GameObject.Find("New");
	
		if(saveFlags.Length>1){
		Destroy(delete);
		}
		//Destroy(del);
	
	}
	 public void Down()
    {
		GameObject gm = GameObject.Find("player");
		simpleJump scriptSJ = gm.GetComponent<simpleJump>();
		scriptSJ.enabled = false;
		
		GameObject delete = GameObject.Find(nearest);
	
		if(saveFlags.Length>1){
		Destroy(delete);
		}
	}
	
	  public void Up()
    {
		GameObject gm = GameObject.Find("player");
		simpleJump scriptSJ = gm.GetComponent<simpleJump>();
		scriptSJ.enabled = true;
	}
}
