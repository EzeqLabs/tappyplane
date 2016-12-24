using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0,0.1f);
	GameObject[] gameOverObjects;
	bool isRunning;
	public static Sprite playerDefault, playerBlue, playerGray, playerPink, playerPurple, playerOrange, playerRed, playerYellow;
	public Sprite[] players = {playerDefault
		, playerBlue
		, playerGray
		, playerPink
		, playerPurple
		, playerOrange
		, playerRed
		, playerYellow};
	int playerIndex = PlayerPrefs.GetInt ("playerActive");
	float lastY = -999999;

	void Start(){
		isRunning = true;

		GetComponent<SpriteRenderer> ().sprite = players[playerIndex];

		gameOverObjects = GameObject.FindGameObjectsWithTag ("gameOverObjects");
		foreach (GameObject g in gameOverObjects) {
			g.SetActive (false);
		}
	}

	void Update () {
		Rigidbody2D player = GetComponent<Rigidbody2D> ();

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended){
			if (isRunning){
				player.velocity = Vector2.zero;
				player.AddForce (jumpForce);
			}
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y > Screen.height || screenPosition.y < 0){
			Die();
		}
	}

	void FixedUpdate(){
		Rigidbody2D player = GetComponent<Rigidbody2D> ();
		float actualY = player.velocity.y;

		if (lastY == -999999) {
			lastY = actualY;
		} else {
			if (lastY > actualY) {
//				player.angularVelocity = -5;
				player.MoveRotation (-700 * Time.fixedDeltaTime);
			}else{
				player.angularVelocity = 5;
				player.MoveRotation (700 * Time.fixedDeltaTime);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		Die();
	}

	void Die(){
		isRunning = false;

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
