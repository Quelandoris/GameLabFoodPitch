using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public LandTile curTile;
	Player player;
	public Text OwnerText;
	public Text income;
	public Text cost;
	public Sprite Blue,Red;

	// Use this for initialization
	void Start () {
		player = Camera.main.GetComponent<Player> ();
	}
	void Update(){
		if (curTile.owner == null) {
			OwnerText.text = "None";
			income.text = curTile.income.ToString ();
			cost.text = curTile.cost.ToString ();
		}
	}
	// Update is called once per frame
	public void ConfirmButton () {
		if (player.Money > curTile.cost) {
			player.Money -= curTile.cost;
			curTile.GetComponent<SpriteRenderer> ().color = Color.blue;
			curTile.ConfirmationWindowConfirm ();
			FindObjectOfType<Player> ().income += curTile.income;
			gameObject.SetActive (false);
		}
	}
	public void CancelButton(){
		curTile = null;
		gameObject.SetActive (false);
	}
}
