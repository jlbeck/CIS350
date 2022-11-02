/*
 * Josh Beck
 * Assignment 6
 * Interface for objects which can take damage
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    void TakeDamage(int amount);
}
