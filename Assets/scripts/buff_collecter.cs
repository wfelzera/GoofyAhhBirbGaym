using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class buff_collecter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "birb")
        {
            if (Helmet.active == 0)
            {
                GetComponent<SpriteRenderer>().enabled = false;
                Helmet.active = 1;
                GameObject.Find("GameManager").GetComponent<Helmet>().enabled = true;
            }
        }
    }
}
