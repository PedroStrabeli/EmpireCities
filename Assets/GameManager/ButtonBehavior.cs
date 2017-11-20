using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour {
	[SerializeField]
	public GameObject house;

	private BuildingPlacement bpl;
	//public GameObject prefabButton;
	public GameObject[] buildings;

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
		//if (building) {
		//	if (Input.GetMouseButtonUp (0)) {
		//	}
		//	BuildBuilding ();
		//}
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
		if (this.house == null)
			this.house = Instantiate (house);
		else
			Destroy (house);
	}

	public void BuildApto () {
		Debug.Log ("Apto Built");
		bpl.setItem (buildings [0]);
	}

	public void BuildCondo () {
		Debug.Log ("Condo Built");
		bpl.setItem (buildings [0]);
	}

	public void BuildTower () {
		Debug.Log ("Tower Built");
		bpl.setItem (buildings [0]);
	}

	public void BuildBarracks () {
		Debug.Log ("Barracks Built");
		bpl.setItem (buildings [0]);
	}

	public void BuildCastle () {
		Debug.Log ("Castle Built");
		bpl.setItem (buildings [0]);
	}

	public void BuildParish () {
		Debug.Log ("Parish Built");
		bpl.setItem (buildings [0]);
	}

	public void BuildChurch () {
		Debug.Log ("Church Built");
		bpl.setItem (buildings [0]);
	}

	public void BuildCathedral () {
		Debug.Log ("Castle Built");
		bpl.setItem (buildings [0]);
	}

	public void BuildBuilding(){
		/*Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast (ray, out hitInfo, Mathf.Infinity)) {
			//TODO: normalize to the transform.worldToLocalMatrix

			int x = Mathf.FloorToInt (hitInfo.point.x);/// _tilemap.tileSize);
			int z = Mathf.FloorToInt (hitInfo.point.z);/// _tilemap.tileSize);

			currentMouseCoord.x = x;
			currentMouseCoord.z = z;
			//Debug.Log (currentTileCoord);
			cube.transform.position = currentMouseCoord;

		} else {
			cube.SetActive (false);// make cube disappear
		}
			//GameObject building = new GameObject();
			//cube.AddComponent.<>();
			//GameObject building = GameObject.FindGameObjectWithTag(tag);
			//Image img = building.AddComponent<Image>();
			//img.sprite = Resource.Load("torre", typeof(Sprite)) as Sprite; 
			//cube.transform.localScale = Vector3(1, 1, 1);
		//cube.transform.position = new Vector3(mousepos.x, 0, mousepos.z);

		//setBuildingInGrid (cube, mousepos);*/
	}

	public void setBuildingInGrid(GameObject gameobj, Vector3 mousepos) {
	
		//gameobj.transform.position = new Vector3(mousepos.x, mousepos.y, mousepos.z);
	}
}

	