using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	private int score = 0;
	public Text scoreText;
	public Text bestScore;

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

	int GetBestScore(){
		return PlayerPrefs.GetInt ("BestScore");
	}

	public void DrawBestScore(){
		bestScore.text = "Best score: " + GetBestScore();
	}

	public void SetNewHighscore(){
		int best = PlayerPrefs.GetInt ("BestScore");
		if (score > best) {
			PlayerPrefs.SetInt ("BestScore", score);
		}
	}
}
