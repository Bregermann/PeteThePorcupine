using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelExit : MonoBehaviour {
	
	public float time = 0;

	void OnTriggerStay(Collider other)	{
		time = Time.deltaTime + time;
		if (time > 4) {
			if (other.tag == "Player") {
				SceneManager.LoadScene ("winScreen");
			}
		}
	}
}
