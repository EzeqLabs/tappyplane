using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Coins : MonoBehaviour {
	private int coins = PlayerPrefs.GetInt ("Coins");
	private int totalCoins = PlayerPrefs.GetInt("TotalCoins");
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
		IncrementTotalCoins ();
		DrawCoins ();
	}

	public void DrawCoins(){
		coinsText.text = PlayerPrefs.GetInt ("Coins").ToString();
	}

	int GetCoins(){
		return PlayerPrefs.GetInt ("Coins");
	}

	void IncrementTotalCoins(){
		this.totalCoins = PlayerPrefs.GetInt ("TotalCoins");
		this.totalCoins += 1;
		PlayerPrefs.SetInt ("TotalCoins", totalCoins);
		GameObject.Find ("Scripts").GetComponent<PlayGames> ().SendMessage ("AchivementsCoins", totalCoins/500);
	}
}
