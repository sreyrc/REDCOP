using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootBullets : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShootBullet());
    }

    IEnumerator ShootBullet()
    {
        for (int i = 0; ; i++)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));
            Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
