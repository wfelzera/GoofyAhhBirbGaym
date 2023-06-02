using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenBirdApplyer : MonoBehaviour
{
    public Sprite gb1;
    public Sprite gb2;
    public Sprite gb3;
    void Start()
    {
        if(PlayerPrefs.GetInt("gb") == 1)
        {
            GameObject.Find("birb").GetComponent<SpriteRenderer>().sprite = gb1;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite1 = gb1;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite2 = gb2;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite3 = gb3;
        }
    }
}
