using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EzeqLabs : MonoBehaviour {

	void Start () {
		Invoke ("CloseEzqScreen", 3.0f);
	}

	void CloseEzqScreen(){
		SceneManager.LoadScene("menu");
	}
}
