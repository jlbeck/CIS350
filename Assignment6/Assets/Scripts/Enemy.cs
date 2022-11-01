using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    protected float speed;
    protected int health;

    protected virtual void Awake()
    {
        speed = 5f;
        health = 100;
    }

    // Start is called before the first frame update
    protected void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
