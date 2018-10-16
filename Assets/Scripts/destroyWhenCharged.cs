using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyWhenCharged : MonoBehaviour {

	public AudioClip enemyDestroyed;
	static public float enemiesDestroyed;
	public BoxCollider enemyHitBox;
	public GameObject collectibleToSpawn;
	public Transform collectibleSpawnLocation;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider fireball){
		if ((Input.GetKey (KeyCode.RightShift)) || Input.GetKey(KeyCode.JoystickButton0)) {
			GetComponent<BoxCollider> ().enabled = false;
			GetComponent<AudioSource> ().Play ();
			GetComponent<Renderer> ().enabled = false;
			Destroy (gameObject, enemyDestroyed.length);
			enemiesDestroyed++;
			Instantiate (collectibleToSpawn, collectibleSpawnLocation.position, collectibleSpawnLocation.rotation);
			//print (enemiesDestroyed);
		}
	}
		
}
