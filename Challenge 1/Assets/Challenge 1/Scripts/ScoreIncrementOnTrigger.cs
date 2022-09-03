/*
 * Josh Beck
 * Challenge 1
 * Adds 1 to score when player contacts new trigger for the first time
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrementOnTrigger : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
