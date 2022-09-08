using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public Vector2 velocity;

    public float speed;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.velocity = new Vector2(-speed, myRigidbody.velocity.y);
            //myRigidbody.MovePosition(myRigidbody.position - velocity *Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.velocity = new Vector2(speed, myRigidbody.velocity.y);
            //myRigidbody.MovePosition(myRigidbody.position + velocity * Time.deltaTime);

        }
    }
}
