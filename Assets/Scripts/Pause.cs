using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseScreen, player;

    private void Start()
    {
        pauseScreen.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            PauseGame();
    }

    void PauseGame()
    {
        DeactivateComponents();
        pauseScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        ReactivateComponents();
        pauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    public void QuitToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    void DeactivateComponents()
    {
        player.gameObject.transform.GetChild(0).GetComponent<FaceCursor>().enabled = false;
        player.gameObject.transform.GetChild(5).GetComponent<FaceCursor>().enabled = false;
        player.gameObject.transform.GetChild(5).GetComponent<ShootBullets>().enabled = false;
    }

    void ReactivateComponents()
    {
        player.gameObject.transform.GetChild(0).GetComponent<FaceCursor>().enabled = true;
        player.gameObject.transform.GetChild(5).GetComponent<FaceCursor>().enabled = true;
        player.gameObject.transform.GetChild(5).GetComponent<ShootBullets>().enabled = true;
    }
}
