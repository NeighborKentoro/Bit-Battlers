using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	/* The in-game UI canvas for the camera */
	[Tooltip("The in-game UI canvas for the camera.")]
	public GameObject canvasInGame;

	/* A cached copy of the camera transform */
	Transform tform;

	/* The target to follow */
	[Tooltip("The transform that the camera will follow.")]
	public Transform target;

	/* The maximum Y boundary */
	[Tooltip("The max y-axis position the camera can reach")]
	public float yMax = 20f;

	/* The minimum Y boundary */
	[Tooltip("The min y-axis position the camera can reach")]
	public float yMin = -20f;

	/* The maximum X boundary */
	[Tooltip("The max x-axis position the camera can reach")]
	public float xMax = 20f;

	/* The minimum X boundary */
	[Tooltip("The min x-axis position the camera can reach")]
	public float xMin = -20f;

	// Use this for initialization
	void Start () {
		tform = transform;
	}

	// Update is called once per frame
	void Update () {

	}

	//update the camera after everything else has happened
	void LateUpdate() {
		if (target != null) {
			float xPos = target.position.x;
			float yPos = target.position.y;
		
			if (xPos > xMax)
				xPos = xMax;
			else if (xPos < xMin)
				xPos = xMin;
			if (yPos > yMax)
				yPos = yMax;
			else if (yPos < yMin)
				yPos = yMin;
		
			tform.position = new Vector3 (xPos, yPos, tform.position.z);
		}
	}

	public void SetupInGameCamera(int playerNum, int numPlayers) {

	}

	public void SetupMenuCamera(int playerNum) {
		if (playerNum > 1)
			gameObject.SetActive (false);
		else {

		}
	}
}
