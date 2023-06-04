using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GMS_Manager : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("DayHSText").GetComponent<TMP_Text>().text = ("- Highscore: " + PlayerPrefs.GetFloat("dhs") + " -");
        GameObject.Find("NightHSText").GetComponent<TMP_Text>().text = ("- Highscore: " + PlayerPrefs.GetFloat("nhs") + " -");
        GameObject.Find("HardHSText").GetComponent<TMP_Text>().text = ("- Highscore: " + PlayerPrefs.GetFloat("hhs") + " -");
        if (PlayerPrefs.GetFloat("dhs") >= 50)
        {
            GameObject.Find("NightButton").GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Find("NightButton").GetComponent<BoxCollider2D>().enabled = true;
        }
        if (PlayerPrefs.GetFloat("nhs") >= 50)
        {
            GameObject.Find("HardButton").GetComponent<SpriteRenderer>().color = Color.white;
            GameObject.Find("HardButton").GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
