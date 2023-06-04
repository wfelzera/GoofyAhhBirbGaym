using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BGMButton : MonoBehaviour
{
    public static int cnt;

    private void OnMouseDown()
    {
        cnt++;
        if(cnt % 2 == 1)
        {
            PlayerPrefs.SetInt("bgm", 1);
            GameObject.Find("BGMStatus").GetComponent<TMP_Text>().text = "OFF";
            GameObject.Find("BGMStatus").GetComponent<TMP_Text>().color = Color.red;
        }
        if (cnt % 2 == 0)
        {
            PlayerPrefs.SetInt("bgm", 1);
            GameObject.Find("BGMStatus").GetComponent<TMP_Text>().text = "ON";
            GameObject.Find("BGMStatus").GetComponent<TMP_Text>().color = Color.green;
        }
    }
}
