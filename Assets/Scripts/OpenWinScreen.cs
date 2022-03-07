using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWinScreen : MonoBehaviour
{
    public GameObject boss, winScreen;

    // Update is called once per frame
    void Update()
    {
        if (boss.GetComponent<BossStats>().bossHealth <= 0)
            StartCoroutine(WinScreen());
    }

    IEnumerator WinScreen()
    {
        yield return new WaitForSeconds(4f);
        winScreen.SetActive(true);
    }
}
