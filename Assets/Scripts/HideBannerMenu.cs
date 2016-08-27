using UnityEngine;
using System.Collections;

public class HideBannerMenu : MonoBehaviour {
	
	void Start () {
		gameObject.GetComponent<Ads> ().SendMessage ("RequestInterstitial");
		gameObject.GetComponent<Ads> ().SendMessage ("HideMenuBanner");
	}
}
