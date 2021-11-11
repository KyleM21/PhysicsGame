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

    // public void PlayButton()
    // {
    //     SceneManager.LoadScene("LevelOne");
    // }

    void Start()
    {
        ResetMenu();
    }

    public void ResetMenu()
    {
        LevelSelectSubmenu.SetActive(false);
        SettingsSubmenu.SetActive(false);
        Title.SetActive(true);
    }

    public void LevelSelectButton()
    {
        Debug.Log("Level Selection button pressed.");

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
        Debug.Log("Settings button pressed.");

        Title.SetActive(false);
        SettingsSubmenu.SetActive(true);
    }
}
