/*
 * Josh Beck
 * Prototype 1
 * Adds to score when entering trigger, unused
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this to player
public class PlayerEnterTrigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }

}
