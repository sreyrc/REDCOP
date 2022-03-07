using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCrushed : MonoBehaviour
{
    public bool contactWithCrusher = false, contactWithOtherCollider = false;

    private void Update()
    {
        if (contactWithCrusher == true && contactWithOtherCollider == true)
            GetComponent<PlayerStats>().health = 0;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Crusher"))
            contactWithCrusher = true;
        if (collision.gameObject.CompareTag("Collider") || collision.collider.CompareTag("Ground"))
            contactWithOtherCollider = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Crusher"))
            contactWithCrusher = false;
        if (collision.collider.CompareTag("Collider") || collision.collider.CompareTag("Ground"))
            contactWithOtherCollider = false;
    }
}
