using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectable : MonoBehaviour {
	public bool selected;
	// private Color[] colorList;
	//int team = GameManagerSingleton.currentPlayer;

	// Update is called once per frame
	void Update () {
		if (selected) {
			transform.Find ("Plane").GetComponent<MeshRenderer> ().enabled = true;
		} else {
			transform.Find ("Plane").GetComponent<MeshRenderer> ().enabled = false;
		}
	}
}
