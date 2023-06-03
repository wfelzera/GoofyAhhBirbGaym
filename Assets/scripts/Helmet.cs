using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : MonoBehaviour
{
    public static int active;
    public Sprite b1;
    public Sprite b2;
    public Sprite b3;
    public Sprite gb1;
    public Sprite gb2;
    public Sprite gb3;
    public Sprite b1_;
    public Sprite b2_;
    public Sprite b3_;
    public Sprite gb1_;
    public Sprite gb2_;
    public Sprite gb3_;

    private void Start()
    {
        if (PlayerPrefs.GetInt("gb") == 1)
        {
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite1 = gb1;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite2 = gb2;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite3 = gb3;
        }
        else
        {
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite1 = b1;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite2 = b2;
            GameObject.Find("birb").GetComponent<BirdAnimation>().sprite3 = b3;
        }
    }

    private void Update()
    {
        if(active == 1)
        {
            if (PlayerPrefs.GetInt("gb") == 1)
            {
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite1 = gb1;
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite2 = gb2;
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite3 = gb3;
            }
            else
            {
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite1 = b1;
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite2 = b2;
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite3 = b3;
            }
        }
        if(active == 0)
        {
            if (PlayerPrefs.GetInt("gb") == 1)
            {
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite1 = gb1_;
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite2 = gb2_;
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite3 = gb3_;
            }
            else
            {
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite1 = b1_;
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite2 = b2_;
                GameObject.Find("birb").GetComponent<BirdAnimation>().sprite3 = b3_;
            }
            GetComponent<Helmet>().enabled = false;
        }
    }
}
