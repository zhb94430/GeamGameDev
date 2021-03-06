﻿using UnityEngine;
using System.Collections;

public class Select : MonoBehaviour {

	public float selectSpeed;
	public float mouseDepth;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update() {
		Vector3 mousePos = Input.mousePosition;
//		Vector3 mousePos = Camera.current.WorldToScreenPoint(transform.position);
		Vector3 actualPos = Camera.current.ScreenToWorldPoint (new Vector3 (mousePos.x, mousePos.y, mouseDepth+mousePos.y));
		transform.position = actualPos;
	}

	void FixedUpdate () {
		//Look into world to screen point


		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");

		//Set up variables for translating the selected object
		float selectX = mouseX * selectSpeed * Time.deltaTime;
		float selectZ = mouseY * selectSpeed * Time.deltaTime;

//		transform.Translate (selectX, 0, selectZ);

		//Add code for physics
//		rigidbody.AddForce (selectX, 0, selectZ);
		Vector3 displacement = new Vector3 (selectX, 2, selectZ);
		Vector3 zeroOut = new Vector3 (1, 0, 1);
		Matrix4x4 zeroOutMatrix = Matrix4x4.Scale (zeroOut);

		rigidbody.MovePosition (zeroOutMatrix.MultiplyPoint3x4(rigidbody.position) + displacement);
	}
}