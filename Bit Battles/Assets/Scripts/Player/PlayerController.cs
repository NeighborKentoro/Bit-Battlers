using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* The player states represented as enums */
public enum PlayerStates { None, Idle, Moving, Attacking, ItemUse, AltItemUse };

public class PlayerController : MonoBehaviour {

	/* The player number */
	public int playerNum;

	/* The current state of the player */
	private PlayerStates curState;

	/* The next state of the player */
	private PlayerStates nextState;

	#region Player State Objects
	/* The idle state of the player */
	private PlayerIdle idleState;

	/* The moving state of the player */
	private PlayerMoving movingState;

	/* The attacking state of the player */
	private PlayerAttacking attackingState;

	/* The item use state of the player */
	private PlayerItemUse itemUseState;

	/* The alt item use state of the player */
	private PlayerAltItemUse altItemUseState;

	#endregion

	/* The player character's rigidbody2D */
	private Rigidbody2D rBody;

	/* The player character's animation controller */
	private Animator animController;

	// Use this for initialization
	void Start () {
		//initialize variables
		rBody = GetComponent<Rigidbody2D>();
		idleState = GetComponent<PlayerIdle> ();
		movingState = GetComponent<PlayerMoving> ();
		attackingState = GetComponent<PlayerAttacking> ();
		itemUseState = GetComponent<PlayerItemUse> ();
		altItemUseState = GetComponent<PlayerAltItemUse> ();

		animController = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (nextState != PlayerStates.None)
			SwitchPlayerStates ();
	}

	/* Switches the state of the player to the new state */
	void SwitchPlayerStates () {
		switch (nextState) {
		case PlayerStates.Idle:
			idleState.enabled = true;
			break;
		case PlayerStates.Moving:
			movingState.enabled = true;
			break;
		case PlayerStates.Attacking:
			attackingState.enabled = true;
			break;
		case PlayerStates.ItemUse:
			itemUseState.enabled = true;
			break;
		case PlayerStates.AltItemUse:
			altItemUseState.enabled = true;
			break;
		default:
			break;
		}
		nextState = PlayerStates.None;
	}

	/* States use this to set what the next state is */
	public void SetNextState (PlayerStates newState) {
		if(newState != PlayerStates.None)
			nextState = newState;
	}

	/* Sets the animation based on the input */
	public void SetAnimation () {
		
	}

	/* Changes the linear drag to the new value "newDrag" */
	void ChangeDrag (float newDrag) {
		rBody.drag = newDrag;
	}

	public Rigidbody2D RBody() {
		return rBody;
	}
}
