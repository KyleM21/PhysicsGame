// Spawns hints for the player. The player can dismiss hints by clicking on them.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintController : MonoBehaviour
{
    public GameObject HintHint; // Hint explaining hints
    public GameObject PlayHint; // Hint about how to move and the goal
    int HintState = 0;

    // Start is called before the first frame update
    void Start()
    {
        HintHint.SetActive(false);
        PlayHint.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (HintState == 1 && !HintHint.active)
        {
            PlayHint.SetActive(true);
            HintState++;
        }
        else if (HintState == 0 && Time.timeScale > 0)
        {
            HintHint.SetActive(true);
            HintState++;
        }
    }
}
