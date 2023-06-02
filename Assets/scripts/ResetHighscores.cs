using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHighscores : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetFloat("dhs", 0);
            PlayerPrefs.SetFloat("nhs", 0);
            PlayerPrefs.SetFloat("hhs", 0);
            PlayerPrefs.SetFloat("gb", 0);
            PlayerPrefs.Save();
        }
    }
}
