using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	//Vars
	public enum PlayerRoles{
	None, Burger, Enchilada, French
	}
	public PlayerRoles PlayerRole = PlayerRoles.None;
	public Sprite[] Headshot;
	public int Money;
	public int income;
	public Text MoneyT,IncomeT;
	//research target
	//public research researchTarget
	void start(){
		income = 0;
	}
	void OnEnable(){
		EventManager.TurnChange += TurnChange;
	}
	void OnDisable(){
		EventManager.TurnChange -= TurnChange;
	}
	void Update(){
		//UI elements
		MoneyT.text="$" + Money.ToString();
		if (income > 0) IncomeT.text = "+ $" + Mathf.Abs (income).ToString ();
		else if (income < 0) IncomeT.text = "- $" + Mathf.Abs (income).ToString ();
		else IncomeT.text = "$0";
	}
	void TurnChange(){
		Money += income;
	}
}
