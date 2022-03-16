using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {
    private Rigidbody2D player;
    private Collider2D playerColl;
    private float dirX, dirY, jumpHeight, moveSpeed;
    [SerializeField] private LayerMask jumpableLayers;


    // Start is called before the first frame update
    void Start() {
        player = GetComponent<Rigidbody2D>();
        playerColl = GetComponent<Collider2D>();
        jumpHeight = 235;
        moveSpeed = 100;
    }



    // Update is called once per frame
    void Update() {
        dirX = player.velocity.x;
        dirY = player.velocity.y;
        
        //horizontal movement
        dirX = moveSpeed * Input.GetAxisRaw("Horizontal");
        //vectical movement
        if(Input.GetButtonDown("Jump") && IsGrounded()==true) {
            dirY = jumpHeight;
        }
        player.velocity = new Vector2(dirX, dirY);
    }



    //check if player is touching the ground
    private bool IsGrounded(){
        //casts a box of length 1 downwards to check if character is touching the floor
        return Physics2D.BoxCast( playerColl.bounds.center, playerColl.bounds.size, 0, Vector2.down, 1f, jumpableLayers );
    }
}
