using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    private Rigidbody2D body;

    private float speed = 1f;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    



    // De Active a Inactive
    void OnEnable () {        
        body.velocity = new Vector2(0, -speed);
	}

}
