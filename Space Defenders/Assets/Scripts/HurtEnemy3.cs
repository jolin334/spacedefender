﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy3 : MonoBehaviour
{
    public int damageToGive;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy 3")
        {
            other.gameObject.GetComponent<Enemy3Health>().HurtEnemy(damageToGive);
        }
    }
}
