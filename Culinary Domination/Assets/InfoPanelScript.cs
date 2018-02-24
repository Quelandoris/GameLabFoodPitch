using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelScript : MonoBehaviour {

	public Text ownerT;
	public Text incomeT;
	Player pla;
	public LandTile target; 

	// Use this for initialization
	void Start () {
		pla = FindObjectOfType<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (target.owner.PlayerRole == Player.PlayerRoles.Burger) {
			ownerT.text = "Donald McRonald";
		} else if (target.owner.PlayerRole == Player.PlayerRoles.Enchilada) {
			ownerT.text = "Daniella Martinez";
		} else if (target.owner.PlayerRole == Player.PlayerRoles.French) {
			ownerT.text = "Gordon Ducasse";
		} else {
			ownerT.text = "None";
			Debug.Log ("Error, InfoPanelScript, target tile has no owner");
		}
		//Update Income to be the tile's income
		if (target != null) {
			if (target.income > 0) {
				incomeT.text = "+ $" + target.income.ToString ();
			} else if (target.income < 0) {
				incomeT.text = "- $" + target.income.ToString ();
			} else if (target.income == 0) {
				incomeT.text = "$0";
			} else {
				incomeT.text = "Something broke";
				Debug.Log ("Error in InfoPanelScript Update event");
			}
		}
	}
}
