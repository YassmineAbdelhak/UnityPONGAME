using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player02Controller : MonoBehaviour {

    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(0f, 10f); // player02 position and it's velocity while moving it up with the key up Arrow 
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(0f, -10f); // player02 position and it's velocity while moving it down with the key down Arrow 
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f); //else it doesn't move
        }

    }
}
