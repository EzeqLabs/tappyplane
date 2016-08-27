using UnityEngine;
using System.Collections;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class Ads : MonoBehaviour {
	BannerView bannerView;
	InterstitialAd interstitial;

	void RequestBanner(){
		string adUnitId = "ca-app-pub-8736689435854328/4175343198";

		bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);
		AdRequest request = new AdRequest.Builder().Build();
		bannerView.LoadAd(request);
	}

	void RequestInterstitial(){
		string adUnitId = "ca-app-pub-8736689435854328/6888463990";


		interstitial = new InterstitialAd(adUnitId);
		AdRequest request = new AdRequest.Builder().Build();
		interstitial.LoadAd(request);
	}

	void ShowMenuBanner(){
		bannerView.Show ();
	}

	void HideMenuBanner(){
		bannerView.Hide ();
	}

	void ShowGameOverBanner(){
		if (interstitial.IsLoaded()) {
			interstitial.Show();
		}
	}


}
