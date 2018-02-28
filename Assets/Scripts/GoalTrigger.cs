using UnityEngine;
using System.Collections;

public class GoalTrigger : MonoBehaviour {

    GoalKeep trigger; // = GetComponentInChildren<GoalKeep>();

    // Use this for initialization
    void Start () {
        //GoalKeep trigger = GetComponentInChildren<GoalKeep>();  
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        GoalKeep trigger = GetComponentInChildren<GoalKeep>();
        trigger.ExpectTrigger(collider);
    }
}
