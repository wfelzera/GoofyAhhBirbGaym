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
        if (Input.GetKeyDown(KeyCode.E))
        {
            PlayerPrefs.SetFloat("dhs", 100);
            PlayerPrefs.SetFloat("nhs", 100);
            PlayerPrefs.SetFloat("hhs", 100);
            PlayerPrefs.Save();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            PlayerPrefs.SetFloat("gb", 10);
            PlayerPrefs.Save();
        }
    }
}
