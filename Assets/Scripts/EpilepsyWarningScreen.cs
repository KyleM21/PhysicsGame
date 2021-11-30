/**
 * @file EpilepsyWarningScreen.cs
 * @author Mit Bailey (mitbailey99@gmail.com)
 * @brief Warns users of flashing colors.
 * @version See Git tags for version information.
 * @date 2021.11.28
 *
 * @copyright Copyright (c) 2021
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EpilepsyWarningScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Quit.");
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
