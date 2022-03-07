using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacesPlayer : MonoBehaviour
{
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position - transform.position).magnitude < 10f)
        { 
            Vector2 lookDirection = player.transform.position - transform.position;
            float lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, lookAngle);
        }

        if (player.transform.position.x < transform.position.x)
            GetComponent<SpriteRenderer>().flipY = true;
        else
            GetComponent<SpriteRenderer>().flipY = false;
    }
}
