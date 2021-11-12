/**
 * @file EscMenuHandler.cs
 * @author Mit Bailey (mitbailey99@gmail.com)
 * @brief Handles the in-game menu.
 * @version See Git tags for version information.
 * @date 2021.11.10
 *
 * @copyright Copyright (c) 2021
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscMenuHandler : MonoBehaviour
{
    public GameObject EscapeMenu;
    public GameObject PlayButtonUI;

    // Start is called before the first frame update
    void Start()
    {
        EscapeMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (Time.timeScale > 0) Time.timeScale = 0; else if (!PlayButtonUI.activeSelf) Time.timeScale = 1;
            EscapeMenu.SetActive(!EscapeMenu.activeSelf);
        }
    }

    public void ResumeGame()
    {
        EscapeMenu.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
