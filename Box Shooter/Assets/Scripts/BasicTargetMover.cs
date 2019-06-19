using UnityEngine;
using System.Collections;

public class BasicTargetMover : MonoBehaviour {

	public float spainSpeed = 180.0f; 
	public float motionMagnitude = 0.1f; 

	public bool doSpain = true; 
	public bool doMotion = false; 

	// Update is called once per frame
	void Update () {
		if (doSpain) {
			// Rotate around the up axis of the gameobject
			gameObject.transform.Rotate (Vector3.up * spainSpeed * Time.deltaTime);
		}

		if (doMotion) {
			// Move up and down over time
			gameObject.transform.Translate (Vector3.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude); 
		}
	}
}
