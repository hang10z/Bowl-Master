using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public bool inPlay = false;
    public Rigidbody bowlingBall;
    public Vector3 launchVelocity;
    private AudioSource throwSound;
    


	// Use this for initialization
	void Start () 
        {
        bowlingBall = GetComponent<Rigidbody>();    //Get the Rigidbody from attached Ball
        bowlingBall.useGravity = false;             //Turn off Gravity so we can move the ball around before throwing
                          

        }

    public void Launch(Vector3 launchVelocity)
        {

        inPlay = true;                              // Ball has been launched and is in play

        bowlingBall.useGravity = true;              //Turn back on Gravity
        bowlingBall.velocity = launchVelocity;      // Set the ball velocity to the Mouse or Touch Input

        throwSound = GetComponent<AudioSource>();       //Get Sound
        throwSound.Play();                              //Play Sound
        }

}
