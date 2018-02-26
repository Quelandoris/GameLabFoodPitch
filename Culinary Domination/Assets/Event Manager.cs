using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {


	//Events
	public delegate void TurnEvent();
	public static event TurnEvent TurnChange; //Call whenever a turn ends
	// Use this for initialization
	void OnEnable() {
		
	}
	
	public static void EndTurn(){
		EventManager.TurnChange ();
	}
}
