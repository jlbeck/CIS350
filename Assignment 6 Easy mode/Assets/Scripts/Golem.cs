/*
 * Josh Beck
 * Assignment 6
 * A subclass of enemies with modified health stats
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{

    protected int damage;

    protected override void Awake()
    {
        base.Awake();
        health = 120;
        GameManager.Instance.score += 2;
    }

    protected override void Attack(int amount)
    {
        Debug.Log("Enemy Attacks");
    }

    public override void TakeDamage(int amount)
    {
        Debug.Log("You took " + amount + " points of damage!");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
