using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealthBar : MonoBehaviour
{
    public GameObject boss;
    BossStats bossStats;
    float oldLength;
    private void Start()
    {
        bossStats = boss.GetComponent<BossStats>();
        oldLength = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (bossStats.bossHit == true)
        {
            float newLength = transform.localScale.x * bossStats.bossHealth * 0.01f;
            transform.localScale = new Vector2(newLength, transform.localScale.y);
            transform.position = new Vector2(transform.position.x - (oldLength - newLength) / 24.5f, transform.position.y);
            oldLength = transform.localScale.x;
            bossStats.bossHit = false;
        }
        if (bossStats.bossHealth == 0)
            Destroy(gameObject);
    }
}
