using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coins : MonoBehaviour {
	private int coins = PlayerPrefs.GetInt ("Coins");
	public Text coinsText;

	void Start(){
		DrawCoins ();
	}

	void Update() {
		DrawCoins ();
	}

	public void IncrementAndDrawCoins(){
		this.coins = PlayerPrefs.GetInt ("Coins");
		this.coins += 1;
		PlayerPrefs.SetInt ("Coins", coins);
		DrawCoins ();
	}

	public void DrawCoins(){
		coinsText.text = coins.ToString();
	}

	int GetCoins(){
		return PlayerPrefs.GetInt ("Coins");
	}
}
