using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float gravity;
    public float jumpforce;
    private float speed = 0;
    void Start()
    {
        Transform transform = GetComponent<Transform>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            speed = jumpforce;
        }
        else
        {
            speed -= gravity * Time.deltaTime;
        }

        transform.position += new Vector3(0, speed * Time.deltaTime);
    }
}
