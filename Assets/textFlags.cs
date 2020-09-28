using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class textFlags : MonoBehaviour
{
    [SerializeField]
    private Text flags = null;

    private int flag;

    void Start()
    {

        flag = PlayerPrefs.GetInt("SaveFlags");
        flags.text = "" + flag;
       


    }

    // Update is called once per frame
    void Update()
    {
        flag = PlayerPrefs.GetInt("SaveFlags");
        flags.text = "" + flag;
    }
	
	  public void Dowm()
    {
		GameObject gm = GameObject.Find("player");
		simpleJump scriptSJ = gm.GetComponent<simpleJump>();
		scriptSJ.enabled = false;
	}
	
	  public void Up()
    {
		GameObject gm = GameObject.Find("player");
		simpleJump scriptSJ = gm.GetComponent<simpleJump>();
		scriptSJ.enabled = true;
	}
}
