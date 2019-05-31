using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLookWalk : MonoBehaviour {

	// mitad de la velocidad normal de caminata de un humano
	public float velocity = 0.7f;
	public bool isWalking = false;

	private CharacterController controller;
	private Clicker clicker = new Clicker ();

	void Start () {
		controller = GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {
		if (clicker.clicked ()) {
			isWalking = !isWalking;
		}

		if (isWalking) {
			// Aplica la gravedad al personaje
			controller.SimpleMove (Camera.main.transform.forward * velocity);	
		}

		/* No aplica gravedad
		Vector3 moveDirection = Camera.main.transform.forward;
		moveDirection *= velocity * Time.deltaTime;
		moveDirection.y = 0.0f;
		controller.Move (moveDirection);*/
	}
}
