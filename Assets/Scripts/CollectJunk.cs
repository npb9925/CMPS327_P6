using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectJunk : MonoBehaviour
{

    public AudioSource collectSound;
    public AudioSource invincibletSound;

    // Update is called once per frame
    void Update()
    {
        // Rotate the object on the y axis. 
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        // If the Player has not picked up the MegaFruit, then 50 points are taken from the score.  
        if (ScoringSystem.bonusTime == false)
        {
            collectSound.Play();
            ScoringSystem.theScore -= 50;
            Destroy(gameObject);
        }

        // If the Player has picked up the MegaFruit, then no points are deducted and a special sound cue plays.   
        else
        {
            invincibletSound.Play();
            ScoringSystem.theScore += 0;
            Destroy(gameObject);
        }
    }
}
