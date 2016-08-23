using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	private int score = 0;
	public Text scoreText;

	void Start(){
		DrawScore ();
	}

	void Update() {
		DrawScore ();
	}

	public void IncrementAndDrawScore(){
		this.score += 1;
		DrawScore ();
	}

	public void DrawScore(){
		scoreText.text = "Score: " + score.ToString();
	}
}
