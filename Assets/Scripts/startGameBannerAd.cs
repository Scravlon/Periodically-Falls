using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using System;
using UnityEngine.SceneManagement;

public class startGameBannerAd : MonoBehaviour {

    private BannerView bannerView;


    // Use this for initialization
    void Start () {
#if UNITY_ANDROID
        string appId = "ca-app-pub-1045433702910438~4555423034";
#elif UNITY_IPHONE
            string appId = "ca-app-pub-3940256099942544~1458002511";
#else
            string appId = "unexpected_platform";
#endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        this.RequestBanner();

    }

    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "mainScene")
        {
            bannerView.Show();
        } else
        {
            bannerView.Destroy();
        }
        //Debug.Log("Active scene is '" + scene.name + "'.");
    }
    public void destroyMe()
    {
        bannerView.Destroy();
    }

    private void RequestBanner()
    {

     #if UNITY_ANDROID
        //string adUnitId = "ca-app-pub-3940256099942544/6300978111";
        string adUnitId = "ca-app-pub-1045433702910438/4074294466";
#elif UNITY_IPHONE
            string adUnitId = "ca-app-pub-3940256099942544/2934735716";
#else
            string adUnitId = "unexpected_platform";
#endif

        // Create a 320x50 banner at the bottom of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
        
        // Called when an ad request has successfully loaded.
        bannerView.OnAdLoaded += HandleOnAdLoaded;
        // Called when an ad request failed to load.
        bannerView.OnAdFailedToLoad += HandleOnAdFailedToLoad;
        // Called when an ad is clicked.
        bannerView.OnAdOpening += HandleOnAdOpened;
        // Called when the user returned from the app after an ad click.
        bannerView.OnAdClosed += HandleOnAdClosed;
        // Called when the ad click caused the user to leave the application.
        bannerView.OnAdLeavingApplication += HandleOnAdLeavingApplication;

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).AddTestDevice("5B0595AB6319C0E9F4A2D77D06E2B378").Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }
 

    private void HandleOnAdLeavingApplication(object sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    public void HandleOnAdLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLoaded event received");
    }

    public void HandleOnAdFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print("HandleFailedToReceiveAd event received with message: "
                            + args.Message);
    }

    public void HandleOnAdOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdOpened event received");
    }

    public void HandleOnAdClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdClosed event received");
    }

    public void HandleOnAdLeftApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleAdLeftApplication event received");
    }

}
