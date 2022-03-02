using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    private Rigidbody2D rb;
    private float dirX, dirY, jumpHeight, moveSpeed;
    private bool isGrounded;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        jumpHeight = 265;
        moveSpeed = 110;
    }

    // Update is called once per frame
    void Update() {
        dirX = rb.velocity.x;
        dirY = rb.velocity.y;

        //get grounded state
        if(rb.velocity.y == 0) isGrounded = true;
        else isGrounded = false;

        //horizontal movement
        dirX = moveSpeed * Input.GetAxisRaw("Horizontal");
        //vectical movement
        if(isGrounded && Input.GetButtonDown("Jump")) {
            dirY = jumpHeight;
        }
        rb.velocity = new Vector2(dirX, dirY);
    }
}
