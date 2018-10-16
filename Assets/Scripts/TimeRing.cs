using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRing : MonoBehaviour {

	static public float timeLeft = 30;
	public AudioClip timeSound;
	public int rotateSpeed = 10000;
	public Text ringsCollectedText;
	public Text countdown;
	public Text timeAddedText;
	public float timeAdded;
	static public float timeRingCount = 0;
	public int timeRingsNeeded;
	public float timeRingsRemaining;
	public float addTimeTextDestroyTimer = 2;
	public GameObject destroyMe;

	// Use this for initialization
	void Start() {
		timeRingCount = 0;
		timeRingsRemaining = timeRingsNeeded - timeRingCount;
		//GetComponent<BoxCollider> ().enabled = false;
	}

	// Update is called once per frame
	void Update() {

		//makes timer go down, scaling with number of rings remaining
		timeLeft -= Time.deltaTime / (10 - timeRingCount); //fix this shit when i get back from orders

		//rotates time pickup
		transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);

		//tells collectible text to appear when over 0
		if (timeRingCount > 0) {
			//print (numberOfCollectibles);
			ringsCollectedText.text = "Rings: " + timeRingCount + "/10";

		}
		//toggle ring ui text
		//	if (Input.GetKeyDown (KeyCode.K)) {
		//		GetComponent<Text> ().enabled = !GetComponent<Text> ().enabled;

		// }

		if (timeLeft < 0) {
			SceneManager.LoadScene("level1");
		}
		if (timeLeft > 0) {
			//print (timeLeft);
			countdown.text = " " + timeLeft.ToString("f1");

		}

		if (timeRingCount >= timeRingsNeeded) {
			SceneManager.LoadScene("level2");
		}

	}
	void OnTriggerEnter(Collider other) {

		timeLeft = timeLeft + timeAdded;
		timeRingCount = timeRingCount + 1;
		GetComponent<AudioSource>().Play();
		GetComponent<Renderer>().enabled = false;
		GetComponent<BoxCollider>().enabled = false;
		Destroy(gameObject, timeSound.length);
		//timeAddedText.text = "+" + timeAdded; //find a way to destroy this after a second (figure it out later)

	}



}

