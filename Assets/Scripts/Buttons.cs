using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
	public void GoToGame(){
		SceneManager.LoadScene("game");
	}

	public void GoToMenu(){
		SceneManager.LoadScene("menu");
	}
}
