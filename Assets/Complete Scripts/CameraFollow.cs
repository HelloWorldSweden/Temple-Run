using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float zOffset = 6;
    public float yOffset = 4;
    public Vector3 cameraLookAtOffset = new Vector3(0, 3, 0);
    private float slideSpeed = 6;
    private float yMoveFactor = 0.25f;
    private float yLookFactor = 0.75f;
    private float lookSpeed = 8;


	// Update is called once per frame
	void Update () {
        Vector3 targetCameraPos = target.position - target.forward * zOffset + new Vector3(0, yOffset, 0);
        Vector3 deltaPos = targetCameraPos - transform.position;
        Vector3 moveVec = deltaPos * slideSpeed * Time.deltaTime; ;
        moveVec.y *= yMoveFactor;
        transform.position += moveVec;

        Vector3 cameraTarget = target.position + cameraLookAtOffset;
        Vector3 dir = cameraTarget - transform.position;
        dir.y *= yLookFactor;
        Quaternion rot = Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, lookSpeed * Time.deltaTime);
       
    }


}
