using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour {
	public GameObject rocks;
	private bool running = true;

	void Start () {
		InvokeRepeating ("CreateObstacle", 0.7f, 1.0f);
	}

	void CreateObstacle(){
		if (running) {
			Instantiate (rocks);
		}
	}

	public void CancelInvoking(){
		this.running = false;

		GameObject[] rockPairs = GameObject.FindGameObjectsWithTag ("rockPair");
		for (int i = 0; i < rockPairs.Length; i++) {
			rockPairs [i].GetComponent<Rigidbody2D> ().velocity = Vector2.zero;
		}
	}
}
