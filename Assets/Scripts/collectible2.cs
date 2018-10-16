using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectible2 : MonoBehaviour {

	public AudioClip collectibleSound2;
	public AudioClip collectibleWinSound2;
	static public float numberOfCollectibles2 = 0;
	public Text collectibleCounter2;
	public Text collectibleWinText2;
	public int rotateSpeed = 10000;
	public float time = 2;
	public float collectibleValue2;
	public float allCollectibles2;

	public GameObject collectibleToSpawn;
	public Transform collectibleSpawnLocation;

	// Use this for initialization
	void Start () {
		GetComponent<AudioSource> ().playOnAwake = false;
		GetComponent<AudioSource> ().clip = collectibleSound2;
		//numberOfCollectibles = 0;

	}

	// Update is called once per frame
	void Update () {

		//rotates collectible
		transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime);

		//tells collectible text to appear when over 0
		if (numberOfCollectibles2 > 0) {
			//print (numberOfCollectibles);
			collectibleCounter2.text = numberOfCollectibles2 + " / 5";

		}
		//hide collectible ui text
		if (Input.GetKeyDown (KeyCode.K)) {
			GetComponent<Text> ().enabled = !GetComponent<Text> ().enabled;
		}

		//text to tell player they got all collectibles
		if (numberOfCollectibles2 >= allCollectibles2) {
			collectibleWinText2.text = numberOfCollectibles2 + "/" + numberOfCollectibles2 + " 100%";
			Destroy (collectibleWinText2, collectibleWinSound2.length); //fix

		}

	}
	//counts the collectible, plays the audio, hides the object, removes its collider and destroys when the sound finishs
	void OnTriggerEnter(Collider other){
		if ((Input.GetKey (KeyCode.RightShift)) || Input.GetKey (KeyCode.JoystickButton0)) {
			numberOfCollectibles2 = numberOfCollectibles2 + collectibleValue2;
			GetComponent<AudioSource> ().Play ();
			GetComponent<Renderer> ().enabled = false;
			GetComponent<BoxCollider> ().enabled = false;
			Destroy (gameObject, collectibleSound2.length);
			Instantiate (collectibleToSpawn, collectibleSpawnLocation.position, collectibleSpawnLocation.rotation);

		}
	}


}


