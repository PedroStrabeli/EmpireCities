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
		if (Input.GetMouseButtonUp (0)) {
			Debug.Log ("pressed");
		}
	}
}
