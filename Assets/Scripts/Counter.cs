using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour {

	public GameObject NumberCounter;
	public float numberOfClicks;
	public UnityEngine.UI.Text numberDisplay;
	public GUIText counterText;

	// Use this for initialization
	void Start() {
		numberOfClicks = 0;
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			numberOfClicks++;
			print(numberOfClicks);
			counterText.text = "Clicks: " + numberOfClicks;

		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			numberOfClicks--;
			print(numberOfClicks);
			counterText.text = "Clicks: " + numberOfClicks;
		}
	}

}
