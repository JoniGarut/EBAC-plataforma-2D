using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public Vector2 velocity;

    public float speed;

    public float forceJump = 50f;


    // Update is called once per frame
    private void Update()
    {
        HandleJump();
        HandleMovement();

    }

    private void HandleMovement()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = new Vector2(-speed, myRigidbody.velocity.y);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = new Vector2(speed, myRigidbody.velocity.y);
        }
    }

    private void HandleJump()
    {
        if (Input.GetKey(KeyCode.Space))
            myRigidbody.velocity = Vector2.up * forceJump;
    }
}
