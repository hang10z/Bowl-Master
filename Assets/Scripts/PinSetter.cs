using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour {
    public Text pinCountDisplay;
    bool ballEnteredBox = false;

    public float distanceToRaise = 40f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

    pinCountDisplay.text = CountStanding().ToString();

	}

    int CountStanding(){
    int standing = 0;
        foreach (Pin pin in GameObject.FindObjectsOfType<Pin>()){
            if (pin.IsStanding()){
                standing++;
                }
        }
        return standing;
    }

    void OnTriggerExit(Collider col)
        { 
        GameObject thingLeft = col.gameObject;
        if (thingLeft.GetComponent<Pin>())
            {
            print("Pin Left");
            Destroy(thingLeft);
            }
        if (thingLeft.GetComponent<Ball>())
            {
            print("Ball Green");
            pinCountDisplay.color = Color.green;
            }
        }

   void OnTriggerEnter(Collider col) {
   GameObject thingHit = col.gameObject;
        if (thingHit.GetComponent <Ball>())
            {
            print("Ball Red");
            pinCountDisplay.color = Color.red;
            ballEnteredBox = true;
            }

        }

   public void RaisePins()
       {
       Debug.Log("Raise Pins Called");
       foreach (Pin pin in GameObject.FindObjectsOfType<Pin>()) {
            if (pin.IsStanding()) {
            pin.transform.Translate(gameObject.transform.position.x, distanceToRaise, gameObject.transform.position.z);
            }
       }
   }

   public void LowerPins()
       {
       Debug.Log("Lower Pins Called");
       }

   public void RenewPins()
       {
       Debug.Log("Renew Pins Called");
       }
}
