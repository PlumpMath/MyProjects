using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjectFlipper : MonoBehaviour {
	
	public int speed;
	public int delay;
	public string axis;
	public GameObject obj;

	private int index;
	private int flipCycle;
	private bool flipping;

	// Use this for initialization
	void Start () {
		index = 0;
		flipCycle = 180 / speed;
		flipping = true;
	}

	private void flip(GameObject obj, string axis, int speed) {
		switch (axis) {
		case "X":
			obj.transform.Rotate (speed, 0.0f, 0.0f);
			break;
		case "Z":
			obj.transform.Rotate (0.0f, 0.0f, speed);
			break;
		default:
			obj.transform.Rotate (0.0f, speed, 0.0f);
			break;
		}
	}

	// Update is called once per frame
	void Update () {

		if (flipping) {
			if (index++ == flipCycle) {
				flipping = false;
				index = 0;
			}
			flip(obj, axis, speed);
		} else {
			if (index++ == delay) {
				flipping = true;
				index = 0;
			}
		}
	}
}
