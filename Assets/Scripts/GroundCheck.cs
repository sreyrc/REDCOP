using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    GameObject player;
    public bool isOnMovingPlatform = false;
    private void Start()
    {
        player = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground") || collision.collider.CompareTag("Platform"))
        {
            player.GetComponent<PlayerMovement>().jumpCount = 0;
            player.GetComponent<PlayerMovement>().isAirborne = false;
        }
    }
}
