using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    float movement = 0f;

    public float movementSpeed = 5f;

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        movement = Input.GetAxis("Horizontal");
	}

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement * movementSpeed;
        rb.velocity = velocity;
    }
}
