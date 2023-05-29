using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DayGamemodeSwitcher : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("GameModeSwitcher");
    }
}
