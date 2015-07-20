using UnityEngine;
using System.Collections;

public class Pin : MonoBehaviour {
    //public float standingThreshold = 5f;

	// Use this for initialization
	void Start () {
  
	}
	
	// Update is called once per frame
	void Update () {
    
	}

    //My Code to Check if Pin is standing
    public bool IsStanding(){
    if (gameObject.transform.eulerAngles.x > 280 && gameObject.transform.eulerAngles.x < 260)
        {
        return false;
        }
    else
        //if pin is 'free falling' and happens to be in upright correct position we check if
        // it is below the floor (y < - 1) or if it is "up in the air" (y > 1) because of the collision
        if ((gameObject.transform.position.y < -1) || (gameObject.transform.position.y > 1))
            {
            return false;
            }
    return true;
    }

    //public bool IsStanding1(){

        //Vector3 pinRotation = transform.rotation.eulerAngles;
        ////float tiltX = Mathf.Abs(pinRotation.x);
        //float tiltZ = Mathf.Abs(pinRotation.z);
        //if (tiltX > standingThreshold && tiltZ > standingThreshold)
          //  {
          //  return false;
           // }
        //else
          //  {
          //  return true;
          //  }      
   // }

}
