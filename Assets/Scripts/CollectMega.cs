﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class CollectMega : MonoBehaviour
{
    public AudioSource collectSound;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object on the y axis. 
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        // Changes the globalVariable "bonusTime" to "true", meaning double points are rewarded when picking up fruit and no points are deducted when collecting junk food.
        ScoringSystem.bonusTime = true;
        collectSound.Play();
        // The Player is also rewarded 50 points.
        ScoringSystem.theScore += 50;
        Destroy(gameObject);
    }
}
