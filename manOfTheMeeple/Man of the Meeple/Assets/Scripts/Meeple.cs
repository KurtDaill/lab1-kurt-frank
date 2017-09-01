using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meeple : MonoBehaviour {
	MeepleInventory inventory;
	MPathfinding pathfinder;
	Order currentOrder, parentOrder;
	bool isAssigned;

	public void GiveOrder (Order ord, Order prntOrd){
		currentOrder = ord;
		parentOrder = prntOrd;
		pathfinder.SetTarget (currentOrder.source);
		isAssigned = true;
	}

	public bool IsAvail(){
		return !isAssigned;
	}

	void Start () {
		inventory = this.GetComponent<MeepleInventory> ();
		pathfinder = this.GetComponent<MPathfinding> ();
	}
		

	void Update () {
		if (!isAssigned)
			return;
		
		if (currentOrder == null) 
			return;
		
		if (Vector3.Distance (this.transform.position, currentOrder.destination.position) <= pathfinder.GetMargin ()) {
			if (inventory.ammount == currentOrder.rAmmount) {
				inventory.Place (currentOrder.destInventory, currentOrder.rAmmount, currentOrder.rType);
				return;
			}
			if (inventory.ammount == 0) {
				isAssigned = false;
				return;
			}

		}

		if (Vector3.Distance (this.transform.position, currentOrder.source.position) <= pathfinder.GetMargin ()) {
			if (inventory.ammount == 0) {
				inventory.Take (currentOrder.srcInventory, currentOrder.rAmmount, currentOrder.rType);
				return;
			}
			pathfinder.SetTarget (currentOrder.destination);
			return;
		}
	}
}
