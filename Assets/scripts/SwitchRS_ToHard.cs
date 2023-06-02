using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchRS_ToHard : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("HardMenu");
    }
}
