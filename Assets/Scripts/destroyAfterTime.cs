using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyAfterTime : MonoBehaviour {

	public float time = 10;

	//destroys the object
	void Update () {

		time -= Time.deltaTime;
		if (time < 0) {
			Destroy (gameObject);
		}
		
	}
}
