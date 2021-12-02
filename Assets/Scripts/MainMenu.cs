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
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public GameObject Title;
    public GameObject LevelSelectSubmenu;
    public GameObject SettingsSubmenu;
    public GameObject CreditsSubmenu;
    public AudioMixer MusicMixer;
    public AudioMixer EffectsMixer;
    
    GameObject[] FunObjects;

    // Makes sure the menu is properly set each time its loaded.
    void Start()
    {
        ResetMenu();
        FunObjects = GameObject.FindGameObjectsWithTag("Fun");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            foreach(GameObject fo in FunObjects)
            {
                fo.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range(-25f, 25f) * fo.GetComponent<Rigidbody2D>().mass, Random.Range(-25f, 25f) * fo.GetComponent<Rigidbody2D>().mass), ForceMode2D.Impulse);
            }
        }
    }

    // Unloads the Level Select and Settings submenu UIs, and loads the main title.
    public void ResetMenu()
    {
        LevelSelectSubmenu.SetActive(false);
        SettingsSubmenu.SetActive(false);
        CreditsSubmenu.SetActive(false);
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

    public void CreditsButton()
    {
        Title.SetActive(false);
        CreditsSubmenu.SetActive(true);
    }

    public void SetMasterVolume(float value)
    {
        AudioListener.volume = value;
    }

    public void SetMusicVolume(float value)
    {
        MusicMixer.SetFloat("MusicMixerVolume", value);
    }

    public void SetEffectsVolume(float value)
    {
        MusicMixer.SetFloat("EffectsMixerVolume", value);
    }

    public void QuitToDesktop()
    {
        Application.Quit();
    }
}
