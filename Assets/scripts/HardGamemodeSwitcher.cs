using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HardGamemodeSwitcher : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("HardGamemodeSwitcher");
    }
}
