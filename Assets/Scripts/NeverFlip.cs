using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverFlip : MonoBehaviour
{
    SpriteRenderer sprite;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (transform.parent.GetComponent<PlayerMovement>().reversed == true)
            sprite.flipX = true;
        else
            sprite.flipX = false;
    }
}
