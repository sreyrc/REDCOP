using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossStats : MonoBehaviour
{
    public GameObject finalExplosion, winScreen;
    public float bossHealth;
    public bool bossHit = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            bossHit = true;
            bossHealth -= Random.Range(0.5f, 2);
            StartCoroutine(WhiteFlash());
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        if (bossHealth <= 0)
        {
            Instantiate(finalExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    IEnumerator WhiteFlash()
    {
        transform.GetChild(7).gameObject.SetActive(true);
        yield return new WaitForSeconds(0.05f);
        transform.GetChild(7).gameObject.SetActive(false);
    }
}
