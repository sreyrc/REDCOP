using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    Animator anim;
    BomberScript bomber;
    BossShootsBullets bossShoots;
    public GameObject gun;
    void Awake()
    {
        anim = GetComponent<Animator>();
        bomber = GetComponent<BomberScript>();
        bossShoots = gun.GetComponent<BossShootsBullets>();
        bomber.dropBombs = false;
        bossShoots.bossCanShoot = false;
        StartCoroutine(MovementRoutine());
    }

    IEnumerator MovementRoutine()
    {
        yield return new WaitForSeconds(3f);
        bossShoots.bossCanShoot = true;
        anim.SetBool("bossFightStarts",true);

        for (int i=0; ;i++)
        {
            int move = Random.Range(1, 5);

            if (move == 1)
            {
                //ground swoosh
                bossShoots.bossCanShoot = false;
                anim.SetBool("groundSwoosh", true);
                yield return new WaitForSeconds(3.5f);
                anim.SetBool("groundSwoosh", false);
                bossShoots.bossCanShoot = true;
            }

            if (move == 2)
            {
                //ground swoosh 2
                bossShoots.bossCanShoot = false;
                anim.SetBool("groundSwoosh2", true);
                yield return new WaitForSeconds(3.5f);
                anim.SetBool("groundSwoosh2", false);
                bossShoots.bossCanShoot = true;
            }

            if (move == 3)
            {
                //left to right
                bossShoots.bossCanShoot = false;
                bomber.dropBombs = true;
                anim.SetBool("leftToRight", true);
                yield return new WaitForSeconds(4.1f);
                anim.SetBool("leftToRight", false);
                bossShoots.bossCanShoot = true;
            }

            if (move == 4)
            {
                //right to left
                bossShoots.bossCanShoot = false;
                bomber.dropBombs = true;
                anim.SetBool("rightToLeft", true);
                yield return new WaitForSeconds(4.1f);
                anim.SetBool("rightToLeft", false);
                bossShoots.bossCanShoot = true;
            }

            yield return new WaitForSeconds(1.5f);
        }
    }
    
}
