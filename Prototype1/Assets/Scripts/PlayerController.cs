/*
 * Josh Beck
 * Prototype 1
 * Moves player with input
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float turnSpeed;

    public float horizontalInput;
    public float forwardInput;


    // Update is called once per frame
    void Update()
    {

        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Move forward with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //Rotate player with horizontal input
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);

    }
}
