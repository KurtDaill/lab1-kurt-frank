using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlStructure : MonoBehaviour {
	public GameObject[] buildingCode;
	public GameObject selectedBuilding;
	public GameObject constructionPlaceholder;
	public GameObject tempObject;
	public List<Meeple> meepleDirectory;
	public List<Meeple> idleMeeple;
	public BuildingProperties tempProp;
	public int selectedCode;
	Collider ground;
	public Material ghostMat;
	Ray ray;
	RaycastHit rayHit;
	/* Building Codes
	 * 0 - No Building Selected
	 * 1 - Road
	 * 2 - House
	 * 3 - Stockpile
	 * 4 - Farm
	 * 5 - Mill
	 * 6 - Baker
	 * 7 - Builder's Guild
	 */

	public void SelectBuilding(int code){
		GameObject.Destroy (selectedBuilding);
		selectedBuilding = GameObject.Instantiate (buildingCode [code]);
		selectedBuilding.GetComponent<MeshRenderer> ().material = ghostMat;
		selectedCode = code;
		tempProp = selectedBuilding.GetComponent<BuildingProperties> ();
	}

	private bool MouseIsClear(){
		if(Input.mousePosition.x <= 300 && Input.mousePosition.y <=121){
			return false;
		}
		return true;
	}

	void Start () {
		ground = GameObject.Find ("Plane").GetComponent<MeshCollider> ();
	}
	

	void Update () {
		if (selectedBuilding != null && MouseIsClear()) {
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(ground.Raycast(ray, out rayHit, 1000F)){
				selectedBuilding.transform.position = rayHit.point;

				//This code is designed to place the building's ghost. The weird if/else statement is there to compenstate for the fact that buildings with even dimensions will fit on the grid as is, but if they have odd dimensions they need to be moved slightly to do so.
				if (tempProp.xSize % 2 > 0) {
					selectedBuilding.transform.position = new Vector3 (Mathf.Round (selectedBuilding.transform.position.x) + 0.5F, buildingCode [selectedCode].transform.position.y, Mathf.Round (selectedBuilding.transform.position.z) + 0.5F);
				} else {
					selectedBuilding.transform.position = new Vector3 (Mathf.Round (selectedBuilding.transform.position.x), buildingCode [selectedCode].transform.position.y, Mathf.Round (selectedBuilding.transform.position.z));
				}
			}
			//This code places the ghost as a real instance, independant of the mouse.
			if (Input.GetMouseButtonDown(0)) {
				tempObject = GameObject.Instantiate (constructionPlaceholder, selectedBuilding.transform.position, selectedBuilding.transform.rotation);
				tempObject.transform.localScale = new Vector3 (tempProp.xSize, tempProp.ySize/2, tempProp.zSize);
			}
		}
	}
}
