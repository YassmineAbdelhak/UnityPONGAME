using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
    
    public Button PlayButton;
    public Button QuitButton;
	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
       
	}
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
