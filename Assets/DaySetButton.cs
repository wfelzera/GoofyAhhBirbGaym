using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DaySetButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Settings");
    }
}
