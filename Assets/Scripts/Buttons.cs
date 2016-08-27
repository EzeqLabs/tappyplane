using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
	public void GoToGame(){
		GameObject.Find ("Main Camera").GetComponent<Ads> ().SendMessage ("HideMenuBanner");
		SceneManager.LoadSceneAsync ("game");
	}

	public void GoToMenu(){
		SceneManager.LoadScene("menu");
	}
}
