/*
 * Josh Beck
 * Challenge 1
 * Sets game over status when player goes out of bounds
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnOOB : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.gameOver = true;
        }
    }
}
