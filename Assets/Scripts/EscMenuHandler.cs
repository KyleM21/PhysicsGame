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
}
