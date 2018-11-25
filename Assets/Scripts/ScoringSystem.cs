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
        // Start with the score = 100
        theScore = 100;
        // the Player has not collected the MegaFruit, so he does not get bonus points
        bonusTime = false;
    }
    void Update()
    {
        // Update the score text on the HUD
        scoreText.GetComponent<Text>().text = "HEALTH: " + theScore;

        // If the score drops below or is equal to 0, then Game Over
        if(theScore <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
        // If the score reaches over 300 points, the player wins
        if (theScore >= 300)
        {
            SceneManager.LoadScene("GameWin");
        }
        if (bonusTime == true)
        {
            StartCoroutine(Invincible());
        }
    }
    IEnumerator Invincible()
    {
        // Changes the globalVariable "bonusTime" to "true", meaning double points are rewarded when picking up fruit and no points are deducted when collecting junk food.
        print("Wait for seconds");
        yield return new WaitForSeconds(10f);
        print("Waited");
        ScoringSystem.bonusTime = false;
        print("bonusTime = False");
    }
}
