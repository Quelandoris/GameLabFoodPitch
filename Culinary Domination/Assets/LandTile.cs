using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LandTile : MonoBehaviour
{

	public Player owner;
	Player player;
	public float accessibility;
	public int cost;
	public Transform uiPanel;
	public Text ownerT;
	public Text costT;
	public Text accT;
	public GameObject ConfirmWindow;
	public GameObject InfoWindow;
	public int income;
	//How much money a tile gives its owner every turn
	bool mousing = false;
	public Player hire1,hire2,hire3;


	// Use this for initialization
	void Start(){
		player = Camera.main.GetComponent<Player> ();
		hire1 = new Player();
		hire2 = new Player();
		hire3 = new Player();
		hire1.PlayerRole = Player.PlayerRoles.None;
		hire2.PlayerRole = Player.PlayerRoles.None;
		hire3.PlayerRole = Player.PlayerRoles.None;
	}
	void OnEnable ()
	{
		hire1.PlayerRole = Player.PlayerRoles.None;
		hire2.PlayerRole = Player.PlayerRoles.None;
		hire3.PlayerRole = Player.PlayerRoles.None;
		EventManager.TurnChange += TurnEnd;
		player = Camera.main.GetComponent<Player> ();
	}

	// Update is called once per frame
	void Update ()
	{
		if (mousing) {
			uiPanel.position = Input.mousePosition;
		}
		if(player==null) player = Camera.main.GetComponent<Player> ();
	}

	//on mouse over, show stats for the object
	void OnMouseEnter ()
	{
			mousing = true;
			uiPanel.gameObject.SetActive (true);
			accT.text = accessibility.ToString () + "%";
			if (player.PlayerRole == Player.PlayerRoles.Burger) costT.text = "$" + (cost * 0.85).ToString ();
			else costT.text = "$" + cost.ToString ();

			if (owner == null) ownerT.text = "None";
			else if (owner.PlayerRole == Player.PlayerRoles.None) ownerT.text = "None";
			else if (owner.PlayerRole == Player.PlayerRoles.Burger) ownerT.text = "Donald McRonald";
			else if (owner.PlayerRole == Player.PlayerRoles.Enchilada) ownerT.text = "Daniella Martinez";
			else if (owner.PlayerRole == Player.PlayerRoles.French) ownerT.text = "Gordon Ducasse";
	}

	void OnMouseExit ()
	{
			mousing = false;
			uiPanel.gameObject.SetActive (false);
	}

	void OnMouseDown ()
	{
		//if (!EventSystem.current.IsPointerOverGameObject ()) {
			if (owner == null) {
				ConfirmWindow.SetActive (true);
				InfoWindow.SetActive (false);
				ConfirmWindow.GetComponent<ButtonScript> ().curTile = this;
			}
			else {
				InfoWindow.SetActive (true);
				ConfirmWindow.SetActive (false);
				InfoWindow.GetComponent<InfoPanelScript> ().target = this;
			}
		//}
	}

	public void ConfirmationWindowConfirm ()
	{
		owner = FindObjectOfType<Player> ();
	}
	//Call when a turn ends
	void TurnEnd ()
	{
		cost += 20;
	}
	public void HireButton(int c){
		if (player.Money >= 150) {
			if (c == 1) {
				income += 10;
				player.income += 10;
				player.Money -= 150;
				hire1.PlayerRole = owner.PlayerRole;
				if (hire1.PlayerRole == Player.PlayerRoles.Burger) {
					player.income -= 4;
				}
				if (hire1.PlayerRole == Player.PlayerRoles.Enchilada) {
					player.income -= 5;
				}
				if (hire1.PlayerRole == Player.PlayerRoles.French) {
					player.income -= 7;
					player.income += 5;
				}
			}
			else if (c == 2) {
				income += 10;
				player.income += 10;
				player.Money -= 150;
				hire2.PlayerRole = owner.PlayerRole;
				if (hire2.PlayerRole == Player.PlayerRoles.Burger) {
					player.income -= 4;
				}
				if (hire2.PlayerRole == Player.PlayerRoles.Enchilada) {
					player.income -= 5;
				}
				if (hire2.PlayerRole == Player.PlayerRoles.French) {
					player.income -= 7;
					player.income += 5;
				}
			}
			else if (c == 3) {
				income += 10;
				player.income += 10;
				player.Money -= 150;
				hire3.PlayerRole = owner.PlayerRole;
				if (hire3.PlayerRole == Player.PlayerRoles.Burger) {
					player.income -= 4;
				}
				if (hire3.PlayerRole == Player.PlayerRoles.Enchilada) {
					player.income -= 5;
				}
				if (hire3.PlayerRole == Player.PlayerRoles.French) {
					player.income -= 7;
					player.income += 5;
				}
			}
		}
	}
}
