using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandTile : MonoBehaviour {

	public GameObject owner;
	public float accessibility;
	public float cost;
	public Transform uiPanel;
	public Text ownerT;
	public Text costT;
	public Text accT;
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
		accT.text = accessibility.ToString () + "%";
		costT.text = "$" + cost.ToString ();
		ownerT.text = owner.ToString ();
	}
	void OnMouseExit(){
		mousing = false;
		uiPanel.gameObject.SetActive (false);
	}
}
