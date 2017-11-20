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
	}

	public void BuildApto () {
		Debug.Log ("Apto Built");	
	}

	public void BuildCondo () {
		Debug.Log ("Condo Built");	
	}

	public void BuildTower () {
		Debug.Log ("Tower Built");	
	}

	public void BuildBarracks () {
		Debug.Log ("Barracks Built");	
	}

	public void BuildCastle () {
		Debug.Log ("Castle Built");	
	}

	public void BuildParish () {
		Debug.Log ("Parish Built");	
	}

	public void BuildChurch () {
		Debug.Log ("Church Built");	
	}

	public void BuildCathedral () {
		Debug.Log ("Castle Built");	
	}

}
