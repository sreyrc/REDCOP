using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeverFlipEnemy : MonoBehaviour
{
    SpriteRenderer sprite;
    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        if (transform.parent.GetComponent<EnemyMovement>().reversed == true)
            sprite.flipX = true;
        else
            sprite.flipX = false;
    }
}
