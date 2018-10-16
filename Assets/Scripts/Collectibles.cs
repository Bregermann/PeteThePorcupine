using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectibles : MonoBehaviour {

	public AudioClip collectibleSound;
	public AudioClip collectibleWinSound;
	static public float numberOfCollectibles = 0;
	public Text collectibleCounter;
	public Text collectibleWinText;
	public int rotateSpeed = 10000;
	public float time = 2;
	public float collectibleValue;
	public float allCollectibles;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = collectibleSound;
		//numberOfCollectibles = 0;

	}
	
	// Update is called once per frame
	void Update () {

		//rotates collectible
		transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime);

		//tells collectible text to appear when over 0
		if (numberOfCollectibles > 0) {
			//print (numberOfCollectibles);
			collectibleCounter.text = numberOfCollectibles + " / 100";

		}
		//hide collectible ui text
		if (Input.GetKeyDown (KeyCode.K)) {
			GetComponent<Text> ().enabled = !GetComponent<Text> ().enabled;
		}

		//text to tell player they got all collectibles
		if (numberOfCollectibles >= allCollectibles) {
			collectibleWinText.text = numberOfCollectibles + "/" + numberOfCollectibles + " 100%";
			Destroy (collectibleWinText, collectibleWinSound.length); //fix
		
		}
			
	}
	//counts the collectible, plays the audio, hides the object, removes its collider and destroys when the sound finishs
	void OnTriggerEnter(Collider Player){
		numberOfCollectibles = numberOfCollectibles + collectibleValue;
		GetComponent<AudioSource> ().Play ();
		GetComponent<Renderer> ().enabled = false;
		GetComponent<BoxCollider>().enabled = false;
		Destroy(gameObject, collectibleSound.length);
		}
		
		
}


