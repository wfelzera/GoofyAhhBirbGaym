using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class difficulty : MonoBehaviour
{
    public static float value;
    public float e_p;
    public float e_t;
    private float timer;

    private void Start()
    {
        value = 1;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= e_t)
        {
            timer = 0;
            value += e_p;
        }
    }
}
