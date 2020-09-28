using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGooglePlay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void OpenGP(){
		//Application.OpenURL("market://details?id=" + Application.productName);
		Application.OpenURL("https://play.google.com/store/apps/details?id=com.unity.GetToTheFinish");
	}
}
