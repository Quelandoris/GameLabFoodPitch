using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HireScript : MonoBehaviour {

	LandTile tile;
	// Use this for initialization
	void OnEnable () {
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void HireButton(int c){
		tile = GetComponent<InfoPanelScript> ().target;
		tile.HireButton (c);
	}
}
