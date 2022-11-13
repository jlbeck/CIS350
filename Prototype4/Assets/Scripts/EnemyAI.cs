/*
 * Josh Beck
 * Prototype 4
 * Controls Enemy AI
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{

    public Rigidbody enemyRb;
    public GameObject player;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        //Add force toward direction from the player to the enemy
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }
}
