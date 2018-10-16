using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonFire : MonoBehaviour {
	public Transform spawnLocation;
	public GameObject cannonballPrefab;
	public Transform CannonPivot;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//left
		if (Input.GetKey (KeyCode.A)) {
			transform.Rotate (Vector3.up, -3);
		}
		//right
		if (Input.GetKey (KeyCode.D)) {
			transform.Rotate (Vector3.up, 3);
		}
		//up
		if (Input.GetKey (KeyCode.W)) {
			CannonPivot.Rotate (Vector3.right, 3);
		}
		//down
		if (Input.GetKey (KeyCode.S)) {
			CannonPivot.Rotate (Vector3.right, -3);
		}

		if(Input.GetKeyDown(KeyCode.Space))
		{
			Instantiate (cannonballPrefab, spawnLocation.position, spawnLocation.rotation);
		}
	}
}

