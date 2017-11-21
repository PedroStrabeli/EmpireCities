using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingPlacement: MonoBehaviour {

	[SerializeField]
	private GameObject placeablePrefab;

	[SerializeField]
	private KeyCode hotKey = KeyCode.A;

	private GameObject placeableObject;

	void Update() {
		HandleHotKey ();
		if (placeableObject != null) {
			MoveToMouse ();
			ReleaseIfClicked ();
		}
	}
	private void ReleaseIfClicked() {
		if (Input.GetMouseButtonDown (0)) {
			placeableObject = null;
		}
	}

	private void MoveToMouse() {
		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast (ray, out hitInfo)) {
			placeableObject.transform.position = hitInfo.point;
			placeableObject.transform.rotation = Quaternion.FromToRotation (Vector3.up, hitInfo.normal);
		}
	}

	private void HandleHotKey () {
		if (Input.GetKeyDown (hotKey)) {
			if (placeableObject == null) {
				placeableObject = Instantiate (placeablePrefab);
			}
			else {
				Destroy(placeableObject);;
			}
		}
	}


	public void setItem (GameObject g) {
		Debug.Log (g.name);
	}

}

