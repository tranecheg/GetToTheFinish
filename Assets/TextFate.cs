using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFate : MonoBehaviour
{
    public SpriteRenderer txt;
	private string saveColor;
	
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
		
       txt.color = new Color(txt.color.r, txt.color.g,  txt.color.b, Mathf.PingPong(Time.time/1.5f, 1.0f));
	
	   
	   
	 //  line.effectColor = new Color(line.effectColor.r, line.effectColor.g,  line.effectColor.b, txt.color.a);
    }
}
