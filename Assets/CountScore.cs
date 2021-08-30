using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;// because we are using text which is a UI type
using UnityEngine.SceneManagement;

public class CountScore : MonoBehaviour {
    public AudioSource victory;
    public AudioSource bonus;
    public Text scoreboard;
    private int player01Score = 0;
    private  int player02Score = 0;
    public GameObject ball;
    public static bool canAddScore = true;
	// Use this for initialization
	void Start () {
        bonus = this.GetComponent<AudioSource>();
        ball = GameObject.Find("Ball");
        victory = this.GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if (ball.transform.position.x >= 20f && canAddScore)
        {
            canAddScore = false;
           player01Score++ ; //if the ball get out of the screen from the right side the score of the player01 will increase
            bonus.Play();
        }
        if (ball.transform.position.x <= -20f && canAddScore)
        {
            canAddScore = false;
            player02Score++; //if the ball get out of the screen from the left side the score of the player02 will increase
            bonus.Play();
        }
        if( player01Score >= 10)
        {
            victory.Play();
            SceneManager.LoadScene(2);
            
        }
        if (player02Score >= 10)
        {
            victory.Play();
            SceneManager.LoadScene(3);
            
        }
        scoreboard.text = player01Score.ToString() + " - " + player02Score.ToString();
	}
}
