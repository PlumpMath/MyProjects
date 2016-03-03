using UnityEngine;
using System.Collections;

public class SelfRotation : MonoBehaviour {

	public float speed = 0.2f;
	public string axis = "Y";

	private void rotate(string axis, float speed) {
		switch (axis) {
		case "X":
			transform.Rotate (speed, 0.0f, 0.0f);
			break;
		case "Z":
			transform.Rotate (0.0f, 0.0f, speed);
			break;
		default:
			transform.Rotate (0.0f, speed, 0.0f);
			break;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		rotate (axis, speed);
	}
}
