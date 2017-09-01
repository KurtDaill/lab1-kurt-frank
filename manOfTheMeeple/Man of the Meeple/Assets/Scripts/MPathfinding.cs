using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class MPathfinding : MonoBehaviour {

	Seeker seeker;
	CharacterController characterController;

	Path path;
	Transform target;
	int currentWaypoint;
	float margin, speed;

	float repathTime = 0.5F;
	float lastRepath = -999;
	Vector3 dir;

	public float GetMargin(){
		return margin;
	}

	public void SetTarget(Transform newTarget){
		target = newTarget;
	}

	public void OnPathComplete (Path p) {
		Debug.Log(Time.time + ": A path was calculated. Did it fail with an error? " + p.error);
		if (!p.error) {
			path = p;
			// Reset the waypoint counter so that we start to move towards the first point in the path
			currentWaypoint = 0;
		}
	}

	// Use this for initialization
	void Start () {
		margin = 0.4F;
		speed = 2;
		seeker = this.GetComponent<Seeker> ();
		characterController = this.GetComponent<CharacterController> ();
	}

	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, target.position) < margin) {
			transform.LookAt (Vector3.zero);
			return;
		}
		if (Time.time - lastRepath >= repathTime) {
			lastRepath = Time.time;
			seeker.StartPath (transform.position, target.position, OnPathComplete);
			currentWaypoint = 0;
		}

		if (path == null) {
			//Debug.Log (Time.time + ": No Path Found. Waiting for new Path");
			return;
		}

		if (Vector3.Distance (path.vectorPath[currentWaypoint], transform.position) < margin) {
			if(currentWaypoint != (path.vectorPath.Count - 1)) currentWaypoint++;
		}

		if (currentWaypoint != (path.vectorPath.Count - 1)) {
			dir = (path.vectorPath [currentWaypoint] - transform.position).normalized;
			transform.LookAt (path.vectorPath [currentWaypoint]);
		} else {
			dir = (target.position - transform.position).normalized;
			transform.LookAt (target.position);
		}
		transform.rotation.eulerAngles.Set (0F, transform.rotation.eulerAngles.y, 0F);


		dir *= speed;
		characterController.SimpleMove(dir);
	}
}
