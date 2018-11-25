using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Menu(string Menu)
    {
        SceneManager.LoadScene(Menu);
    }
    public void PlayFPP(string FPPGame)
    {
        SceneManager.LoadScene(FPPGame);
    }

    public void PlayTPP(string TPPGame)
    {
        SceneManager.LoadScene(TPPGame);
    }
    public void QuitGame()
    {
        Application.Quit();
    }

}
