using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthbar : MonoBehaviour
{
    public GameObject player;
    PlayerStats playerStats;
    TouchHarmfulObject touchHarmfulObject;
    float oldLength;
    private void Start()
    {
        playerStats = player.GetComponent<PlayerStats>();
        touchHarmfulObject = player.GetComponent<TouchHarmfulObject>();
        oldLength = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerStats.hitByBullet == true || touchHarmfulObject.touchedHarmfulObject == true) 
        {
            float newLength = transform.localScale.x * playerStats.health * 0.01f;
            transform.localScale = new Vector2(newLength, transform.localScale.y);
            transform.position = new Vector2(transform.position.x - (oldLength - newLength)/4.5f, transform.position.y);
            oldLength = transform.localScale.x;
            playerStats.hitByBullet = false;
            touchHarmfulObject.touchedHarmfulObject = false;
        }
        if(playerStats.health==0)
            Destroy(gameObject);
    }
}
