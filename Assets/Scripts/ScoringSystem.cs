using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour {

    public GameObject scoreText;
    public static int theScore;
    public static bool bonusTime; 
    void Start()
    {
        theScore = 100;
        bonusTime = false;
    }
    void Update()
    {
        scoreText.GetComponent<Text>().text = "HEALTH: " + theScore;
        if(theScore <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
