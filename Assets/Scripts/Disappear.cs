using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappear : MonoBehaviour
{
    BoxCollider2D boxCollider;
    SpriteRenderer sprite;
    public float initWaitTime, waitTime;
    Color temp;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        temp = sprite.material.color;
        StartCoroutine(DisappearCor());
    }

    IEnumerator DisappearCor()
    {
        yield return new WaitForSeconds(initWaitTime);
        for (int i = 0; ; i++)
        {
            boxCollider.isTrigger = true;
            temp.a = 0;
            sprite.color = temp;
            yield return new WaitForSeconds(waitTime);
            boxCollider.isTrigger = false;
            temp.a = 1;
            sprite.color = temp;
            yield return new WaitForSeconds(waitTime);
        }
    }
}
