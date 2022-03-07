using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreenScript : MonoBehaviour
{
    public GameObject blkbg, yyw, para, yaa, cktext, cookies, thnx, mainMenuBtn;
    void Start()
    {
        StartCoroutine(Ending());
    }

    IEnumerator Ending()
    {
        blkbg.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        yyw.SetActive(true);
        yield return new WaitForSeconds(4f);
        yyw.SetActive(false);
        para.SetActive(true);
        yield return new WaitForSeconds(8f);
        para.SetActive(false);
        yaa.SetActive(true);
        yield return new WaitForSeconds(4f);
        yaa.SetActive(false);
        cktext.SetActive(true);
        yield return new WaitForSeconds(1f);
        cookies.SetActive(true);
        yield return new WaitForSeconds(4f);
        cktext.SetActive(false);
        thnx.SetActive(true);
        yield return new WaitForSeconds(2f);
        mainMenuBtn.SetActive(true);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
