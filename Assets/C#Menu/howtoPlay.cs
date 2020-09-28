using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class howtoPlay : MonoBehaviour
{
   public GameObject htp1, htp2, htp3,htp4, HTP, menu;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void openHtp2(){
		htp1.SetActive(false);
		htp2.SetActive(true);
	}
	public void openHtp3(){
	htp2.SetActive(false);
	htp3.SetActive(true);	
	}
	public void openHtp4(){
	htp3.SetActive(false);
	htp4.SetActive(true);	
	}
	public void closehtp(){
	htp1.SetActive(true);
	htp2.SetActive(false);
	htp3.SetActive(false);
	htp4.SetActive(false);
	HTP.SetActive(false);
	menu.SetActive(true);
	
	}
}
