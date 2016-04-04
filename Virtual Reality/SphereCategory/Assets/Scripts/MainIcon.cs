using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainIcon : MonoBehaviour {
	public Image slider;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartGazeAtIcon() {
		Debug.Log ("startGazeAtIcon");
	}

	public void StopGazeAtIcon() {
		Debug.Log ("endGazeAtIcon");
//		Application.LoadLevel("MainScene");
	}
}
