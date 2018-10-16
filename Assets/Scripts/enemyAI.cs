using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemyAI : MonoBehaviour {

	public float xPositionMin;
	public float xPositionMax;
	public float zPositionMin;
	public float zPositionMax;
	public GameObject target;
	static public float movementRandomizer = 0;
	public float randomNumber;
	public AudioClip enemyDestroyed;
	public GameObject collectibleToSpawn;
	public Transform collectibleSpawnLocation;

	// Use this for initialization
	void Start () {
	}
		

	// Update is called once per frame
	void Update () {
		//Vector3 position = new Vector3(Random.Range(xPositionMin, xPositionMax), 0, Random.Range(zPositionMin, zPositionMax));
		movementRandomizer++;
		if (movementRandomizer > 0) {
			randomNumber = Random.Range (1, 100);
			//print (movementRandomizer);
			//print (randomNumber);
			if (randomNumber <= 10) {
				transform.Translate (Vector3.zero * Random.Range (xPositionMin, xPositionMax) * Time.deltaTime);
			} 
			else if (randomNumber >= 11 && randomNumber < 89){
				transform.Translate (Vector3.left * Random.Range (xPositionMin, xPositionMax) * Time.deltaTime);

			}
			else if (randomNumber > 90) {
				transform.Translate (Vector3.forward * Random.Range (zPositionMin, zPositionMax) * Time.deltaTime);

			}

		}
	}

	void OnTriggerEnter (Collider fireball){
			GetComponent<BoxCollider> ().enabled = false;
			GetComponent<AudioSource> ().Play ();
			GetComponent<Renderer> ().enabled = false;
			Destroy(gameObject, enemyDestroyed.length);
			destroyWhenCharged.enemiesDestroyed++;
			Instantiate (collectibleToSpawn, collectibleSpawnLocation.position, collectibleSpawnLocation.rotation);
			//print (enemiesDestroyed);
		}
	
	//use this if I wanted to make it so it only happened when collision box is colliding with player
/*	void OnTriggerStay(Collider player){
		movementRandomizer++;
		if (movementRandomizer > 0) {
			randomNumber = Random.Range (1, 100);
			//print (movementRandomizer);
			//print (randomNumber);
			if (randomNumber <= 10) {
				transform.Translate (Vector3.zero * Random.Range (xPositionMin, xPositionMax) * Time.deltaTime);
			} 
			else if (randomNumber >= 11 && randomNumber < 89){
				transform.Translate (Vector3.left * Random.Range (xPositionMin, xPositionMax) * Time.deltaTime);

			}
			else if (randomNumber > 90) {
				transform.Translate (Vector3.forward * Random.Range (zPositionMin, zPositionMax) * Time.deltaTime);

			}

		} 

		} */
	//use this if I want it to spaz out everywhere
/*		transform.Translate (Vector3.right * Random.Range(xPositionMin, xPositionMax) * Time.deltaTime);
		transform.Translate (Vector3.forward * Random.Range(zPositionMin, zPositionMax) * Time.deltaTime);
		transform.Translate (Vector3.back * Random.Range(xPositionMin, xPositionMax) * Time.deltaTime);
		transform.Translate (Vector3.left * Random.Range(xPositionMin, xPositionMax) * Time.deltaTime); */


		//transform.Translate (Vector4.MoveTowards(target) * Random.Range(xPositionMin, xPositionMax) * Time.deltaTime); //not working
	} 


