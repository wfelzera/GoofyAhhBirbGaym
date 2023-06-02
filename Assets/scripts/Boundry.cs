using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundry : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "birb")
        {
            GameObject.Find("GameOverText").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("PlayButton").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("PlayButton").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("MenuText").GetComponent<TMP_Text>().enabled = true;
            GameObject.Find("MenuButton").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("MenuButton").GetComponent<BoxCollider2D>().enabled = true;

            collision.gameObject.GetComponent <death>().enabled = true;
            collision.gameObject.GetComponent<BirdMovement>().enabled = false;
        }
    }
}
