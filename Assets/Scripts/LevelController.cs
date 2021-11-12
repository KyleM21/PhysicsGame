using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public GameObject PlayButtonUI;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunSimButton()
    {
        Debug.Log("Play button hit");

        Time.timeScale = Time.timeScale > 0 ? 0 : 1;

        PlayButtonUI.SetActive(false);

    }
}
