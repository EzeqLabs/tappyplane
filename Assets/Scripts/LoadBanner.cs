using UnityEngine;
using System.Collections;

public class LoadBanner : MonoBehaviour {

	void Start () {
		gameObject.GetComponent<Ads> ().SendMessage ("RequestBanner");
		gameObject.GetComponent<Ads> ().SendMessage ("ShowMenuBanner");
		gameObject.GetComponent<Score> ().SendMessage ("DrawBestScore");
	}

	void OnDestroy() {
		gameObject.GetComponent<Ads> ().SendMessage ("HideMenuBanner");
	}
}
