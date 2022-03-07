using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int health;
    public bool hitByBullet = false;
    public GameObject smallBloodSplash, bigBloodSplash, explosion, redden;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy Bullet") || collision.gameObject.CompareTag("Missile"))
        {
            hitByBullet = true; 
            if (collision.gameObject.CompareTag("Enemy Bullet"))
                health -= Random.Range(10, 20);
            if (collision.gameObject.CompareTag("Missile"))
            {
                health -= Random.Range(40, 50);
                Instantiate(explosion, transform.position, Quaternion.identity);
                Destroy(explosion, 2f);
            }
            StartCoroutine(ReddenScreen());
            Destroy(collision.gameObject);
            GameObject smallBloodSplashGO = Instantiate(smallBloodSplash, transform.position, Quaternion.identity);
            Destroy(smallBloodSplashGO, 2f);
        }

        if (collision.gameObject.CompareTag("Limit"))
            health = 0;
    }

    private void Update()
    {
        if (health <= 0)
        {
            Instantiate(bigBloodSplash, transform.position, Quaternion.identity);
            Destroy(gameObject,0.02f);
            Destroy(redden);
        }
    }

    IEnumerator ReddenScreen()
    {
        redden.SetActive(true);
        redden.GetComponent<Animator>().SetBool("hit", true);
        yield return new WaitForSeconds(0.4f);
        redden.SetActive(false);
        redden.GetComponent<Animator>().SetBool("hit", false);
    }


}
