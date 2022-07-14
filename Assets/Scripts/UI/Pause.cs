using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    public GameManager gm;


    void Start()
    {

        gm.isPaused = false;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            if (gm.isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }

        }

    }


    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        gm.isPaused = true;

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        gm.isPaused = false;
    }

    public void Home()
    {
        gm.isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Lobby");
    }



}