using UnityEngine;
using System.Collections;

public class LogInfo : MonoBehaviour {

	// Use this for initialization
	void Start () {
        float location = 3.0f; // Distance in meters
        float homeLocation = 2.4f;
        float distance = homeLocation - location;
        print("Welcome to Go Home!");
        print("A game were you need to find your way back home");
        print("Distance: ");
        print(distance);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
