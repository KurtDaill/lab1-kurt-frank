using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Order{
	public GameObject srcObj, destObj;
	public Transform source, destination;
	public BuildingInventory srcInventory, destInventory;
	public int rType, rAmmount, waitTimer;

	public Order(GameObject src, GameObject dest, int type, int ammount, int timer){
		srcObj = src;
		destObj = dest;
		source = src.transform;
		destination = dest.transform;
		srcInventory = src.GetComponent<BuildingInventory> ();
		destInventory = dest.GetComponent<BuildingInventory> ();
		rType = type;
		rAmmount = ammount;
		waitTimer = timer;
	}
}