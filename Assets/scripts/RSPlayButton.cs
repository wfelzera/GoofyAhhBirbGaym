using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RSPlayButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        score_colider.score = 0;
        difficulty.value = 0;
        SceneManager.LoadScene("RsGameScene");
    }
}
