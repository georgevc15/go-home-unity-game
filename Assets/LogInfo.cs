using UnityEngine;
using System.Collections;

public class LogInfo : MonoBehaviour {

    // Use this for initialization
    void Start() {
        float location = 2.4f; // Distance in meters
        float homeLocation = 2.4f;
        float distance = homeLocation - location;
        print("Welcome to Go Home!");
        print("A game were you need to find your way back home");
        print("Distance: ");
        print(distance);
        if (location > homeLocation)
        {
            print("Player needs to go backwards ");
        }

        if (location < homeLocation)
        {
            print("Player needs to go forward ");
        }

        if (location == homeLocation)
        {
            print("Player is at home ");
        }
    }
	// Update is called once per frame
	void Update () {
	
	}
}
