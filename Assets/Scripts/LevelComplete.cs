using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public GameObject levelCompleteScreen, textUI, healthbarUI;
    // Start is called before the first frame update
    void Start()
    {
        levelCompleteScreen.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            levelCompleteScreen.SetActive(true);
            textUI.SetActive(false);
            healthbarUI.SetActive(false);
        }            
    }
}
            