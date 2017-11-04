using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

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

	}

	// Update is called once per frame
	void Update () {

	}

	//update the camera after everything else has happened
	void LateUpdate() {

	}

	public void SetupInGameCamera(int playerNum, int numPlayers) {

	}
}
