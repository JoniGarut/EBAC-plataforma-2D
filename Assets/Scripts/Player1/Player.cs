using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [Header("P1 References")]

    #region P1 References

    [Header("Physics Setup")]

    public Rigidbody2D myRigidbody;
    
    public Vector2 friction = new Vector2(.1f, 0);

    public float speed;
    public float speedRun;

    private float _currentSpeed;

    public float forceJump = 50f;

    //[Header("Animation Setup")]

    [Header("Animation Player")]

    public string boolWalk;
    public string boolRun;
    public Animator p1Animator;

    #endregion


    // Update is called once per frame
    private void Update()
    {
        HandleJump();
        HandleMovement();

    }

    private void HandleMovement()
    {

        #region Basic Move X


        // RUN!!!!
        if (Input.GetKey(KeyCode.LeftControl))
            _currentSpeed = speedRun;
        else
            _currentSpeed = speed;

        // BASIC : x coord moves rigidbody left and right through velocity and keycode input
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = new Vector2(-_currentSpeed, myRigidbody.velocity.y);
            myRigidbody.transform.localScale = new Vector2(1, 1);
            p1Animator.SetBool(boolWalk, true);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = new Vector2(_currentSpeed, myRigidbody.velocity.y);
            myRigidbody.transform.localScale = new Vector2(-1, 1);
            p1Animator.SetBool(boolWalk, true);
        }
        else
        {
            p1Animator.SetBool(boolWalk, false);
        }

        //atrito
        if (myRigidbody.velocity.x < 0)
        {
            myRigidbody.velocity += friction;
        }
        else if (myRigidbody.velocity.x > 0)
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
        {
            myRigidbody.velocity = Vector2.up * forceJump;    
        }
    }

    #endregion
}
