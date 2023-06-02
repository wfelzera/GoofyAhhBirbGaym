using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DayHighscore : MonoBehaviour
{
    private void Update()
    {

        if (score_colider.score > PlayerPrefs.GetFloat("dhs"))
        {
            PlayerPrefs.SetFloat("dhs", score_colider.score);
            PlayerPrefs.Save();
        }
    }
}
