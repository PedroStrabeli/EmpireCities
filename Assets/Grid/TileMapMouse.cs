using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TileMap))]
public class TileMapMouse : MonoBehaviour {	

	TileMap _tilemap;
	Vector3 currentTileCoord;
	public Transform selectionCube;

	void Start() {
		_tilemap = GetComponent<TileMap> ();
	}
		
	void OnGUI () {
		/*if (Input.GetMouseButtonUp (0)) {
			
			/*Vector3 mousepos = Input.mousePosition;
			Debug.Log ("pressed "+mousepos.x+" "+mousepos.y+" "+mousepos.z);
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.transform.position = new Vector3(mousepos.x, mousepos.y, mousepos.z); 

			//GUI.Button(new Rect(mousepos.x (+25), mousepos.y (-15), 50, 30), "Click") ; 

		} */
	}
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hitInfo;
		if (Physics.Raycast (ray, out hitInfo, Mathf.Infinity)) {
			//TODO: normalize to the transform.worldToLocalMatrix

			int x = Mathf.FloorToInt (hitInfo.point.x / _tilemap.tileSize);
			int z = Mathf.FloorToInt (hitInfo.point.z / _tilemap.tileSize);

			currentTileCoord.x = x;
			currentTileCoord.z = z;
			//Debug.Log (currentTileCoord);
			selectionCube.transform.position = currentTileCoord;

		} else {
			// make cube disappear
		}

	}
}
