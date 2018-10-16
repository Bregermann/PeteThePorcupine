using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	
	static public float timeLeft = 30;
	public Text countdown;
	public UnityEngine.UI.Text numberDisplay;
	public GameObject timer;


	void Update () {

		timeLeft -= Time.deltaTime;

		if (timeLeft > 0) {
			//print (timeLeft);
			countdown.text = " " + timeLeft.ToString("f1");
		}
		
	
		if (timeLeft < 0) {
			SceneManager.LoadScene ("level1");
			}
	}
}

