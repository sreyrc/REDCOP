using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformsMovement : MonoBehaviour
{
    Vector2 tempPos;
    public float platformMoveSpeed;
    public float travelDistance;
    public int directionX; 
    void Start()
    {
        tempPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * directionX * platformMoveSpeed * Time.deltaTime);
        if (Mathf.Abs(transform.position.x - tempPos.x) >= travelDistance)
        { 
            tempPos = transform.position; 
            directionX *= -1;
        }
    }    
}
