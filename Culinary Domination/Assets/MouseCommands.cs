﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCommands : MonoBehaviour {

	Ray ray;
	RaycastHit hit;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
		}
		else {
			
		}
	}
}
