using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetect : MonoBehaviour
{
    public float seeDistance;
    public GameObject player;

    // Start is called before the first frame update
    void Awake()
    {
        gameObject.transform.GetChild(0).GetComponent<EnemyFacesPlayer>().enabled = false;
        gameObject.transform.GetChild(4).GetComponent<EnemyFacesPlayer>().enabled = false;
        gameObject.transform.GetChild(4).GetComponent<EnemyShootBullets>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceX = Mathf.Abs(player.transform.position.x - transform.position.x);
        float distanceY = Mathf.Abs(player.transform.position.y - transform.position.y);
        if (distanceX <= seeDistance && distanceY < 2)
            DetectPlayer();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
            DetectPlayer();
    }

    void DetectPlayer()
    {
        GetComponent<EnemyMovement>().enabled = true;
        gameObject.transform.GetChild(0).GetComponent<EnemyFacesPlayer>().enabled = true;
        gameObject.transform.GetChild(4).GetComponent<EnemyFacesPlayer>().enabled = true;
        gameObject.transform.GetChild(4).GetComponent<EnemyShootBullets>().enabled = true;
        GetComponent<PlayerDetect>().enabled = false;
    }
}
