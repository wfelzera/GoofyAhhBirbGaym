using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GBFT : MonoBehaviour
{
    public float timer = -1f;

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f && timer > -1)
        {
            GetComponent<TMP_Text>().enabled = false;
        }
    }
}
