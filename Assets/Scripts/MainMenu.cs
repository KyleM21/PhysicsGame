/**
 * @file MainMenu.cs
 * @author Mit Bailey (mitbailey99@gmail.com)
 * @brief Functions for the buttons on the main menu.
 * @version See Git tags for version information.
 * @date 2021.10.30
 *
 * @copyright Copyright (c) 2021
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Title;
    public GameObject LevelSelectSubmenu;
    public GameObject SettingsSubmenu;

    // Makes sure the menu is properly set each time its loaded.
    void Start()
    {
        ResetMenu();
    }

    // Unloads the Level Select and Settings submenu UIs, and loads the main title.
    public void ResetMenu()
    {
        LevelSelectSubmenu.SetActive(false);
        SettingsSubmenu.SetActive(false);
        Title.SetActive(true);
        Time.timeScale = 1;
    }

    // Loads Level Select sub menu.
    public void LevelSelectButton()
    {
        Title.SetActive(false);
        LevelSelectSubmenu.SetActive(true);
    }

    public void LoadLevelOne()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void LoadLevelTwo()
    {
        SceneManager.LoadScene("LevelTwo");
    }

    public void LoadLevelThree()
    {
        SceneManager.LoadScene("LevelΤhree");
    }
    
    public void SettingsButton()
    {
        Title.SetActive(false);
        SettingsSubmenu.SetActive(true);
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
