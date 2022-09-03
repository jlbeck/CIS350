/*
 * Josh Beck
 * Prototype 1
 * Adds to score when entering trigger zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddScoreOnce : MonoBehaviour
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
