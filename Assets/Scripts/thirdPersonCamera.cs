using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPersonCamera : MonoBehaviour {

	private const float Y_ANGLE_MIN = 0.0f;
	private const float Y_ANGLE_MAX = 50.0f;

	public float speed = 1;

	public Transform Target;
	public Transform camTransform;
	public Camera cam;

	public Vector3 offset;

	private float distance = 2.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensitivityX = 10.0f;
	private float sensitivityY = 10.0f;

	void Start(){
		camTransform = transform;
		cam = Camera.main;
	}

	private void Update(){
		currentX += Input.GetAxis ("ps4controllerX");
		currentY += Input.GetAxis ("ps4controllerY");

		currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

	}

	private void LateUpdate(){
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		camTransform.position = Target.position + rotation * dir;
		camTransform.LookAt (Target.position);
	}
}



/*	void LateUpdate(){
		Vector3 desiredPosition = Target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, speed);
		transform.position = smoothedPosition;
		
		//Move ();
	}

	public void Move(){
		Vector3 direction = (Target.position - cam.transform.position).normalized;
		Quaternion lookrotation = Quaternion.LookRotation (direction);
		lookrotation.x = transform.rotation.x;
		lookrotation.z = transform.rotation.z;
		transform.rotation = Quaternion.Slerp (transform.rotation, lookrotation, Time.deltaTime * 100);
		transform.position = Vector3.Slerp (transform.position, Target.position, Time.deltaTime * speed);
	}

}

*/