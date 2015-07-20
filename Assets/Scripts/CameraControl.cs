using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

    public Ball ball;           // Bowling Ball Object

    private Vector3 offset;     //offset between ball and camera

	// Use this for initialization
	void Start () {
    // We are attached to the camera, so to get the offset from the ball its the transform position
    // of the camera minus the ball transform position.

    offset = transform.position - ball.transform.position;

	
	}
	
	// Update is called once per frame
	void Update () {
    if (transform.position.z <= 1829f)  //If the camera has not reached the front pin yet
        {          
        transform.position = ball.transform.position + offset;
        }
	}
}
