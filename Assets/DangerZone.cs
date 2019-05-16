using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour {

    public CompleteMainControllScript mainController;

    void OnCollisionEnter(Collision collision) {
        if(collision.collider.tag == "Player") {
            mainController.setGameOver();
        }
    }

}
