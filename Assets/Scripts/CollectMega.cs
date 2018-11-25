using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class CollectMega : MonoBehaviour
{

    public AudioSource collectSound;
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
        ScoringSystem.bonusTime = true;
        collectSound.Play();
        ScoringSystem.theScore += 50;
        Destroy(gameObject);
    }
}
