using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textJewels : MonoBehaviour
{
    [SerializeField]
    private Text jewels = null;

    private int jewel;

    void Start()
    {

        jewel = PlayerPrefs.GetInt("SaveJewels");
        jewels.text = "" + jewel;



    }

    // Update is called once per frame
    void Update()
    {
		

    jewel = PlayerPrefs.GetInt("SaveJewels");
        jewels.text = "" + jewel;
    }
}
