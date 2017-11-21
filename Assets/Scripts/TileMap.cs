using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter))] // Check if exists. Sanity Check.
[RequireComponent(typeof(MeshRenderer))] // Check if exists. Sanity Check.
[RequireComponent(typeof(MeshCollider))] // Check if exists. Sanity Check. 
// If any of those don't exist, will be created in the model

public class TileMap : MonoBehaviour {
	public int sizeX = 8;
	public int sizeZ = 8;
	public float tileSize = 1.0f;
	// Use this for initialization
	void Start () {
		BuildMesh ();
	}

	public void BuildMesh() {

		int vsizeX = sizeX + 1;
		int vsizeZ = sizeZ + 1;

		int numVerts = vsizeX * vsizeZ;
		int numTiles = sizeX * sizeZ;
		int numTris = numTiles * 2;

		// Generate mesh data
		Vector3[] vertices = new Vector3[numVerts];
		Vector3[] normals = new Vector3[numVerts];
		Vector2[] uv = new Vector2[numVerts];

		int[] triangles  = new int[numTris*3]; // always clockwise. 
		int x, z;

		for (z = 0; z < vsizeZ; z++) {
			for (x = 0; x < vsizeX; x++) {
				vertices [z * vsizeX + x] = new Vector3 (x * tileSize, Random.Range(-.2f, .2f), z * tileSize);
				normals [z * vsizeX + x] = Vector3.up;
				uv [z * vsizeX + x] = new Vector2 ((float)x/vsizeX, (float)z / vsizeZ);
			}
		}

		for (z = 0; z < sizeZ; z++) {
			for (x = 0; x < sizeX; x++) {
				int squareIndex = z * sizeX + x;
				int triOffset = squareIndex * 6;
				triangles[triOffset + 0] = z * vsizeX + x + 0;
				triangles[triOffset + 2] = z * vsizeX + x + vsizeX + 1;
				triangles[triOffset + 1] = z * vsizeX + x + vsizeX + 0;

				triangles[triOffset + 3] = z * vsizeX + x + 0;
				triangles[triOffset + 5] = z * vsizeX + x + 1;
				triangles[triOffset + 4] = z * vsizeX + x + vsizeX + 1;
			}
		}

		// Create a new Mesh and populate with data
		Mesh mesh = new Mesh ();
		mesh.vertices = vertices;
		mesh.triangles = triangles;
		mesh.normals = normals;
		mesh.uv = uv;

		// Assign mesh to filter/renderer/collider
		MeshFilter mesh_filter = GetComponent<MeshFilter> ();
		//MeshRenderer mesh_renderer = GetComponent<MeshRenderer>();
		MeshCollider mesh_collider = GetComponent<MeshCollider>();

		mesh_filter.mesh = mesh;
		mesh_collider.sharedMesh = mesh;

	}
	// Update is called once per frame
	void Update () {
		
	}
}
