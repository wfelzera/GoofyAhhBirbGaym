using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class score_colider : MonoBehaviour
{
    public static int score;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "birb")
        {
            score++;
            GameObject.Find("ScoreText").GetComponent<TMP_Text>().text = score.ToString();
            this.GetComponent<score_colider>().enabled = false;
        }
    }
}
