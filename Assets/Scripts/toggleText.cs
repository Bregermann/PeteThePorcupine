using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleText : MonoBehaviour {

	public Text toggleUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//toggle text on and off
		if (Input.GetKeyDown (KeyCode.K)) {
			GetComponent<Text> ().enabled = !GetComponent<Text> ().enabled;

		}
	}
}
