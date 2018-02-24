using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//Vars
	public enum PlayerRoles{
	None, Burger, Enchilada, French
	}
	public PlayerRoles PlayerRole = PlayerRoles.None;
	public Sprite[] Headshot;
	public int Money;
	public int Research;
	//research target
	//public research researchTarget
	void start(){
		Research = 0;
	}
}
