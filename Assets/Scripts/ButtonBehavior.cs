using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour {
	[SerializeField]
	private GameObject[] buildingPrefabs;

	private BuildingPlacement bpl;
	private GameManagerSingleton gms;
	//public GameObject prefabButton;
	public GameObject placeableObject;

	private int level;
	private string type;

	Vector3 currentMouseCoord;

	void Start() {
		bpl = GetComponent<BuildingPlacement>();
		//house = (GameObject)Resources.Load("Assets/Prefabs/house");
		//cube.SetActive(false);
		//bpl.setItem(house);
	}


	//public RectTransform ParentPanel;
	//List<Action> funcList = new List<Action>();
	//List<String> nameList = new List<String>();

	void Update() {
		if (placeableObject != null) {
			MoveToMouse ();
			ReleaseIfClicked ();
		}
	}
	private void ReleaseIfClicked() {
		if (Input.GetMouseButtonDown (0)) {
			GetComponent<GameManagerSingleton>().alocateBuilding (placeableObject, type, level);
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

	//public Transform _panel;
	/*void Start() {
		RectTransform panelRectTransform = _panel.GetComponent<RectTransform>();

		for (int i = 0; i < 9; i++) { // add components 
			GameObject buildButton = (GameObject)Instantiate(prefabButton);
			buildButton.transform.SetParent (ParentPanel);
			buildButton.transform.localScale = new Vector3 (1, 1, 1);
		} 

			panelRectTransform.sizeDelta.Set((float)xPos + 10, panelRectTransform.sizeDelta.y); 
		// xPos is the placement of the components.

		funcList.Add (() => BuildHouse ());
		funcList.Add (() => BuildApto ());
		funcList.Add (() => BuildCondo ());
		funcList.Add (() => BuildTower ());
		funcList.Add (() => BuildBarracks ());
		funcList.Add (() => BuildCastle ());
		funcList.Add (() => BuildParish ());
		funcList.Add (() => BuildChurch ());
		funcList.Add (() => BuildCathedral ());

	}*/

	public void BuildHouse () {
		//Debug.Log (this.buildings[0]);
		Debug.Log ("House Built");
		type = "res";
		level = 1;
		HandleBuild (buildingPrefabs [0]);

	}

	public void BuildApto () {
		Debug.Log ("Apto Built");
		type = "res";
		level = 2;
		//this.bpl.HandleBuild (0);
	}

	public void BuildCondo () {
		Debug.Log ("Condo Built");
		type = "res";
		level = 3;
		HandleBuild (buildingPrefabs [0]);
	}

	public void BuildTower () {
		Debug.Log ("Tower Built");
		type = "mil";
		level = 1;
		HandleBuild (buildingPrefabs [1]);
	}

	public void BuildBarracks () {
		Debug.Log ("Barracks Built");
		type = "mil";
		level = 2;
		HandleBuild (buildingPrefabs [2]);
	}

	public void BuildCastle () {
		Debug.Log ("Castle Built");
		type = "mil";
		level = 3;
		HandleBuild (buildingPrefabs [3]);
	}

	public void BuildParish () {
		Debug.Log ("Parish Built");
		type = "rel";
		level = 1;
		HandleBuild (buildingPrefabs [0]);
	}

	public void BuildChurch () {
		Debug.Log ("Church Built");
		type = "rel";
		level = 2;
		HandleBuild (buildingPrefabs [0]);
	}

	public void BuildCathedral () {
		Debug.Log ("Cathedral Built");
		type = "rel";
		level = 3;
		//HandleBuild (buildingPrefabs [0]);
		HandleBuild (buildingPrefabs [2]);
	}

	private void HandleBuild (GameObject placeablePrefab) {
		if (placeableObject == null) {
			placeableObject = Instantiate (placeablePrefab);
		}
		else {
			Destroy(placeableObject);;
		}
	}
}
	