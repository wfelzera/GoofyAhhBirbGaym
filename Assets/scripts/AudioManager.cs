using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("bgm") == 0)
        {
            GameObject.Find("bg-music").GetComponent<AudioSource>().Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
