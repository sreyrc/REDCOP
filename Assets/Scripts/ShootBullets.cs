﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullets : MonoBehaviour
{
    public GameObject bullet;
  
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
            Instantiate(bullet, transform.position , transform.rotation);
    }
}
