using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

using GoogleMobileAds.Api;


public class oneCoin : MonoBehaviour
{
    private RewardedAd rewardedAd;
	//private string rewardedID="ca-app-pub-3940256099942544/5224354917";
	private string rewardedID="ca-app-pub-8545434136440180/1520793940";
	   private float deltaTime = 0.0f;
    private static string outputMessage = string.Empty;
	public int jewels;
	public Text textCount;
	
	 public void Start()
    {

#if UNITY_ANDROID
       // string appId = "ca-app-pub-3940256099942544~3347511713";
	   string appId = "ca-app-pub-8545434136440180~6773120624";
#elif UNITY_IPHONE
        string appId = "ca-app-pub-3940256099942544~1458002511";
#else
        string appId = "unexpected_platform";
#endif

       

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        this.CreateAndLoadRewardedAd();
    }
	
	private AdRequest CreateAdRequest()
    {
        return new AdRequest.Builder()
                               
            .Build();
    }
	
	public void CreateAndLoadRewardedAd()
    {
#if UNITY_EDITOR
        string adUnitId = "unused";
#elif UNITY_ANDROID
        //string adUnitId = "ca-app-pub-3940256099942544/5224354917";
		string adUnitId = "ca-app-pub-8545434136440180/1520793940";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3940256099942544/1712485313";
#else
        string adUnitId = "unexpected_platform";
#endif
        // Create new rewarded ad instance.
        this.rewardedAd = new RewardedAd(adUnitId);

        // Called when an ad request has successfully loaded.
        this.rewardedAd.OnAdLoaded += HandleRewardedAdLoaded;
        // Called when an ad request failed to load.
        this.rewardedAd.OnAdFailedToLoad += HandleRewardedAdFailedToLoad;
        // Called when an ad is shown.
        this.rewardedAd.OnAdOpening += HandleRewardedAdOpening;
        // Called when an ad request failed to show.
        this.rewardedAd.OnAdFailedToShow += HandleRewardedAdFailedToShow;
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
        // Called when the ad is closed.
        this.rewardedAd.OnAdClosed += HandleRewardedAdClosed;

        // Create an empty ad request.
        AdRequest request = this.CreateAdRequest();
        // Load the rewarded ad with the request.
        this.rewardedAd.LoadAd(request);
    }
	public void ShowRewardedAd()
    {
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
        else
        {
            MonoBehaviour.print("Rewarded ad is not ready yet");
        }
    }
 public void HandleRewardedAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdLoaded event received");
		
    }

    public void HandleRewardedAdFailedToLoad(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToLoad event received with message: " + args.Message);
    }

    public void HandleRewardedAdOpening(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdOpening event received");
    }

    public void HandleRewardedAdFailedToShow(object sender, AdErrorEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardedAdFailedToShow event received with message: " + args.Message);
    }

    public void HandleRewardedAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardedAdClosed event received");
		this.CreateAndLoadRewardedAd();
    }

    public void HandleUserEarnedReward(object sender, Reward args)
    {
		
         jewels = PlayerPrefs.GetInt("SaveJewels");
        jewels++;
        PlayerPrefs.SetInt("SaveJewels", jewels);
        PlayerPrefs.Save();
		
		this.CreateAndLoadRewardedAd();
    }
}
