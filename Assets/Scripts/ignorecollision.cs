using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class ignorecollision : MonoBehaviour {

	public Transform enemyWall;
	// Use this for initialization
	void Start () {
		Physics.IgnoreCollision(enemyWall.GetComponent<Collider>(), GetComponent<Collider>());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
