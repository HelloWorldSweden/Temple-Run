using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody theRigid;
    public float moveSpeed = 8;
    public float jumpSpeed = 8;
    public Animator theAnimator;

    private bool isGameOver = false;
	
	// Kod som körs varje updatering och som får spelaren att konstant springa framåt samt att kunna hoppa.
	void Update () {
        if(isGameOver == false) {
            float yVelocity = theRigid.velocity.y;
            if (Input.GetKeyDown(KeyCode.Space) && isGrounded())
                yVelocity = jumpSpeed;

            theRigid.velocity = transform.forward * moveSpeed + new Vector3(0, yVelocity, 0);
        }
	}

    // Anropas när spelaren har krockat med ett objekt och resulterar i att vi slutar springa.
    public void setGameOver() {
        theAnimator.SetBool("IsDead", true);
        isGameOver = true;
    }

    // Kod som kallas när vi befinner oss i en TurnZone och vill göra en sväng
    public void makeLeftTurn() {transform.localEulerAngles += new Vector3(0, -90, 0);}
    public void makeRightTurn() {transform.localEulerAngles += new Vector3(0, 90, 0);}

    // Kod som används för att kolla om spelaren står på marken eller inte
    private bool isGrounded() {
        RaycastHit hitInfo;
        Ray r = new Ray();
        if(Physics.Raycast(transform.position + new Vector3(0, 1, 0), Vector3.down, out hitInfo, 1.2f)) {
            return true;
        }
        return false;
    }
}
