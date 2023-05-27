using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "birb")
        {
            collision.gameObject.SetActive(false);
            GameObject.Find("GameOverText").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("PlayButton").GetComponent<SpriteRenderer>().enabled = true;
            GameObject.Find("PlayButton").GetComponent<BoxCollider2D>().enabled = true;
        }
    }
}
