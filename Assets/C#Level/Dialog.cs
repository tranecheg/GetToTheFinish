using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
	public GameObject dialog_show;
	public GameObject lock_two;
	public GameObject lessJewels;
	public int jewels, finish;

	
    // Start is called before the first frame update
    void Start()
    {
      //PlayerPrefs.DeleteKey("Finish");  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && lessJewels !=null)
			lessJewels.SetActive(false);
    }
	public void OpenLevel(){
		if(lock_two != null){
			dialog_show.SetActive(true);
		}
		
	}
	public void Yes(){
		jewels = PlayerPrefs.GetInt("SaveJewels");
		finish = PlayerPrefs.GetInt("Finish");
		
		
		if(jewels<15 && finish==0){
			lessJewels.SetActive(true);
			dialog_show.SetActive(false);
			}
		
        else{
			
		if(finish==0){
		jewels-=15;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();
		lock_two.SetActive(false);
		dialog_show.SetActive(false);
		finish=1;
		PlayerPrefs.SetInt("Finish", finish);
		PlayerPrefs.Save();
		}
		
		}
		
	}
	
	public void No(){
		dialog_show.SetActive(false);
	}
}
