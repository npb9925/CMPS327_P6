using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectJunk : MonoBehaviour
{

    public AudioSource collectSound;
    public AudioSource invincibletSound;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        if (ScoringSystem.bonusTime == false)
        {
            collectSound.Play();
            ScoringSystem.theScore -= 50;
            Destroy(gameObject);
        }
        else
        {
            invincibletSound.Play();
            ScoringSystem.theScore += 0;
            Destroy(gameObject);
        }
    }
}
