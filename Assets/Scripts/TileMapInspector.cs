using UnityEditor;
using System.Collections;
using UnityEngine;

[CustomEditor(typeof(TileMap))]
public class TileMapInspector : Editor {
	float v = .5f;

	public override void OnInspectorGUI() {
		//base.OnInspectorGUI();
		DrawDefaultInspector();

		// this below does nothing, but good to know
		EditorGUILayout.BeginVertical ();
		v = EditorGUILayout.Slider (v, 0, 2.0f);
		EditorGUILayout.EndVertical();


		if (GUILayout.Button ("Regenerate")) {
			TileMap tileMap = (TileMap)target;
			tileMap.BuildMesh ();
		}
	}
}
