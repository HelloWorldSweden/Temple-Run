using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteDangerZone : MonoBehaviour {

    public CompleteMainControllScript mainController;

    void OnCollisionEnter(Collision other) {
        mainController.setGameOver();
    }

}
