using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour {
    public bool EnemyTurn;
    public int Tiles = 0;
    public GameObject[] objects;
    public Sprite AISprite;


    // Use this for initialization
    void Start () {
		
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
    void Purchase(GameObject Current)
    {
        Player AI = new Player();
        AI.PlayerRole = Player.PlayerRoles.French;
        Current.GetComponent< LandTile > ().owner = AI;
        EnemyTurn = false;
        Current.GetComponent<LandTile>().hire1 = AI;
        Current.GetComponent<LandTile>().hire3 = AI;
        Tiles++;
        Current.GetComponent<SpriteRenderer>().sprite = AISprite;

    }
}
