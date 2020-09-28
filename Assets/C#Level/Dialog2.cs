using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog2 : MonoBehaviour
{
    public GameObject dialog_show;
	public GameObject lockThree;
	public GameObject lessJewels;
	public int jewels, finish;

	
    // Start is called before the first frame update
    void Start()
    {
        
		//PlayerPrefs.DeleteAll();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && lessJewels !=null)
			lessJewels.SetActive(false);
    }
	public void OpenLevel(){
		finish = PlayerPrefs.GetInt("Finish");
		if(finish==1){
		if(lockThree != null){
			dialog_show.SetActive(true);
		}
		}
		
	}
	public void Yes(){
		jewels = PlayerPrefs.GetInt("SaveJewels");
		finish = PlayerPrefs.GetInt("Finish");
		
		
		if(jewels<15 && finish==1){
			lessJewels.SetActive(true);
			dialog_show.SetActive(false);
			}
		
        else{
			
		if(finish==1){
		jewels-=15;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();
		lockThree.SetActive(false);
		dialog_show.SetActive(false);
		finish=2;
		PlayerPrefs.SetInt("Finish", finish);
		PlayerPrefs.Save();
		}
		
		}
		
	}
	
	public void No(){
		dialog_show.SetActive(false);
	}
}
