/*
 * Josh Beck
 * Prototype 4
 * Controls player movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody playerRb;
    public float speed;
    float forwardInput;
    public bool hasPowerup;
    private float powerupStrength = 15.0f;

    private GameObject focalPoint;
    public GameObject powerupIndicator;
    public DisplayText displayText;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.FindGameObjectWithTag("FocalPoint");

        displayText = GameObject.FindGameObjectWithTag("GameText").GetComponent<DisplayText>();
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        //move powerup indicator around our player
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);

        if (gameObject.transform.position.y < -10)
        {
            displayText.gameOver = true;
        }
    }

    private void FixedUpdate()
    {
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Debug.Log("Player collided with: " + collision.gameObject.name + " with powerup set to " + hasPowerup);

            //Get a local reference to enemy RigidBody
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();

            //Set vector3 direction away from player
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position).normalized;

            //Add force away from player
            enemyRb.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }

}
