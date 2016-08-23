using UnityEngine;
using System.Collections;

public class LoadBanner : MonoBehaviour {

	void Start () {
		gameObject.GetComponent<Ads> ().SendMessage ("RequestBanner");
		gameObject.GetComponent<Ads> ().SendMessage ("ShowMenuBanner");
	}

	void OnDestroy() {
		gameObject.GetComponent<Ads> ().SendMessage ("HideMenuBanner");
	}
}
