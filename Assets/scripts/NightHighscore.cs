using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NightHighscore : MonoBehaviour
{
    private void Update()
    {
        if (score_colider.score > PlayerPrefs.GetFloat("nhs"))
        {
            PlayerPrefs.SetFloat("nhs", score_colider.score);
            PlayerPrefs.Save();
        }
    }
}
