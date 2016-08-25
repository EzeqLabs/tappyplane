using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0,130);
	GameObject[] gameOverObjects;

	void Start(){
		gameOverObjects = GameObject.FindGameObjectsWithTag ("gameOverObjects");
		foreach (GameObject g in gameOverObjects) {
			g.SetActive (false);
		}
	}

	void Update () {
		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended){
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().AddForce (jumpForce);
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0){
			Die();
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		Die();
	}

	void Die(){
		GameObject.Find("Scripts").GetComponent<Generate>().SendMessage("CancelInvoking");

		foreach (GameObject g in gameOverObjects) {
			g.SetActive (true);
		}

		Invoke ("ShowBannerGameOver", 0.5f);

	}

	void ShowBannerGameOver (){
		GameObject.Find ("Main Camera").GetComponent<Ads> ().SendMessage ("ShowGameOverBanner");
	}
}
