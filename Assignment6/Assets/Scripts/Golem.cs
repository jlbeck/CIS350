﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golem : Enemy
{

    protected int damage;

    protected override void Awake()
    {
        base.Awake();
    }

    // Start is called before the first frame update
    void Start()
    {
        base.Start();
        health = 120;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
