using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public Vector3 velocity;
    public float gravity = -9.81f;
    public float gravityMultiplier = 2f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public bool isGrounded;

    private void Awake()
    {
        gravity *= gravityMultiplier;
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //add gravity to velocity
        velocity.y += gravity * Time.deltaTime;
        //we multiply gravity by Time.deltaTime again to simulate gravity accelerating in a free fall
        controller.Move(velocity * Time.deltaTime);

        //Check if the player is on the ground
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

    }
}
