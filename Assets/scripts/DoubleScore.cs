using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleScore : MonoBehaviour
{
    public static float timer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        timer = 5f;
        GetComponent<SpriteRenderer>().enabled = false;
    }
    void Update()
    {
        if(timer >= 0)
        {
            score_colider.ds_active = 1;
        } else if(score_colider.ds_active == 1)
        {
            score_colider.ds_active = 0;
        }
        timer -= Time.deltaTime;
    }
}
