using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour{

    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;
    private bool grouned;
    

    void Start() {
       
    }

        void FixedUpdate() {
            grouned = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }

    void Update() {
        

        if (Input.GetKeyDown(KeyCode.W) && grouned)
        {
            Jump();
        }


        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }

        

    }
    void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
    }
}
