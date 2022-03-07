using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherScript : MonoBehaviour
{
    Vector2 stopPos;
    public int direction;
    public float speed, moveDistance, waitTime;
    float temp;

    private void Start()
    {
        StartCoroutine(CrusherMotion());
    }
    private void Update()
    {
        transform.Translate(Vector2.up * speed * direction * Time.deltaTime);
        if (Mathf.Abs(transform.position.y - stopPos.y) >= moveDistance)
        {
            StartCoroutine(CrusherMotion());
        }
    }

    IEnumerator CrusherMotion()
    {
         stopPos = transform.position;
            temp = speed;
            speed = 0;
            yield return new WaitForSeconds(1f);
            direction *= -1;
            speed = temp;
            yield return null;
    }
}

