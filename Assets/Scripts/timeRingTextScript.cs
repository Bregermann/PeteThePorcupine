using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timeRingTextScript : MonoBehaviour {

	public Transform target;
	public float wiggleSpeed = 0;
	public AudioClip timeRingTextAudio;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 direction = Distance () + Wiggle();
		direction.Normalize ();

		transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation(direction), wiggleSpeed * Time.deltaTime);

	}

	private Vector3 Distance(){
		return target.position - transform.position;
	}

	private Vector3 Wiggle(){
		return Random.insideUnitSphere * wiggleSpeed;
	}

	void OnTriggerEnter(Collider other){
		//print ("collision has been made yo");
		GetComponent<AudioSource> ().Play ();
		GetComponent<Renderer> ().enabled = false;
		Destroy(gameObject, timeRingTextAudio.length);
	}
}
