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
    public void PlayButton()
    {
        SceneManager.LoadScene("LevelOne");
    }

    public void LevelSelectButton()
    {
        Debug.Log("Level Selection button pressed.");
    }

    public void SettingsButton()
    {
        Debug.Log("Settings button pressed.");
    }
}
