using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public Vector2 friction = new Vector2(.1f, 0);

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

        #region Basic Move X

        // BASIC : x coord moves rigidbody left and right through velocity and keycode input
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = new Vector2(-speed, myRigidbody.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = new Vector2(speed, myRigidbody.velocity.y);
        }

        //atrito
        if (myRigidbody.velocity.x < 0)
        {
            myRigidbody.velocity += friction;
        }
        if (myRigidbody.velocity.x > 0)
        {
            myRigidbody.velocity -= friction;
        }

        #endregion
    }

    #region JUMP Y

    // BASIC : y coord moves through vector2.UP multiplied by forceJump reference in unity and keycode input 
    private void HandleJump()
    {
        if (Input.GetKey(KeyCode.Space))
            myRigidbody.velocity = Vector2.up * forceJump;
    }

    #endregion
}
