using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalHitDetect : MonoBehaviour
{
    public GameObject VictoryMenu;

    void Start()
    {
        VictoryMenu.SetActive(false);
    }
	
	void OnTriggerEnter2D(Collider2D Object){
		if(Object.gameObject.tag == "Player"){
			Debug.Log("Goal Met");
            VictoryMenuHandler();
		}
	}

    void VictoryMenuHandler()
    {
        Time.timeScale = 0f;
        VictoryMenu.SetActive(true);
    }

    public void NextLevel()
    {
        Time.timeScale = 1;
        switch (SceneManager.GetActiveScene().name)
        {
            case "LevelOne":
            {
                SceneManager.LoadScene("LevelTwo");
                break;
            }
            case "LevelTwo":
            {
                SceneManager.LoadScene("LevelTres");
                break;
            }
            default:
            {
                SceneManager.LoadScene("MainMenu");
                break;
            }
        }
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
        VictoryMenu.SetActive(false);
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
