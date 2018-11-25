using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFruit : MonoBehaviour {

    public AudioSource collectSound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        if (ScoringSystem.bonusTime == false)
        {
            ScoringSystem.theScore += 20;
            Destroy(gameObject);
        }
        else
        {
            ScoringSystem.theScore += 40;
            Destroy(gameObject);
        }

    }
}
