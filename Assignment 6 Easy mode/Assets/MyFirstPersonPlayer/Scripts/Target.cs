/*
 * Josh Beck
 * Assignment 5B
 * Controls obstacle health and destroys upon running out of health
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {

        health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }


    void Die()
    {
        Destroy(gameObject);
    }

}
