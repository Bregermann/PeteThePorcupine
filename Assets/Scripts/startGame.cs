using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.JoystickButton1)) {
			SceneManager.LoadScene ("firstScene");
			Collectibles.numberOfCollectibles = 0;
			collectible2.numberOfCollectibles2 = 0;

		}

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}
		
	}
}
