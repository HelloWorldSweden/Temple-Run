using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnZone : MonoBehaviour {

    public bool canTurnLeft = true;
    public bool canTurnRight = true;

    private bool hasDoneTurn = false;
    private bool hasCurrentPlayer = false;
    private PlayerController thePlayer;

	void Update () {
		if(hasCurrentPlayer && hasDoneTurn == false) {
            if (canTurnLeft && Input.GetKeyDown(KeyCode.LeftArrow)) {
                thePlayer.makeLeftTurn();
                hasDoneTurn = true;
            }

            if (canTurnRight && Input.GetKeyDown(KeyCode.RightArrow)) {
                thePlayer.makeRightTurn();
                hasDoneTurn = true;
            }
        }
	}
    

    // Kod för att kolla om spelaren för tillfället befinner sig i vår TurnZone
    private void OnTriggerExit(Collider Other) {hasCurrentPlayer = false;}
    private void OnTriggerEnter(Collider Other){
        if(Other.tag == "Player") {
            thePlayer = Other.gameObject.GetComponent<PlayerController>();
            hasCurrentPlayer = true;
        }
    }
}
