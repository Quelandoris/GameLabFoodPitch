using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandTile : MonoBehaviour {

	public GameObject owner;
	public float accessibility;
	public float cost;
	public float size;
	public Transform uiPanel;
	bool mousing=false;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		if (mousing) {
			uiPanel.position = Input.mousePosition;
		}
	}

	//on mouse over, show stats for the object
	void OnMouseEnter(){
		mousing = true;
		uiPanel.gameObject.SetActive (true);
	}
	void OnMouseExit(){
		mousing = false;
		uiPanel.gameObject.SetActive (false);
	}
}
