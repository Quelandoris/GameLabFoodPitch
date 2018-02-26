using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour {
    public bool EnemyTurn;
    public int Tiles = 0;
    public LandTile[] objects;
    public Sprite AISprite;
	Player AIpla;


    // Use this for initialization
    void Start () {
		AIpla = this.GetComponent<Player> ();
	}
	void OnEnable(){
		EventManager.TurnChange += turnChange;
	}
	void OnDisable(){
		EventManager.TurnChange -= turnChange;
	}
	
	// Update is called once per frame
	void Update () {
        if (EnemyTurn == true)
        {
            switch (Tiles)
            {
                case 0:
                    Purchase(objects[Tiles]);
                    break;

                case 1:
                    Purchase(objects[Tiles]);

                    break;

                case 2:
                    Purchase(objects[Tiles]);

                    break;

                case 3:
                    Purchase(objects[Tiles]);

                    break;

                case 4:
                    Purchase(objects[Tiles]);

                    break;

            }

        }
	}
	void Purchase(LandTile Current)
    {
        Current.owner = AIpla;
        EnemyTurn = false;
        Current.GetComponent<LandTile>().hire1 = AIpla;
        Current.GetComponent<LandTile>().hire3 = AIpla;
        Tiles++;
        Current.GetComponent<SpriteRenderer>().sprite = AISprite;

    }
	void turnChange(){
		EnemyTurn = true;
	}
}
