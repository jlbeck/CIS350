/*
 * Josh Beck
 * Assignment 6
 * Implements a door blocker as a specific type of target
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBlocker : Target
{

    public Target targetOfDoorBlocker;
    private void Awake()
    {
        health = 10;
        targetOfDoorBlocker = gameObject.GetComponent<Target>();
    }

    private void DoorBlockerSpawns(Target targetOfDoorBlocker)
    {
        Debug.Log("A blocker rises up to block the door");
    }
    
    
}
