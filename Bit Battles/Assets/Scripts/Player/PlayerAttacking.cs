using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacking : MonoBehaviour {

	/* The player's controller script */
	private PlayerController playerController;

	/* Is the player done attacking? */
	private bool doneAttacking;

	/* The horizontal axis value */
	private float hAxis;

	/* The vertical axis value */
	private float vAxis;

	#region Input names
	/* The horizontal axis name */
	private string horizontal;

	/* The vertical axis name */
	private string vertical;

	/* The attack button name */
	private string attack;

	/* The item button name */
	private string item;

	/* The alternate item button name */
	private string altItem;
	#endregion

	void Awake () {
		playerController = GetComponent<PlayerController> ();
	}

	// Use this for initialization
	void Start () {
		horizontal = "Horizontal" + playerController.playerNum;
		vertical = "Vertical" + playerController.playerNum;
		attack = "Attack" + playerController.playerNum;
		item = "Item" + playerController.playerNum;
		altItem = "AltItem" + playerController.playerNum;
	}
	
	// Update is called once per frame
	void Update () {
		hAxis = Input.GetAxis (horizontal);
		vAxis = Input.GetAxis (vertical);

		if (doneAttacking) {
			if (hAxis != 0 || vAxis != 0) {
				this.enabled = false;
				playerController.SetNextState (PlayerStates.Moving);
			} else if (hAxis == 0 && vAxis == 0) {
				this.enabled = false;
				playerController.SetNextState (PlayerStates.Idle);
			}
		}
	}

	void OnEnable() {
		//play attacking animation
		playerController.SetAnimation();
		doneAttacking = false;
		Debug.Log("Attacking enabled");
	}

	void OnDisable() {
		Debug.Log ("Disabled attacking");
	}

	public void DoneAttacking () {
		doneAttacking = true;
	}
}
