using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fs : MonoBehaviour
{
    public float start;
    public float end;
    private float timer;
    private void Start()
    {
        timer = Random.Range(start, end);
    }
    void Update()
    {
        if(timer <= 0)
        {
            GameObject fs_ = GameObject.Find("FallingStar");
            fs_.GetComponent<FallingStar>().enabled = true;
            fs_.GetComponent<FallingStar>().timer = 0;
            fs_.GetComponent<FallingStar>().idfk = 0;
            timer = Random.Range(start, end);
        }
        timer -= Time.deltaTime;
    }
}
