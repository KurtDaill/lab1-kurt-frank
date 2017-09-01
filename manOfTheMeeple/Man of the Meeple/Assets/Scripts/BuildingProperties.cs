using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingProperties : MonoBehaviour {
	public float xSize, zSize, ySize;
	public string buildingName;
	GameObject[] workers;
	public int workerLimit;
	void Start () {
		workers = new GameObject[workerLimit];
	}

	void Update () {
		
	}
}
