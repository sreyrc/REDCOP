using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceCursor : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, lookAngle);

        if (Camera.main.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x)
            GetComponent<SpriteRenderer>().flipY = true; 
        else
            GetComponent<SpriteRenderer>().flipY = false;
    }
}
