using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonBehavior : MonoBehaviour {
	public GameObject prefabButton;
	//public RectTransform ParentPanel;
	//List<Action> funcList = new List<Action>();
	//List<String> nameList = new List<String>();

	public Transform _panel;
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
		Debug.Log ("House Built");
		BuildBuilding("houselvl1");
	}

	public void BuildApto () {
		Debug.Log ("Apto Built");
		BuildBuilding("houselvl2");
	}

	public void BuildCondo () {
		Debug.Log ("Condo Built");	
		BuildBuilding("houselvl3");
	}

	public void BuildTower () {
		Debug.Log ("Tower Built");
		BuildBuilding("torre");
	}

	public void BuildBarracks () {
		Debug.Log ("Barracks Built");
		BuildBuilding("torre");
	}

	public void BuildCastle () {
		Debug.Log ("Castle Built");
		BuildBuilding("torre");
	}

	public void BuildParish () {
		Debug.Log ("Parish Built");
		BuildBuilding("churchlvl1");
	}

	public void BuildChurch () {
		Debug.Log ("Church Built");
		BuildBuilding("churchlvl2");
	}

	public void BuildCathedral () {
		Debug.Log ("Castle Built");
		BuildBuilding("churchlvl3");
	}

	public void BuildBuilding(String tag){
		GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);	
		Vector3 mousepos = Input.mousePosition;

		if (Input.GetMouseButtonUp (0)) {
			//GameObject building = new GameObject();
			//cube.AddComponent.<>();
			//GameObject building = GameObject.FindGameObjectWithTag(tag);
			//Image img = building.AddComponent<Image>();
			//img.sprite = Resource.Load("torre", typeof(Sprite)) as Sprite; 
			//cube.transform.localScale = Vector3(1, 1, 1);
			cube.transform.position = new Vector3(mousepos.x, mousepos.y, mousepos.z);
		}
		setBuildingInGrid (cube, mousepos);
	}

	public void setBuildingInGrid(GameObject gameobj, Vector3 mousepos) {
	
		gameobj.transform.position = new Vector3(mousepos.x, mousepos.y, mousepos.z);
	}
}

	