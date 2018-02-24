using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LandTile : MonoBehaviour
{

	public Player owner;
	Player player;
	public float accessibility;
	public float cost;
	public Transform uiPanel;
	public Text ownerT;
	public Text costT;
	public Text accT;
	public GameObject ConfirmWindow;
	public GameObject InfoWindow;
	public int income;
	//How much money a tile gives its owner every turn
	bool mousing = false;

	// Use this for initialization
	void OnEnable ()
	{
		EventManager.TurnChange += TurnEnd;
		player = Camera.main.GetComponent<Player> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (mousing) {
			uiPanel.position = Input.mousePosition;
		}
	}

	//on mouse over, show stats for the object
	void OnMouseEnter ()
	{
		mousing = true;
		uiPanel.gameObject.SetActive (true);
		accT.text = accessibility.ToString () + "%";
		if (player.PlayerRole == Player.PlayerRoles.Burger)
			costT.text = "$" + (cost * 0.85).ToString ();
		else
			costT.text = "$" + cost.ToString ();

		if (owner == null)
			ownerT.text = "None";
		else if (owner.PlayerRole == Player.PlayerRoles.None)
			ownerT.text = "None";
		else if (owner.PlayerRole == Player.PlayerRoles.Burger)
			ownerT.text = "Donald McRonald";
		else if (owner.PlayerRole == Player.PlayerRoles.Enchilada)
			ownerT.text = "Daniella Martinez";
		else if (owner.PlayerRole == Player.PlayerRoles.French)
			ownerT.text = "Gordon Ducasse";
	}

	void OnMouseExit ()
	{
		mousing = false;
		uiPanel.gameObject.SetActive (false);
	}

	void OnMouseDown ()
	{
		if (owner == null) {
			ConfirmWindow.SetActive (true);
			ConfirmWindow.GetComponent<ButtonScript> ().curTile = this;
		} else {
			InfoWindow.SetActive (true);
		}
	}

	public void ConfirmationWindowConfirm ()
	{
		owner = FindObjectOfType<Player> ();
	}
	//Call when a turn ends
	void TurnEnd ()
	{
		//
	}
}
