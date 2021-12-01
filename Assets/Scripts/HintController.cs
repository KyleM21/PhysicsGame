// Spawns hints for the player. The player can dismiss hints by clicking on them.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintController : MonoBehaviour
{
    public GameObject[] GameHints;
    int HintIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject go in GameHints)
        {
            go.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0)
        {
            if (HintIndex == 0)
            { // First
                GameHints[0].SetActive(true);
                HintIndex++;
            }
            else if (HintIndex < GameHints.Length)
            {
                // If the previous hint has been made inactive, make the next one active.
                if (!GameHints[HintIndex - 1].activeSelf)
                {
                    GameHints[HintIndex - 1].SetActive(false);
                    GameHints[HintIndex].SetActive(true);
                    HintIndex++;
                }
            }
        }
    }
}
