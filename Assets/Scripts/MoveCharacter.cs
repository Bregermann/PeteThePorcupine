using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {

	[SerializeField]
	private int movementSpeed = 1;
	[SerializeField]
	private int runSpeed = 2;
	[SerializeField]
	private int chargeSpeed = 2;
	[SerializeField]
	private int rotateSpeed = 180;
	[SerializeField]
	private int flightSpeed = 2;

	private Rigidbody rgbd;
	private Vector3 direction;
	private Vector3 rotateAmount;

	private bool isRunning = false;
	private bool isCharging = false;
	private bool isGrounded = true;

	public AudioClip jumpSound;
	public AudioClip chargeSound;
	public AudioClip moveSound1;
	public AudioClip moveSound2;
	public AudioClip moveSound3;
	public AudioClip moveSound4;
	public AudioClip moveSound5;
	public AudioClip moveSound6;
	public AudioClip shootSound;
	public AudioSource chargeSource;
	public AudioSource jumpSource;
	public AudioSource moveSource;
	public AudioSource shootSource;
	public GameObject powerUpProjectile;
	public Transform projectileSpawnLocation;

	private void Awake() {
		rgbd = GetComponent<Rigidbody>();
	}

	void Start() {
		chargeSource = GetComponent<AudioSource>();
	}

	private void Update() {

		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}

		if ((Input.GetKeyDown (KeyCode.M)) || Input.GetKeyDown(KeyCode.JoystickButton2)) {
			//GetComponent<AudioSource> ().clip = fireballSound;
			//GetComponent<AudioSource> ().Play ();
			Instantiate (powerUpProjectile, projectileSpawnLocation.position, projectileSpawnLocation.rotation);
			shootSource.clip = shootSound;
			shootSource.Play ();
		}

		isRunning = Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl);

		//charging sound
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.JoystickButton0) && !isCharging) {
			chargeSource.clip = chargeSound;
			chargeSource.Play ();
		}


		//stop playing charging sound
		else if ((Input.GetKeyUp (KeyCode.LeftShift) || Input.GetKeyUp (KeyCode.RightShift)) || Input.GetKeyUp(KeyCode.JoystickButton0) && isCharging) {
				chargeSource.Stop ();
		}

		if (Input.GetKeyDown (KeyCode.JoystickButton1) || Input.GetKey(KeyCode.Space) && isGrounded) {
			jumpSource.clip = jumpSound;
			jumpSource.Play ();

		}
			
		isCharging = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift) || Input.GetKey(KeyCode.JoystickButton0);
		direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetKey(KeyCode.JoystickButton1) || Input.GetKey(KeyCode.Space) ? 1 : 0, Input.GetAxisRaw("Vertical")).normalized;
		rotateAmount = Vector3.up * Input.GetAxisRaw("Rotate") * rotateSpeed;
	}

	private void OnCollisionStay(Collision platform) {
		if (platform.gameObject.tag == "platform") {
			isGrounded = true;
		}
	}

	private void OnCollisionExit(Collision platform) {
		if (platform.gameObject.tag == "platform") {
			StartCoroutine(JumpDuration());
		}
	}

	private IEnumerator JumpDuration() {
		yield return new WaitForSeconds(2);
		isGrounded = false;
	}

	private void FixedUpdate() {
		int moveSpeed = isRunning ? runSpeed : movementSpeed;
		direction.x *= moveSpeed;
		direction.z *= moveSpeed;
		if (isGrounded) {
			direction.y *= flightSpeed;
		}

		if (isCharging) {
			rgbd.MovePosition(rgbd.position + transform.TransformDirection(Vector3.forward) * chargeSpeed * Time.fixedDeltaTime);
		} else {
			rgbd.MovePosition(rgbd.position + transform.TransformDirection(direction) * Time.fixedDeltaTime);
			rgbd.MoveRotation(rgbd.rotation * Quaternion.Euler(rotateAmount * Time.fixedDeltaTime));
		}

	}

}
