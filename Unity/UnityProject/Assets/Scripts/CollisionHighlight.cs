using UnityEngine;
using System.Collections;

public class CollisionHighlight : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		
	}
	
	void OnTriggerEnter(Collider other) {
//		renderer.enabled = false;
		Behaviour h = (Behaviour)GetComponent("Halo");
		h.enabled = true;
	}

	void OnTriggerExit(Collider other) {
		Behaviour h = (Behaviour)GetComponent("Halo");
		h.enabled = false;
	}

}
