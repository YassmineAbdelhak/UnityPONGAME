using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player01Controller : MonoBehaviour {
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, 10f); // player01 position and it's velocity while moving it up with the key W
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0f, -10f); // player01 position and it's velocity while moving it up with the key S
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f); //else it doesn't move
        }

    }
}
