using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stockpile : MonoBehaviour {
	//NOTE: DEPUBLIC THESE WHEN TESTING IS OVER!
	public List<Meeple> activeWorkers;
	public List<Meeple> idleWorkers;
	public List<Meeple> workers;
	public List<Order> buildingRequests;
	public GameObject src, dest;
	int temp;

	void Start () {
		buildingRequests = new List<Order>();
		activeWorkers = new List<Meeple> ();
		Order newOrder = new Order (src, dest, 1, 9, 0);	
		buildingRequests.Add (newOrder);
	}
	

	void Update () {
		foreach(Meeple meep in activeWorkers){
			if (activeWorkers [0] == null)
				break;
			if (meep.IsAvail ()) {
				activeWorkers.Remove (meep);
				idleWorkers.Add (meep);
			}
		}

		foreach (Meeple meep in idleWorkers) {
			if (idleWorkers [0] == null)
				break;
			if (!meep.IsAvail ()) {
				idleWorkers.Remove (meep);
				activeWorkers.Add (meep);
			}
		}

		foreach (Order ord in buildingRequests) {
			if(idleWorkers[0] = null) 
				break;
			if (ord.rAmmount > 1) {
				buildingRequests.Remove (ord);
			} else {
				if (ord.rAmmount > 3) {
					temp = 3;
				} else {
					temp = ord.rAmmount;
				}
				idleWorkers [0].GiveOrder (new Order (ord.srcObj, ord.destObj, ord.rType, temp, ord.waitTimer), ord);
			}
		}

	}
}
