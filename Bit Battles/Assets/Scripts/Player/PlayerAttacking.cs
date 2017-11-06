using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour {

	/* The player's controller script */
	private PlayerController playerController;

	// Use this for initialization
	void Start () {
		playerController = GetComponent<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
		float hAxis = Input.GetAxis ("Horizontal");

		if (hAxis != 0) {
			this.enabled = false;
			playerController.SetNextState (PlayerStates.Moving);
		} else if (hAxis == 0) {
			this.enabled = false;
			playerController.SetNextState (PlayerStates.Idle);
		}
	}

	void OnEnable() {
		//play attacking animation
		Debug.Log("Attacking enabled");
	}

	void OnDisable() {
		Debug.Log ("Disabled attacking");
	}
}
