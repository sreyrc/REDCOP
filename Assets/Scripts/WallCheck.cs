using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCheck : MonoBehaviour
{
    PlayerMovement player;
    public int directionX;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<PlayerMovement>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall"))
        {
            player.isTouchingWall = true;
            if (collision.collider.transform.position.x < transform.position.x)
                directionX = 1;
            else
                directionX = -1;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Wall"))
            player.isTouchingWall = false;
    }
}
