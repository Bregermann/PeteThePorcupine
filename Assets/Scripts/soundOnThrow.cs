/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class soundOnThrow : MonoBehaviour {

	public float randomNumber;
	public AudioClip clipOne;
	public AudioClip clipTwo;
	public AudioClip clipThree;
	public AudioClip clipFour;
	public AudioClip clipFive;
	public AudioClip clipSix;
	public AudioClip clipSeven;
	public AudioClip clipEight;
	public AudioClip clipNine;
	public AudioClip clipTen;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void onCollisionStay(Collider RagdollBuddy){

		if(controller.GetPressDown(triggerButton)){
			randomNumber = Random.Range (1, 100);
			
			while(controller.GetPressUp(triggerButton){
					if (randomNumber < 10) {
					GetComponent<AudioSource> ().clip = clipOne;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 10 && randomNumber < 20) {
					GetComponent<AudioSource> ().clip = clipTwo;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 20 && randomNumber < 30) {
					GetComponent<AudioSource> ().clip = clipThree;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 30 && randomNumber < 40) {
					GetComponent<AudioSource> ().clip = clipFour;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 40 && randomNumber < 50) {
					GetComponent<AudioSource> ().clip = clipFive;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 50 && randomNumber < 60) {
					GetComponent<AudioSource> ().clip = clipSix;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 60 && randomNumber < 70) {
					GetComponent<AudioSource> ().clip = clipSeven;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 70 && randomNumber < 80) {
					GetComponent<AudioSource> ().clip = clipEight;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 80 && randomNumber < 90) {
					GetComponent<AudioSource> ().clip = clipNine;
					GetComponent<AudioSource> ().Play ();

				}
				if (randomNumber >= 90 && randomNumber < 100) {
					GetComponent<AudioSource> ().clip = clipTen;
					GetComponent<AudioSource> ().Play ();

				}

			}

		}
	}
}
*/