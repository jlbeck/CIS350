/*
 * Josh Beck
 * Challenge 1
 * Spins propeller at constant speed
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // rotate propeller at a constant rate
        transform.Rotate(Vector3.forward);
    }
}
