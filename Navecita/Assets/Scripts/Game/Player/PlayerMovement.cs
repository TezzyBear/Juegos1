using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D body2D;
    private float speed = 8f;
    private float maxVelocity = 4f;
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();      
    }
    

    private void FixedUpdate()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(body2D.velocity.x);

        float h = 0;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
            h = -1;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
            h = 1;
        }

        if (h > 0) {
            if (vel < maxVelocity) {
                forceX = speed;
            }
        } else if (h < 0) {
            if (vel < maxVelocity) {
                forceX = -speed;
            }
        } else {
            body2D.velocity = Vector2.zero;
        }
        body2D.AddForce(new Vector2(forceX, 0));
    }
}