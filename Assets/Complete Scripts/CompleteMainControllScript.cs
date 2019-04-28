using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteMainControllScript : MonoBehaviour {

    public PlayerController thePlayer;
    public GameObject menuCanvas;
    private bool gameOver = false;

    // Anropas när spelaren kolliderar med en DangerZone
    public void setGameOver() {
        if(gameOver == false) {
            gameOver = true;
            thePlayer.setGameOver();
            menuCanvas.SetActive(true);
        }
    }

    // Anropas när spelaren klickar på Restart knappen i menyn
    public void restartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
