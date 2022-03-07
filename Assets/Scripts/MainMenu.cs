using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject creditsScreen;
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Credits()
    {
        creditsScreen.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void CreditsRoll()
    {
        creditsScreen.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
