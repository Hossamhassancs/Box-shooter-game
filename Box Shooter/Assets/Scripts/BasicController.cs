using UnityEngine;
using System.Collections;

public class BasicController : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		// Outputting the current Horizontal access value
		Debug.Log("Horizontal Input = "+Input.GetAxis("Horizontal"));
	}
}
