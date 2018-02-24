using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public LandTile curTile;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void ConfirmButton () {
		curTile.ConfirmationWindowConfirm ();
		gameObject.SetActive (false);
	}
	public void CancelButton(){
		curTile = null;
		gameObject.SetActive (false);
	}
}
