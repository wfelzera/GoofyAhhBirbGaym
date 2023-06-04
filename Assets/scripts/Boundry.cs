using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boundry : MonoBehaviour
{
    public GameObject vb;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "birb")
        {
            score_colider.ds_active = 0;
            if (Helmet.active == 0) {
                GameObject.Find("GameOverText").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("PlayButton").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("PlayButton").GetComponent<BoxCollider2D>().enabled = true;
                GameObject.Find("PlayButton").GetComponent<PlayAgainButton>().enabled = true;
                GameObject.Find("MenuText").GetComponent<TMP_Text>().enabled = true;
                GameObject.Find("MenuButton").GetComponent<SpriteRenderer>().enabled = true;
                GameObject.Find("MenuButton").GetComponent<BoxCollider2D>().enabled = true;

                collision.gameObject.GetComponent<death>().enabled = true;
                collision.gameObject.GetComponent<BirdMovement>().enabled = false;

                if(PlayerPrefs.GetInt("sfx") == 0) Instantiate(vb, new Vector3(transform.position.x, transform.position.y, -0.1f), Quaternion.identity);
                GameObject.Find("bg-music").GetComponent<AudioSource>().Stop();
            } else
            {
                Helmet.active = 0;
                Destroy(this.gameObject);
            }
        }
    }
}
