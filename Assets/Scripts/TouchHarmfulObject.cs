using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchHarmfulObject : MonoBehaviour
{
    public bool touchedHarmfulObject = false;
    public GameObject whiteFlash, redFlash;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Laser") || collision.collider.CompareTag("Boss"))
        {
            touchedHarmfulObject = true;
            GetComponent<PlayerStats>().health -= 20;
            if (collision.collider.CompareTag("Laser"))
                StartCoroutine(Flash());
        }
    }

    IEnumerator Flash()
    {
        redFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        whiteFlash.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        whiteFlash.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        redFlash.SetActive(false);
    }
}
