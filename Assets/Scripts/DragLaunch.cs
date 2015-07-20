using UnityEngine;
using System.Collections;
[RequireComponent (typeof(Ball))]
public class DragLaunch : MonoBehaviour {

    private Vector3 dragStart;
    private Vector3 dragEnd;
    private float startTime;
    private float endTime;
    private Ball ball;
    private float xmax = 45;
    private float xmin = -45;
    



	// Use this for initialization
	void Start () {
    ball = GetComponent<Ball>();
	}

    public void MoveStart(float amount) {
        //move ball left or right with arrows, check to see if ball is not in play first
        if ( ! ball.inPlay)
        
        ball.transform.Translate(new Vector3(amount, 0, 0));

        //limit the arrows to only be able to move the ball on the actual alley, -45(xmin) for the left side and 45 for the right side (xmax) 
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, xmin, xmax), transform.position.y, transform.position.z);

    }

    public void DragStart(){
        // Capture time and position of drag start or mouse click

        dragStart = Input.mousePosition;    //Get Mouse Position
        startTime = Time.time;              //Get the start time

        }

    public void DragEnd(){
        //Launch the ball
       
        dragEnd = Input.mousePosition;
        endTime = Time.time;

        float dragDuration = endTime - startTime;

        float launchSpeedX = (dragEnd.x - dragStart.x) / dragDuration;   //Find distance and duration/length of time of mouse movement X direction
        float launchSpeedZ = (dragEnd.y - dragStart.y) / dragDuration;   // Same as above but Since the mouse movement to go forward is up and down we take the y values, but we are moving the ball in the Z values to go down the lane.
        if (!ball.inPlay) { 
            Vector3 launchVelocity = new Vector3(launchSpeedX, 0, launchSpeedZ);
            ball.Launch(launchVelocity);
             }
        }
}
