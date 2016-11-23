using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {

	Vector3 startScale;
	float startDist;
	float lastDist;
	
	void Start() {
		startScale = transform.localScale;
		startDist = Vector3.Distance(transform.position, Camera.main.transform.position); //transform.position.z - Camera.main.transform.position.z;
		lastDist = startDist;
	}
	
	void Update() {
		
		var dist = Vector3.Distance(transform.position, Camera.main.transform.position);
		if (dist != lastDist) {
			transform.localScale = startScale / startDist * dist;
			lastDist = dist;
		}
	}
}
