using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
	public string player;
	public int price;
	public GameObject bt_buy;
	public GameObject bt_use;

	public void GoToGame(){
		GameObject.Find ("Main Camera").GetComponent<Ads> ().SendMessage ("HideMenuBanner");
		SceneManager.LoadSceneAsync ("game");
	}

	public void GoToMenu(){
		SceneManager.LoadScene("menu");
	}

	public void GoToShop(){
		GameObject.Find ("Main Camera").GetComponent<Ads> ().SendMessage ("HideMenuBanner");
		SceneManager.LoadSceneAsync("shop");
	}

	public void GoToAchievements(){
		GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("ShowAchievements");
	}

	public void GoToLeaderboard(){
		GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("ShowLeaderboard");
	}

	public void buyPlayer(){
		int coins = PlayerPrefs.GetInt ("Coins");
		if (coins >= price) {
			PlayerPrefs.SetInt ("Coins", coins - price);
			PlayerPrefs.SetInt (player, 1);
			GameObject.Find ("Main Camera").GetComponent<Coins> ().SendMessage ("DrawCoins");
			unlockAchievement ();
			bt_buy.SetActive (false);
			bt_use.SetActive (true);
		}
	}

	public void setPlayer(int index){
		PlayerPrefs.SetInt ("playerActive", index);
		SceneManager.LoadSceneAsync("menu");
	}

	void unlockAchievement(){
		switch (player) {
			case "playerBlue":
				GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("AchievementBluePlane");
				break;

			case "playerGray":
				GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("AchievementGreyPlane");
				break;

			case "playerPink":
				GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("AchievementPinkPlane");
				break;

			case "playerPurple":
				GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("AchievementPurplePlane");
				break;

			case "playerOrange":
				GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("AchievementOrangePlane");
				break;
			
			case "playerRed":
				GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("AchievementRedPlane");
				break;

			case "playerYellow":
				GameObject.Find ("Main Camera").GetComponent<PlayGames> ().SendMessage ("AchievementYellowPlane");
				break;
		}
	}
}
