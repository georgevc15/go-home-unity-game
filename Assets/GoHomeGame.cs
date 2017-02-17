﻿using UnityEngine;
using System.Collections;

public class GoHomeGame : MonoBehaviour
{

    public Vector2 playerLocation; // Distance in meters (x,y)
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
        UpdateMovement(KeyCode.LeftArrow, new Vector2(-1, 0));
        UpdateMovement(KeyCode.RightArrow, new Vector2(1, 0));
        UpdateMovement(KeyCode.UpArrow, new Vector2(0, 1));
        UpdateMovement(KeyCode.DownArrow, new Vector2(0, -1));
    }

    private void UpdateMovement(KeyCode kc, Vector2 movementVector) {
        if (Input.GetKeyDown(kc))
        {
            playerLocation = playerLocation + movementVector;
            PrintDistanceToHome();
        }
    }

    private void PrintDistanceToHome()
    {
        Vector2 pathToHome = homeLocation - playerLocation;
        print("Distance to home " + pathToHome.magnitude);
        if (playerLocation == homeLocation)
        {
            print("You have arrived home! ");
        }
    }

}