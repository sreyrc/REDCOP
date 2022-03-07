using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerMovement : MonoBehaviour
{
    public bool isAirborne, isTouchingWall;
    public float moveSpeed, jumpVelocity, wallJumpVelocity;
    public int jumpCount = 0;
    public bool reversed = false;
    Vector2 originallyFacing;
    Animator anim;
    Rigidbody2D rgbd;
    WallCheck wallcheck;
    public GameObject groundCheck;
    public GameObject footStepSound;
    void Start()
    {
        rgbd = GetComponent<Rigidbody2D>();
        wallcheck = GetComponent<WallCheck>();
        anim = GetComponent<Animator>();
        originallyFacing = transform.localScale;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //move left and right
        float inputX = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * inputX * moveSpeed * Time.fixedDeltaTime);

        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && isAirborne == false)
            footStepSound.SetActive(true);
        else
            footStepSound.SetActive(false);

        //jumping
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 2)
        { 
            rgbd.velocity = new Vector3(0, jumpVelocity, 0);
            isAirborne = true;
            jumpCount++;
        }

        //wall jumping
        if (isAirborne && isTouchingWall && Input.GetKeyDown(KeyCode.Space))
        {
            jumpCount = 0;
            rgbd.velocity = new Vector3(2f * wallcheck.directionX, wallJumpVelocity, 0);
        }

        //jumping animation
        if (isAirborne == true)
            anim.SetBool("jumping", true);
        else
            anim.SetBool("jumping", false);

        //running animation
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            anim.SetBool("moving", true);
        else
            anim.SetBool("moving", false);

        //flip character
        if (Input.GetKeyDown(KeyCode.A))
        { 
            transform.localScale = originallyFacing * new Vector2(-1, 1); 
            reversed = true; 
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localScale = originallyFacing;
            reversed = false;
        }
    }
}
