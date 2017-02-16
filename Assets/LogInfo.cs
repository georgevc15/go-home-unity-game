using UnityEngine;
using System.Collections;

public class LogInfo : MonoBehaviour
{

    public Vector2 location; // Distance in meters (x,y)
    public Vector2 homeLocation;

    // Use this for initialization
    void Start()
    {
        print("Welcome to Go Home!");
        print("A game were you need to find your way back home");
    }

    // Update is called once per frame
    void Update()
    {
        CheckForMovement(KeyCode.LeftArrow, new Vector2(-1, 0));
        CheckForMovement(KeyCode.RightArrow, new Vector2(1, 0));
        CheckForMovement(KeyCode.UpArrow, new Vector2(0, 1));
        CheckForMovement(KeyCode.DownArrow, new Vector2(0, -1));
    }

    void CheckForMovement(KeyCode kc, Vector2 movementVector) {
        if (Input.GetKeyDown(kc))
            {
                location = location + movementVector;
                Vector2 pathToHome = homeLocation - location;
                print("Distance to home " + pathToHome.magnitude);
                if (location == homeLocation)
                {
                    print("You have arrived home! ");
                }

              }
          }


   }

