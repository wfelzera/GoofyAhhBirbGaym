using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchRS_ToRs : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("RSMenu");
    }
}
