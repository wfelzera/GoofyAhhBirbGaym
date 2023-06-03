using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slow : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        difficulty.value /= 2;
        Destroy(this.gameObject);
    }
}
