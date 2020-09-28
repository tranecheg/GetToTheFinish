using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class AdManager : MonoBehaviour
{
    public Text LogText;
	public Text AdCompleteText;
	public string AppId;
	public string VideoId;
	RewardBasedVideoAd videoAd;
	
	
    void Start()
    {
    MobileAds.Initialize(AppId);

	this.videoAd = RewardBasedVideoAd.Instance;
	
	videoAd.OnAdLoaded += videoAd_OnAdLoaded;
    videoAd.OnAdFailedToLoad +=videoAd_OnAdFailedToLoad;
	 videoAd.OnAdCompleted +=videoAd_OnAdCompleted ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void LoadVideoAd(){
		AdRequest request = new AdRequest.Builder().Build();
		this.videoAd.LoadAd(request, VideoId);
	}
	public void ShowVideoAd(){
		if(videoAd.IsLoaded()){
			videoAd.Show();
		}
		else{
			AdRequest request = new AdRequest.Builder().Build();
		this.videoAd.LoadAd(request, VideoId);
		}
	}
	private void videoAd_OnAdLoaded(object sender, EventArgs e){
	LogText.text = "Video Ad is loaded";		
	}
	private void videoAd_OnAdFailedToLoad(object sender, AdFailedToLoadEventArgs e){
	LogText.text = "Video Ad is Failed To load";		
	}
	private void videoAd_OnAdCompleted(object sender, EventArgs e){
	AdCompleteText.text = "Video Ad is Completed";		
	}
}
