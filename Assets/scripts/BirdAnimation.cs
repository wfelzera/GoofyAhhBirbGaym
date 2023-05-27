using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAnimation : MonoBehaviour
{
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public float fps;
    private float timer;
    private int idfk;

    private void Update()
    {
        if(timer >= 1f / fps)
        {
            timer = 0;
            idfk++;
            if(idfk % 4 == 0)
            {
                GetComponent<SpriteRenderer>().sprite = sprite1;
            }
            if (idfk % 4 == 1)
            {
                GetComponent<SpriteRenderer>().sprite = sprite2;
            }
            if (idfk % 4 == 2)
            {
                GetComponent<SpriteRenderer>().sprite = sprite3;
            }
            if (idfk % 4 == 3)
            {
                GetComponent<SpriteRenderer>().sprite = sprite2;
            }
        }
        timer += Time.deltaTime;
    }
}
