using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeepleInventory : MonoBehaviour {
	public int type;
	/* INVENTORY ITEM CODES
	 * 0 - No Items
	 * 1 - Wood
	 * 2 - Stone
	 * 3 - Food
	 * 4 - Wheat
	 * 5 - Flour
	 * 6 - Ore
	 * 7 - Iron
	 * 8 - Tools
	 */
	public int ammount;

	public void Take(BuildingInventory bInv, int number, int itemCode){
		bInv.inventory [itemCode] -= number;
		type = itemCode;
		ammount = number;
	}

	public void Place(BuildingInventory bInv, int number, int itemCode){
		bInv.inventory [itemCode] += number;
		ammount -= number;
		if (ammount == 0) {

		}
	}
}
