using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boundry : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "birb")
        {
            collision.gameObject.SetActive(false);
            GameObject.Find("GameOverText").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("PlayButton").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("PlayButton").GetComponent<BoxCollider2D>().enabled = true;
            GameObject.Find("MenuText").GetComponent<TMP_Text>().enabled = true;
            GameObject.Find("MenuButton").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("MenuButton").GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
