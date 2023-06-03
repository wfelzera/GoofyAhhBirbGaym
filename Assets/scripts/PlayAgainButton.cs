using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        score_colider.score = 0;
        difficulty.value = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            score_colider.score = 0;
            difficulty.value = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
