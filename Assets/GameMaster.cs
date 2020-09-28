using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private static GameMaster instance;
    public Vector3 lastCheckPointPos;
	

    void Awake()
    {
        if(instance == null)
        {
			
            instance = this;
            DontDestroyOnLoad(instance);
			PlayerPrefs.DeleteKey("icon");
			PlayerPrefs.DeleteKey("SaveVision");
			
			PlayerPrefs.DeleteKey("SpeedNumber");
			PlayerPrefs.DeleteKey("SaveScore");
			PlayerPrefs.DeleteKey("startGame");
			PlayerPrefs.DeleteKey("SaveCameraRotation");
			
			    
        }
        else
        {
            Destroy(gameObject);
			
			
        }
    }
}
