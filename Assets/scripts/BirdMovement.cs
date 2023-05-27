using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{
    public float jumph;
    public float jump_cooldown;
    private float jump_cooldown_timer;
    void Start()
    {
        Transform transform = GetComponent<Transform>();
    }
    void Update()
    {
        transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.Space) && jump_cooldown_timer <= 0)
        {
            transform.position += new Vector3(0, jumph, 0);
            jump_cooldown_timer = jump_cooldown;
        }
        if(jump_cooldown_timer > 0)
        {
            jump_cooldown_timer -= Time.deltaTime;
        }
    }
}
