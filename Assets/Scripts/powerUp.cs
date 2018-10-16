using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUp : MonoBehaviour {
	
	public float enemiesForPowerUp = 2;
	public static int powerupTimer = 0;
	public bool powerUpEnabled = false;
	public GameObject powerUpProjectile;
	public Transform projectileSpawnLocation;
	public AudioClip fireballSound;
	public AudioClip powerUpSound;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//print (powerupTimer);
		//print (powerUpEnabled);
		if (powerupTimer > 0) {
			powerupTimer--;
			if (Input.GetKeyDown (KeyCode.M)) {
				//GetComponent<AudioSource> ().clip = fireballSound;
				//GetComponent<AudioSource> ().Play ();
				Instantiate (powerUpProjectile, projectileSpawnLocation.position, projectileSpawnLocation.rotation);
			}
		}
		
	}

	void OnCollisionEnter(Collision other){
		Destroy (gameObject);
	}

	void OnTriggerStay(Collider player){

		if (destroyWhenCharged.enemiesDestroyed >= enemiesForPowerUp) {
			powerUpEnabled = true;
			//GetComponent<AudioSource> ().clip = powerUpSound;
			//GetComponent<AudioSource> ().Play ();

		}

		if (powerUpEnabled = true) {
			powerupTimer = 2000;

		}
	}
}
