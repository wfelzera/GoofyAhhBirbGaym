using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardHighscore : MonoBehaviour
{
    private void Update()
    {

        if (score_colider.score > PlayerPrefs.GetFloat("hhs"))
        {
            PlayerPrefs.SetFloat("hhs", score_colider.score);
            PlayerPrefs.Save();
        }
    }
}
