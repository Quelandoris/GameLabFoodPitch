using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactionPanelScript : MonoBehaviour {

	// Use this for initialization
	public void ChooseFaction (int newPlayerRole) {
		Player pla = Camera.main.GetComponent<Player>();
		if (newPlayerRole == 1) {
			pla.PlayerRole = Player.PlayerRoles.Burger;
		}
		else if (newPlayerRole == 2) {
			pla.PlayerRole = Player.PlayerRoles.Enchilada;
		}
		if (newPlayerRole == 3) {
			pla.PlayerRole = Player.PlayerRoles.French;
		}
		this.gameObject.SetActive (false);
	}

}
