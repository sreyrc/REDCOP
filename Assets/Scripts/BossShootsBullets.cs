using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShootsBullets : MonoBehaviour
{
    float newShootTime;
    public GameObject bullet;
    public bool bossCanShoot = true;
    // Start is called before the first frame update
    void Update()
    {
        if (bossCanShoot == true && Time.time > newShootTime) 
        {
            Instantiate(bullet, transform.position, transform.rotation);
            newShootTime = Time.time + Random.Range(1, 3);
        }
    }
}
