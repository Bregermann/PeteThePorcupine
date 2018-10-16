using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyAndDie : MonoBehaviour {
	public Rigidbody rb;
	public int moveSpeed;

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, 4f);	//destroys the object 4 seconds after launch
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddRelativeForce (Vector3.forward * moveSpeed, ForceMode.Impulse);
		transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
	}

	void OnTriggerEnter(Collider breakableChest){
		//print (destroyWhenCharged.enemiesDestroyed);
		//destroyWhenCharged.enemiesDestroyed++;
		Destroy (gameObject);
	}
		
}
	
