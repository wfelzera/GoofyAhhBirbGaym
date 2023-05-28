using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{
    public float rot_speed;
    public float fall_speed;
    private float angle;
    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.red;
    }
    void Update()
    {
        angle += rot_speed * Time.deltaTime;
        transform.Rotate(0, 0, angle);
        transform.position -= new Vector3(0, fall_speed * Time.deltaTime, 0);
    }
}
