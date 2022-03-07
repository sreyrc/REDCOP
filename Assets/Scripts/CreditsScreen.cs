using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsScreen : MonoBehaviour
{
    public GameObject mainMenu;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
            Time.timeScale = 5f;
        else
            Time.timeScale = 1f;
    }

    public void BackToMainMenu()
    {
        mainMenu.SetActive(true);
        this.gameObject.SetActive(false);        
    }
}
