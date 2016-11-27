using UnityEngine;
using System.Collections;

public class Shop : MonoBehaviour {
	public string player;
	public GameObject buttonBuy;
	public GameObject buttonUse;

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt(player) == 1 || player == "playerDefault") {
			buttonBuy.SetActive (false);
			buttonUse.SetActive (true);
		} else {
			buttonBuy.SetActive (true);
			buttonUse.SetActive (false);
		}
	}

}