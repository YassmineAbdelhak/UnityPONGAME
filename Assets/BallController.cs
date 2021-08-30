using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BallController : MonoBehaviour
{
    public GameObject player01;
    public GameObject player02;
    private Rigidbody2D rb;
    public AudioSource click;
    // Use this for initialization
    void Start()
    {
        click = this.GetComponent<AudioSource>();
        rb = this.GetComponent<Rigidbody2D>();
        player01 = GameObject.Find("Player01");
        player02 = GameObject.Find("Player02");
        StartCoroutine(Pause()); // when the game starts we call Pause which maid the ball waits two seconds before start moving
        CountScore.canAddScore = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(this.transform.position.x) >= 21f)
        {
            CountScore.canAddScore = true;
            this.transform.position = new Vector3(0f, 0f, 0f); //if the ball get out of the screen from the right side or the left it will be back to the centre
            StartCoroutine(Pause()); // when the ball get out of the screen it waits 2 seconds before it comes back
        }
    }
    IEnumerator Pause()
    {
        int directionX = Random.Range(-1, 2); // by these two variables we want the ball the go to different direction (6different directions) everytime it pauses
        int directionY = Random.Range(-1, 2);
        if (directionX == 0)
        {
            directionX = 1;
        }
        rb.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2); //the ball waits two seconds before start moving
        rb.velocity = new Vector2(15f * directionX, 15f * directionY);
    }
    private void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.gameObject.name == "Player01") 
        {
            if(player01.GetComponent<Rigidbody2D>().velocity.y > 0.5f) 
            {
                rb.velocity = new Vector2(15f, 15f);
            }
            else if (player01.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(15f, -15f);
            }
            else
            {
                rb.velocity = new Vector2(15f , 0f);
            }
            click.pitch = Random.Range(-0.8f, 1.2f); // it changes a little bit the sound of the clip so it will be more fun and real
            click.Play(); // sound play whenever there is a collision
        }
        if (hit.gameObject.name == "Player02")
        {
            if (player02.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                rb.velocity = new Vector2(-15f, 15f);
            }
            else if (player02.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                rb.velocity = new Vector2(-15f, -15f);
            }
            else
            {
                rb.velocity = new Vector2(-15f, 0f);
            }
            click.pitch = Random.Range(-0.8f, 1.2f);
            click.Play();
        }

    }
}
