using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour
{
    public GameObject smallBloodSplash, bigBloodSplash;
    public float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            health -= Random.Range(10, 20);
            Destroy(collision.gameObject);
            Destroy(obj: Instantiate(original: smallBloodSplash, transform.position, Quaternion.identity), t: 2f);
        }
    }

    private void Update()
    {
        if(health<=0)
        {
            Instantiate(bigBloodSplash, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
