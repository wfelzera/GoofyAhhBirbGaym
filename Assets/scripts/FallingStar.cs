using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingStar : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;
    public float timer;
    public float fps;
    public float idfk;

    private void Start()
    {
        timer = 0;
        idfk = 0;
    }

    private void Update()
    {
        if (timer >= 1f / fps)
        {
            if(idfk == 0)
            {
                GetComponent<SpriteRenderer>().sprite = sprite1;
            }
            if (idfk == 1)
            {
                GetComponent<SpriteRenderer>().sprite = sprite2;
            }
            if (idfk == 2)
            {
                GetComponent<SpriteRenderer>().sprite = sprite3;
            }
            if (idfk == 3)
            {
                GetComponent<SpriteRenderer>().sprite = sprite4;
            }
            if (idfk == 4)
            {
                GetComponent<SpriteRenderer>().sprite = sprite5;
            }
            if (idfk == 5)
            {
                GetComponent<SpriteRenderer>().sprite = sprite6;
            }
            if (idfk == 6)
            {
                GetComponent<SpriteRenderer>().sprite = sprite7;
            }
            if (idfk == 7)
            { 
                GetComponent<SpriteRenderer>().sprite = sprite8;
            }
            if (idfk == 8)
            {
                GetComponent<SpriteRenderer>().sprite = sprite9;
            }
            if (idfk == 9)
            {
                GetComponent<SpriteRenderer>().sprite = sprite10;
            }
            if (idfk == 10)
            {
                GetComponent<SpriteRenderer>().sprite = sprite11;
                GetComponent<FallingStar>().enabled = false;
            }
            timer = 0;
            idfk++;
        }
        timer += Time.deltaTime;
    }
}
