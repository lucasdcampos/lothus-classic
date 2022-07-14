using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lobby : MonoBehaviour
{
    [SerializeField] GameObject settings;
    [SerializeField] GameObject menu;
    [SerializeField] GameObject credits;
    [SerializeField] GameObject achievements;
    [SerializeField] GameObject host;
    [SerializeField] Camera cam;
    [SerializeField] Transform camPosMenu;
    [SerializeField] Transform camPosLobby;
    [SerializeField] bool lobby;
    private void Start()
    {
        cam = FindObjectOfType<Camera>();
        cam.transform.Rotate(0, 0.3f * Time.deltaTime, 0);
    }

    private void Update()
    {
        if (!lobby)
        {
            cam.transform.Rotate(0, 0.3f * Time.deltaTime, 0);
        }
    }

    public void Host()
    {
        lobby = true;
        host.SetActive(true);
        menu.SetActive(false);
        cam.transform.position = camPosLobby.transform.position;
        cam.transform.rotation = camPosLobby.transform.rotation;
    }

    public void PlayOffline()
    {
        SceneManager.LoadScene("Game");
    }


    public void Quit()
    {
        Application.Quit();
    }

    public void Settings()
    {
        settings.SetActive(true);
        menu.SetActive(false);
    }

    public void Credits()
    {
        credits.SetActive(true);
        menu.SetActive(false);
    }


    public void Achievements()
    {
        achievements.SetActive(true);
        menu.SetActive(false);
    }




    public void Back()
    {
        lobby = false;
        settings.SetActive(false);
        credits.SetActive(false);
        achievements.SetActive(false);
        menu.SetActive(true);
        host.SetActive(false);
        cam.transform.position = camPosMenu.transform.position;
        cam.transform.rotation = camPosMenu.transform.rotation;

    }


}