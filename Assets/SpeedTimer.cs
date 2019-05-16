using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTimer : MonoBehaviour {

    public PlayerController player;
    float timer = 0;

	// Update is called once per frame
	void Update () {
        timer = timer + Time.deltaTime;

        if(timer < 5) {
            player.moveSpeed = 5;
        }
        else if (timer < 10) {
            player.moveSpeed = 10;
        }
        else if (timer < 20) {
            player.moveSpeed = 15;
        }




    }
}
