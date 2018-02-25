using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanelScript : MonoBehaviour {

	public Text ownerT;
	public Text incomeT;
	public GameObject HireNone1,HireNone2,HireNone3,HireBurger1,HireBurger2,HireBurger3,HireEnchilada1,HireEnchilada2,HireEnchilada3,HireFrench1,HireFrench2,HireFrench3;
	public GameObject Producing1, Producing2, Producing3;
	Player pla;
	public LandTile target;


	// Use this for initialization
	void Start () {
		pla = FindObjectOfType<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
		//change owner name
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

		if (target != null) {
			//Update producing to match player
			if (target.owner.PlayerRole == Player.PlayerRoles.Burger) {
				Producing1.SetActive (true);
				Producing2.SetActive (false);
				Producing3.SetActive (false);
			}
			else if (target.owner.PlayerRole == Player.PlayerRoles.Enchilada) {
				Producing1.SetActive (false);
				Producing2.SetActive (true);
				Producing3.SetActive (false);
			}
			else if (target.owner.PlayerRole == Player.PlayerRoles.French) {
				Producing1.SetActive (false);
				Producing2.SetActive (false);
				Producing3.SetActive (true);
			}
			//Update Income to be the tile's income
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
			//Update panels for hirelings
			if (target.hire1.PlayerRole == Player.PlayerRoles.None) {
				HireNone1.SetActive (true);
				HireBurger1.SetActive (false);
				HireEnchilada1.SetActive (false);
				HireFrench1.SetActive (false);
			}
			else if (target.hire1.PlayerRole == Player.PlayerRoles.Burger) {
				HireNone1.SetActive (false);
				HireBurger1.SetActive (true);
				HireEnchilada1.SetActive (false);
				HireFrench1.SetActive (false);
			}
			else if (target.hire1.PlayerRole == Player.PlayerRoles.Enchilada) {
				HireNone1.SetActive (false);
				HireBurger1.SetActive (false);
				HireEnchilada1.SetActive (true);
				HireFrench1.SetActive (false);
			}
			else if (target.hire1.PlayerRole == Player.PlayerRoles.French) {
				HireNone1.SetActive (false);
				HireBurger1.SetActive (false);
				HireEnchilada1.SetActive (false);
				HireFrench1.SetActive (true);
			}
			if (target.hire2.PlayerRole == Player.PlayerRoles.None) {
				HireNone2.SetActive (true);
				HireBurger2.SetActive (false);
				HireEnchilada2.SetActive (false);
				HireFrench2.SetActive (false);
			}
			else if (target.hire2.PlayerRole == Player.PlayerRoles.Burger) {
				HireNone2.SetActive (false);
				HireBurger2.SetActive (true);
				HireEnchilada2.SetActive (false);
				HireFrench2.SetActive (false);
			}
			else if (target.hire2.PlayerRole == Player.PlayerRoles.Enchilada) {
				HireNone2.SetActive (false);
				HireBurger2.SetActive (false);
				HireEnchilada2.SetActive (true);
				HireFrench2.SetActive (false);
			}
			else if (target.hire2.PlayerRole == Player.PlayerRoles.French) {
				HireNone2.SetActive (false);
				HireBurger2.SetActive (false);
				HireEnchilada2.SetActive (false);
				HireFrench2.SetActive (true);
			}
			if (target.hire3.PlayerRole == Player.PlayerRoles.None) {
				HireNone3.SetActive (true);
				HireBurger3.SetActive (false);
				HireEnchilada3.SetActive (false);
				HireFrench3.SetActive (false);
			}
			else if (target.hire3.PlayerRole == Player.PlayerRoles.Burger) {
				HireNone3.SetActive (false);
				HireBurger3.SetActive (true);
				HireEnchilada3.SetActive (false);
				HireFrench3.SetActive (false);
			}
			else if (target.hire3.PlayerRole == Player.PlayerRoles.Enchilada) {
				HireNone3.SetActive (false);
				HireBurger3.SetActive (false);
				HireEnchilada3.SetActive (true);
				HireFrench3.SetActive (false);
			}
			else if (target.hire3.PlayerRole == Player.PlayerRoles.French) {
				HireNone3.SetActive (false);
				HireBurger3.SetActive (false);
				HireEnchilada3.SetActive (false);
				HireFrench3.SetActive (true);
			}
		}
	}

}
