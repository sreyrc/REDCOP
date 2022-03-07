using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreenOn : MonoBehaviour
{
    public GameObject deathScreen, checkForPause, player, footStepSound;

    private void Start()
    {
        deathScreen.SetActive(false);
        
    }
    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerStats>().health <= 0)
        {
            Destroy(footStepSound);
            deathScreen.SetActive(true);
            checkForPause.SetActive(false);
        }
    }

    public void RetryLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }   

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
